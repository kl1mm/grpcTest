﻿using Grpc.Core;
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
			return new Channel(target, new SslCredentials(File.ReadAllText(publicKeyFilePath)));
		}
	}
}
