using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Server.Kestrel.Core;
using Microsoft.Extensions.Hosting;
using System.Net;

namespace kli.NewService
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
					if (args.Length > 0 && args[0] == "local" && int.TryParse(args[1], out var port))
					{
						webBuilder.ConfigureKestrel(options =>
						{
							options.Listen(IPAddress.Any, port, listenOptions =>
							{
								listenOptions.Protocols = HttpProtocols.Http2;
							});
						});
					}
					
					webBuilder.UseStartup<Startup>();
				});
		}
	}
}
