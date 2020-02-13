using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace kli.legacyTXS
{
	static class Program
	{
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			var startInfo = new ProcessStartInfo
			{
				FileName = Path.Combine("Services", "kli.NewService.exe"),
				//Arguments = "3333",
				CreateNoWindow = true,
				UseShellExecute = false,
			};

			Process.Start(startInfo);

			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new MainForm());
		}
	}
}
