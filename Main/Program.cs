using Main.Entities;
using Main.Forms;
using System;
using System.Windows.Forms;

namespace Main {
	static class Program {
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() {
			// Application.SetHighDoiMode(HighDpiMode.SystemAware);
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);

			// var user = new User();
			Application.Run();
		}
	}
}
