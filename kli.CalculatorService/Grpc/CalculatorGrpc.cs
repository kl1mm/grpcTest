using Google.Protobuf.WellKnownTypes;
using Grpc.Core;
using kli.GRPC;
using Microsoft.Extensions.Logging;
using System;
using System.Threading.Tasks;
using static kli.GRPC.CalculationMessage.Types;

namespace kli.CalculatorService.Grpc
{
	public class CalculatorGrpc : Calculator.CalculatorBase
	{
		private readonly ILogger<CalculatorGrpc> logger;

		public CalculatorGrpc(ILogger<CalculatorGrpc> logger)
		{
			this.logger = logger;
		}

		public override Task<CalculationResult> Calc(CalculationMessage request, ServerCallContext context)
		{
			this.logger.LogInformation($"Berechne: {request.Lhs} {request.Operand.ToString().ToUpperInvariant()} {request.Rhs}");
			
			var value = request.Operand switch
			{
				Operand.Plus => request.Lhs + request.Rhs,
				Operand.Minus => request.Lhs - request.Rhs,
				Operand.Multipy => request.Lhs * request.Rhs,
				Operand.Divide => request.Lhs / request.Rhs,
				_ => throw new NotSupportedException($"{nameof(request.Operand)} '{request.Operand}' is unknown"),
			};

			this.logger.LogInformation($"Ergebnis: {value}");

			return Task.FromResult(new CalculationResult { Value = value });
		}

		public override Task<Empty> Fail(Empty request, ServerCallContext context) 
			=> throw new RpcException(new Status(StatusCode.Internal, "Da ist was schiefgelaufen"));
	}
}
