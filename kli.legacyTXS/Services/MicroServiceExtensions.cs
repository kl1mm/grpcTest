using Grpc.Core;
using kli.GRPC;
using kli.legacyTXS.Configs;
using kli.legacyTXS.Microservices;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using System;
using TXS.Shared.Extensions;
using static kli.GRPC.Calculator;

namespace kli.legacyTXS.Services
{
	internal static class MicroServiceExtensions
	{
		public static IServiceCollection AddMicroServiceClients(this IServiceCollection services)
		{
			return services
				.AddHostedService<OnPremiseServiceManager>()
				.AddGrpcClient<CalculatorClient>();
		}

		private static IServiceCollection AddGrpcClient<TClient>(this IServiceCollection services)
			where TClient : ClientBase<TClient>
		{
			return services.AddSingleton(sp =>
			{
				var config = sp.GetService<IOptions<ServicesConfig>>().Value.GetServiceConfig(nameof(Calculator));
				IChannelFactory channelFacotry = new OnPremiseChannelFactory();
				if (string.IsNullOrWhiteSpace(config.Startup))
					channelFacotry = new CloudChannelFactory();

				var channel = channelFacotry.Create(config.Endpoint, config.TlsPublicKeyFile);

				var client = typeof(TClient).CreateInstance<TClient>(channel);
				return new ServiceClient<TClient>(client, channel);
			});
		}
	}
}
