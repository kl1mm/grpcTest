using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using kli.CalculatorService.Grpc;

namespace kli.CalculatorService
{
	public class Startup
	{
		public void ConfigureServices(IServiceCollection services)
		{
			services.AddGrpc();
		}

		public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
		{
			app.UseRouting();
			app.UseEndpoints(endpoints =>
			{
				endpoints.MapGrpcService<CalculatorGrpc>();
				endpoints.Map("/", ctx =>
				{
					return ctx.Response.WriteAsync("Hello from Calculator UI");
				});
			});
		}
	}
}
