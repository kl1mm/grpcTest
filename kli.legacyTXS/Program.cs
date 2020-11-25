using Grpc.Core;
using kli.legacyTXS.Configs;
using kli.legacyTXS.Services;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Windows.Forms;

namespace kli.legacyTXS
{
	internal static class Program
	{
		private static IHost appHost;

		[STAThread]
		private static void Main(string[] args)
		{
			appHost = Host.CreateDefaultBuilder(args)
				.ConfigureServices((context, services) =>
				{
					services.Configure<ServicesConfig>(context.Configuration,
						binder => binder.BindNonPublicProperties = true);

					services.AddSingleton<MainForm>();
					services.AddServiceClients();
				})
				.Build();

			var hostLifetime = appHost.Services.GetService<IHostApplicationLifetime>();
			hostLifetime.ApplicationStarted.Register(() => OnApplicationStart(appHost.Services));

			appHost.RunAsync().Wait();
		}

		private static void OnApplicationStart(IServiceProvider services)
		{
			Application.ThreadException += (s, args) => {
				if(args.Exception is RpcException e)
					MessageBox.Show(e.Status.Detail, e.StatusCode.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
			};

			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(services.GetService<MainForm>());
		}
	}
}
