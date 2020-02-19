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
			this.logger.LogInformation($".NETCore - Service: Ich berechne... für {context.Peer}");

			var value = request.Operand switch
			{
				Operand.Plus => request.Lhs + request.Rhs,
				Operand.Minus => request.Lhs - request.Rhs,
				Operand.Multipy => request.Lhs * request.Rhs,
				Operand.Divide => request.Lhs / request.Rhs,
				_ => throw new NotSupportedException($"{nameof(request.Operand)} '{request.Operand}' is unknown"),
			};

			return Task.FromResult(new CalculationResult { Value = value });
		}
	}
}
