using kli.grpcTest.GRPC;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace kli.NewService
{
	public class Startup
	{
		public void ConfigureServices(IServiceCollection services)
		{
			services.AddGrpc();
            services.AddCors(o =>
            {
                o.AddPolicy("InteropTests", builder =>
                {
                    builder.AllowAnyOrigin();
                    builder.AllowAnyMethod();
                    builder.AllowAnyHeader();
                    builder.WithExposedHeaders("Grpc-Status", "Grpc-Message");
                });
            });
		}

		public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
		{
			if (env.IsDevelopment())
				app.UseDeveloperExceptionPage();

			app.UseRouting();

			app.UseCors();
			app.UseGrpcWeb();

			app.UseEndpoints(endpoints =>
			{
				endpoints.MapGrpcService<CalculatorGRPCService>().RequireCors("InteropTests").EnableGrpcWeb();
				endpoints.Map("/", async ctx => 
				{
					await ctx.Response.WriteAsync("Hello from NewSerivce - 13");
				});
			});
		}
	}
}
