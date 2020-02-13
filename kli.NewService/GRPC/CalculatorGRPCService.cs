using Grpc.Core;
using kli.NewService.GRPC;
using System;
using System.Threading.Tasks;
using static kli.NewService.GRPC.CalculationMessage.Types;

namespace kli.grpcTest.GRPC
{
	public class CalculatorGRPCService : Calculator.CalculatorBase
	{
		public override Task<CalculationResult> Calc(CalculationMessage request, ServerCallContext context)
		{
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
