using Grpc.Core;

namespace kli.legacyTXS.Microservices
{
    public class ServiceClient<TClient>
        where TClient : ClientBase<TClient>
    {
        public TClient Client { get; }
        public Channel Channel { get; }

        public ServiceClient(TClient client, Channel channel)
        {
            this.Client = client;
            this.Channel = channel;
        }
    }
}
