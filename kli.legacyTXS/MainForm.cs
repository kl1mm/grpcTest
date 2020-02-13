using Grpc.Core;
using Grpc.Core.Logging;
using kli.NewService.GRPC;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static kli.NewService.GRPC.CalculationMessage.Types;

namespace kli.legacyTXS
{
	public partial class MainForm : Form
	{
		private readonly Channel onPremChannel;
		private readonly Channel cloudChannel;

		public MainForm()
		{
			InitializeComponent();
			this.onPremChannel = new Channel("localhost:5001", ChannelCredentials.Insecure);
			//this.cloudChannel = new Channel("localhost:5001", ChannelCredentials.Insecure);
		}

		private async void buttonCalcOnPrem_Click(object sender, EventArgs e)
		{
			var calculatorClient = new Calculator.CalculatorClient(this.onPremChannel);
			var result = await calculatorClient.CalcAsync(this.CreateMessage());
			labelResult.Text = result.Value.ToString("N2");
		}

		private async void buttonCalcCloud_Click(object sender, EventArgs e)
		{
			var calculatorClient = new Calculator.CalculatorClient(this.cloudChannel);
			var result = await calculatorClient.CalcAsync(this.CreateMessage());
			labelResult.Text = result.Value.ToString("N2");
		}

		private CalculationMessage CreateMessage()
		{
			var tag = (string)this.groupBoxCal.Controls.OfType<RadioButton>()
				.FirstOrDefault(r => r.Checked).Tag;

			return new CalculationMessage
			{
				Operand = (Operand)int.Parse(tag),
				Lhs = (double)numericLhs.Value,
				Rhs = (double)numericRhs.Value
			};
		}
	}
}
