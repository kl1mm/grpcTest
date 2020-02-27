using Grpc.Net.Client;
using System;
using System.Net.Http;
using Grpc.Net.Client.Web;
using kli.GRPC;
using static kli.GRPC.CalculationMessage.Types;

namespace kli.NewClient
{
	class Program
	{
		static void Main(string[] args)
		{
			//var channel = GrpcChannel.ForAddress("https://kligrpc.azurewebsites.net", new GrpcChannelOptions
			
			//var handler = new GrpcWebHandler(GrpcWebMode.GrpcWebText, new HttpClientHandler());
			//var channel = GrpcChannel.ForAddress("https://kligrpc.azurewebsites.net", new GrpcChannelOptions
			//{
			//	HttpClient = new HttpClient(handler)
			//});

			//var client = new Calculator.CalculatorClient(channel);
			//Console.WriteLine(client.Calc(new CalculationMessage { Operand = Operand.Multipy, Lhs = 13, Rhs = 20 }));
			//Console.ReadLine();

			//var channel = GrpcChannel.ForAddress("http://10.0.75.1:5001/");
			//var channel = GrpcChannel.ForAddress("https://10.10.103.150:5001/");


			// Return `true` to allow certificates that are untrusted/invalid

			//var httpClientHandler = new HttpClientHandler();
			//httpClientHandler.ServerCertificateCustomValidationCallback = HttpClientHandler.DangerousAcceptAnyServerCertificateValidator;
			//var httpClient = new HttpClient(httpClientHandler);

			var channel = GrpcChannel.ForAddress("http://localhost:3333");
			var calculatorClient = new Calculator.CalculatorClient(channel);
			Console.WriteLine(calculatorClient.Calc(new CalculationMessage { Lhs = 13, Rhs = 42, Operand = Operand.Plus }));
		}
	}
}
