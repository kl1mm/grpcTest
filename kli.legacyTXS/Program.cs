using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace kli.legacyTXS
{
	static class Program
	{
		public const int NEWSERVICE_PORT = 5001;

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			var startInfo = new ProcessStartInfo
			{
				FileName = Path.Combine("Services", "kli.NewService.exe"),
				Arguments = $"local {NEWSERVICE_PORT}",
				CreateNoWindow = true,
				UseShellExecute = false,
			};

			var process = Process.Start(startInfo);

			Application.ApplicationExit += (sender, args) => process.Kill();
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new MainForm());
		}
	}
}
