using SistemaBarbearia.Modelo;
using System;
using System.Windows.Forms;

namespace SistemaBarbearia
{
	static class Program
	{
		public static Administrador Adm;

		/// <summary>
		///  The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			Application.SetHighDpiMode(HighDpiMode.SystemAware);
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new frmLogin());
		}
	}
}
