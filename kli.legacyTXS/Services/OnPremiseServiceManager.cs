using kli.legacyTXS.Configs;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Options;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using TXS.Shared.Extensions;

namespace kli.legacyTXS.Services
{
	internal class OnPremiseServiceManager : IHostedService
	{
		private IReadOnlyCollection<string> serviceProcesses;
		private readonly ServicesConfig servicesConfig;

		public OnPremiseServiceManager(IOptions<ServicesConfig> servicesConfigAccessor)
		{
			this.servicesConfig = servicesConfigAccessor.Value;
		}

		Task IHostedService.StartAsync(CancellationToken cancellationToken)
		{
			this.serviceProcesses = this.servicesConfig.Services
				.Where(sc => !string.IsNullOrWhiteSpace(sc.Startup))
				.Select(sc => new ProcessStartInfo
				{
					FileName = sc.Startup,
					Arguments = $"--servicePort {sc.Endpoint}",
					CreateNoWindow = true,
					UseShellExecute = false,
				})
				.Select(Process.Start)
				.Select(p => p.ProcessName)
				.ToReadOnly();

			return Task.CompletedTask;
		}

		Task IHostedService.StopAsync(CancellationToken cancellationToken)
		{
			this.serviceProcesses?
				.SelectMany(Process.GetProcessesByName)
				.Where(process => !process.HasExited)
				.ForEach(process =>
				{
					process.Kill();
					process.WaitForExit();
				});

			return Task.CompletedTask;
		}
	}
}