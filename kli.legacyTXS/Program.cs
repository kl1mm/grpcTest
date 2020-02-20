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
			appHost = new HostBuilder()
				.ConfigureAppConfiguration((context, configurationBuilder) =>
				{
					configurationBuilder.SetBasePath(context.HostingEnvironment.ContentRootPath);
					configurationBuilder.AddJsonFile("appsettings.json", optional: false);
					configurationBuilder.AddCommandLine(args);
				})
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
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(services.GetService<MainForm>());
		}
	}
}
