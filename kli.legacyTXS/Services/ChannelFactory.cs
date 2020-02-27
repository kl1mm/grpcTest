using Grpc.Core;
using System.IO;

namespace kli.legacyTXS.Services
{
	internal interface IChannelFactory
	{
		Channel Create(string traget, string publicKeyFilePath = null);
	}

	internal class OnPremiseChannelFactory : IChannelFactory
	{
		Channel IChannelFactory.Create(string target, string publicKeyFilePath)
			=> new Channel($"localhost:{target}", ChannelCredentials.Insecure);
	}

	internal class CloudChannelFactory : IChannelFactory
	{
		Channel IChannelFactory.Create(string target, string publicKeyFilePath)
		{
			//"WS037405.agensgruppe.local:5555"; certificate.pem 
			//return new Channel(target, new SslCredentials(File.ReadAllText(publicKeyFile))); 
			return new Channel(target, new SslCredentials(File.ReadAllText(publicKeyFilePath)));
			//return new Channel(target, SslCredentials.Insecure);
		}
	}
}
