using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Server.Kestrel.Core;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;

namespace kli.CalculatorService
{
	public class Program
	{
		public static void Main(string[] args)
		{
			CreateHostBuilder(args).Build().Run();
		}

		public static IHostBuilder CreateHostBuilder(string[] args)
		{
			return Host.CreateDefaultBuilder(args)
				.ConfigureWebHostDefaults(webBuilder =>
				{
					webBuilder.ConfigureKestrel(SetupKestrel);
					webBuilder.UseStartup<Startup>();
				});
		}

		private static void SetupKestrel(WebHostBuilderContext ctx, KestrelServerOptions options)
		{
			const int defaultPort = 443;
			var servicePort = ctx.Configuration.GetValue("servicePort", 4444);

			options.ListenAnyIP(servicePort, listenOptions =>
			{
				listenOptions.Protocols = HttpProtocols.Http2;
				if (servicePort == defaultPort)
					listenOptions.UseHttps("calculatorCert.pfx", "calc123");
			});
		}
	}
}
