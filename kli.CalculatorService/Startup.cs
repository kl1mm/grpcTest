using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using kli.CalculatorService.Grpc;

namespace kli.CalculatorService
{
	public class Startup
	{
		public void ConfigureServices(IServiceCollection services)
		{
			services.AddAntiforgery();

			services.AddGrpc(options =>
            {
                options.Interceptors.Add<GrpcLoggerInterceptor>();
            });
		}

		public void Configure(IApplicationBuilder app)
		{
			app.UseRouting();
			app.UseEndpoints(endpoints =>
			{
				endpoints.MapGrpcService<CalculatorGrpc>();
			});
		}
	}
}
