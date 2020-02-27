using Grpc.Net.Client;
using System;
using System.Net.Http;
using Grpc.Net.Client.Web;
using kli.GRPC;
using static kli.GRPC.CalculationMessage.Types;
using Grpc.Core;
using System.IO;
using System.Collections.Generic;

namespace kli.NewClient
{
	class Program
	{
		static void Main(string[] args)
		{
			//var channel = GrpcChannel.ForAddress("https://kligrpc.azurewebsites.net", new GrpcChannelOptions
			
			//var handler = new GrpcWebHandler(GrpcWebMode.GrpcWebText, new HttpClientHandler());

			//var client = new Calculator.CalculatorClient(channel);
			//Console.WriteLine(client.Calc(new CalculationMessage { Operand = Operand.Multipy, Lhs = 13, Rhs = 20 }));
			//Console.ReadLine();

			//var channel = GrpcChannel.ForAddress("http://10.0.75.1:5001/");
			//var channel = GrpcChannel.ForAddress("https://10.10.103.150:5001/");


			// Return `true` to allow certificates that are untrusted/invalid

			//var httpClientHandler = new HttpClientHandler();
			//httpClientHandler.ServerCertificateCustomValidationCallback = HttpClientHandler.DangerousAcceptAnyServerCertificateValidator;
			//var httpClient = new HttpClient(httpClientHandler);
			var newChannel = GrpcChannel.ForAddress("https://calculator.northeurope.azurecontainer.io");
			DoIt(newChannel, "NEW");
			
			var sslCredentials = new SslCredentials(File.ReadAllText("publicCert.pem"));
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
