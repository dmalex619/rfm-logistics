using System;
using System.Windows.Forms;
using System.Globalization;
using System.Threading;

namespace Logistics
{
	public static class StartProgram
	{
		public static object[] ParamStore = null;
		public static string CurVersion = "Logistics 3.0.181208";

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			if (Thread.CurrentThread.CurrentUICulture.NumberFormat.NumberDecimalSeparator != ".")
			{
				CultureInfo ci = (CultureInfo)Thread.CurrentThread.CurrentCulture.Clone();
				ci.NumberFormat.NumberDecimalSeparator = ".";
				Thread.CurrentThread.CurrentCulture = ci;

				ci = (CultureInfo)Thread.CurrentThread.CurrentUICulture.Clone();
				ci.NumberFormat.NumberDecimalSeparator = ".";
				Thread.CurrentThread.CurrentUICulture = ci;
			}

			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			try
			{
				Application.Run(new frmMain());
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.GetBaseException().Message);
			}
		}
	}
}