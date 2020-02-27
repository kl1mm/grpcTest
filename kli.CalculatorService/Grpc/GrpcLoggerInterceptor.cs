using Grpc.Core;
using Grpc.Core.Interceptors;
using Microsoft.Extensions.Logging;
using System;
using System.Diagnostics;
using System.Threading.Tasks;

namespace kli.CalculatorService.Grpc
{
	public class GrpcLoggerInterceptor : Interceptor
	{
		private const int secondsBeforeLogWarning = 5;
		private readonly ILogger<GrpcLoggerInterceptor> logger;

		public GrpcLoggerInterceptor(ILogger<GrpcLoggerInterceptor> logger)
		{
			this.logger = logger;
		}

		public override Task<TResponse> UnaryServerHandler<TRequest, TResponse>(
			TRequest request, ServerCallContext context, UnaryServerMethod<TRequest, TResponse> continuation)
		{
			return this.Intercept<TRequest, TResponse, Task<TResponse>>(MethodType.Unary, context, 
				() => continuation(request, context));
		}

		public override Task<TResponse> ClientStreamingServerHandler<TRequest, TResponse>(
			IAsyncStreamReader<TRequest> requestStream, ServerCallContext context, ClientStreamingServerMethod<TRequest, TResponse> continuation)
		{
			return this.Intercept<TRequest, TResponse, Task<TResponse>>(MethodType.ClientStreaming, context, 
				() =>  base.ClientStreamingServerHandler(requestStream, context, continuation));
		}

		public override Task ServerStreamingServerHandler<TRequest, TResponse>(
			TRequest request, IServerStreamWriter<TResponse> responseStream, ServerCallContext context, ServerStreamingServerMethod<TRequest, TResponse> continuation)
		{
			return this.Intercept<TRequest, TResponse, Task>(MethodType.ServerStreaming, context,
				() => base.ServerStreamingServerHandler(request, responseStream, context, continuation));
		}

		public override Task DuplexStreamingServerHandler<TRequest, TResponse>(
			IAsyncStreamReader<TRequest> requestStream, IServerStreamWriter<TResponse> responseStream,
			ServerCallContext context, DuplexStreamingServerMethod<TRequest, TResponse> continuation)
		{
			return this.Intercept<TRequest, TResponse, Task>(MethodType.DuplexStreaming, context,
				() => base.DuplexStreamingServerHandler(requestStream, responseStream, context, continuation));
		}

		private TResult Intercept<TRequest, TResponse, TResult>(MethodType methodType, ServerCallContext context, Func<TResult> continuation)
			where TRequest : class
			where TResponse : class
		{
			this.logger.LogInformation($"Request: {typeof(TRequest)} for client: {context.Peer} with methodtype: {methodType} ");
			
			var watch = Stopwatch.StartNew();
			TResult result = continuation();
			watch.Stop();

			this.logger.LogInformation($"Response: {typeof(TResponse)} ({TimeSpan.FromMilliseconds(watch.ElapsedMilliseconds):g})");
			if (watch.Elapsed > TimeSpan.FromSeconds(secondsBeforeLogWarning))
				this.logger.LogWarning($"Long running request");
			
			return result;
		}
	}
}
