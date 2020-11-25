using Grpc.Net.Client;
using System;
using System.Net.Http;
using Grpc.Net.Client.Web;
using kli.GRPC;
using static kli.GRPC.CalculationMessage.Types;
using Grpc.Core;
using System.IO;
using System.Security.Cryptography.X509Certificates;

namespace kli.NewClient
{
	class Program
	{
		static void Main(string[] args)
		{
			var newChannel = GrpcChannel.ForAddress("https://calculator.northeurope.azurecontainer.io");
			DoIt(newChannel, "NEW");

			var sslCredentials = new SslCredentials(File.ReadAllText("publicCert.pem")); // TODO: cert aus Store laden
			var oldChannel = new Channel("calculator.northeurope.azurecontainer.io", sslCredentials);
			DoIt(oldChannel, "OLD");

			Console.ReadLine();
		}

		private static void DoIt(ChannelBase channel, string msg)
		{
			try
			{
				var client = new Calculator.CalculatorClient(channel);
				Console.WriteLine(msg + " " + client.Calc(new CalculationMessage { Lhs = 13, Rhs = 42, Operand = Operand.Plus }));
			}
			catch (RpcException e)
			{
				Console.WriteLine($"something went terrible wrong: {e.StatusCode} - {e.Status.Detail}");
			}
		}
	}
}
