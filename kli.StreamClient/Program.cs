using Grpc.Net.Client;
using kli.GRPC;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Threading.Tasks;

namespace kli.StreamClient
{
	class Program
	{
		static async Task Main(string[] args)
		{
			var channel = GrpcChannel.ForAddress("https://localhost:5001");
			var client = new DataTransmitter.DataTransmitterClient(channel);

			await ClientStreamingCallExample(client);

			Console.WriteLine("Press any key to exit...");
			Console.ReadKey();
		}

		private static async Task ClientStreamingCallExample(DataTransmitter.DataTransmitterClient client)
		{
			string[] lines = File.ReadAllLines("input.txt");

			var stopwatch = Stopwatch.StartNew();
			using (var call = client.Transmit())
			{
				foreach (var line in lines)
					await call.RequestStream.WriteAsync(new DataRequest { Data = line });

				await call.RequestStream.CompleteAsync();

				var response = await call;
				Console.WriteLine($"Antwort: {response.Reply}");
			}
			stopwatch.Stop();
			Console.WriteLine($"Done in: " + TimeSpan.FromMilliseconds(stopwatch.ElapsedMilliseconds).ToString("c"));
		}
	}

	public static class Ext
	{
		public static void ForEach<T>(this IEnumerable<T> source, Action<T> action)
		{
			if (source == null) throw new ArgumentNullException("source");
			if (action == null) throw new ArgumentNullException("action");

			foreach (T item in source)
				action(item);
		}
	}
}
