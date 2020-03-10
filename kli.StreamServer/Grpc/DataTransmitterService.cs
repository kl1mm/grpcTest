using Grpc.Core;
using kli.GRPC;
using Microsoft.Extensions.Logging;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace kli.StreamServer.Grpc
{
	public class DataTransmitterService : DataTransmitter.DataTransmitterBase
	{
		private ILogger<DataTransmitterService> logger;
		public DataTransmitterService(ILogger<DataTransmitterService> logger)
		{
			this.logger = logger;
		}

		public async override Task<DataReply> Transmit(IAsyncStreamReader<DataRequest> requestStream, ServerCallContext context)
		{
			StringBuilder sb = new StringBuilder();
			var count = 0;
			await foreach (var message in requestStream.ReadAllAsync())
            {
				sb.AppendLine(message.Data);
				count++;
				if (count % 10_000 == 0)
					this.logger.LogInformation("Progress");
            }

			//await File.WriteAllTextAsync("aaa.txt", sb.ToString());

            return new DataReply { Reply = $"Transmitted {count:N} lines" };			
		}
	}
}
