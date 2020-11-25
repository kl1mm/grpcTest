using Google.Protobuf.WellKnownTypes;
using kli.GRPC;
using kli.legacyTXS.Microservices;
using Microsoft.Extensions.Hosting;
using System;
using System.Linq;
using System.Windows.Forms;
using static kli.GRPC.CalculationMessage.Types;
using static kli.GRPC.Calculator;

namespace kli.legacyTXS
{
	public partial class MainForm : Form
	{
		private readonly IHost apphost;
		private readonly ServiceClient<CalculatorClient> calculator;

		public MainForm(IHost apphost, ServiceClient<CalculatorClient> calculator)
		{
			this.InitializeComponent();
			this.apphost = apphost;
			this.calculator = calculator;
		}

		private async void buttonCalc_Click(object sender, EventArgs e)
		{
			var result = await this.calculator.Client.CalcAsync(this.CreateMessage());
			this.labelResult.Text = result.Value.ToString("N2");
		}

		private async void MainForm_Load(object sender, EventArgs e)
		{
			await this.calculator.Channel.ConnectAsync().ConfigureAwait(true);
			labelInfo.Text = $"{this.calculator.Channel.State} - {this.calculator.Channel.ResolvedTarget}";
			buttonCalc.Enabled = true;
			buttonFail.Enabled = true;
		}

		private async void MainForm_FormClosed(object sender, FormClosedEventArgs e)
		{
			await this.apphost?.StopAsync(TimeSpan.FromSeconds(1));
		}

		private CalculationMessage CreateMessage()
		{
			var tag = (string)this.groupBoxCal.Controls.OfType<RadioButton>()
				.FirstOrDefault(r => r.Checked).Tag;

			return new CalculationMessage
			{
				Operand = (Operand)int.Parse(tag),
				Lhs = (double)this.numericLhs.Value,
				Rhs = (double)this.numericRhs.Value
			};
		}

		private async void buttonFail_Click(object sender, EventArgs e)
		{
			await this.calculator.Client.FailAsync(new Empty());
		}
	}
}
