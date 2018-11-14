using System;
using System.Windows.Forms;
using System.Threading;
using EdlinSoftware.Safe.Properties;
using EdlinSoftware.Safe.SafeLib;

namespace EdlinSoftware.Safe
{
	static class Program
	{
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
		    bool createdNew;
		    using (new Mutex(true, "EdlinSoftware.Safe", out createdNew))
		    {
		        if (createdNew)
		        {
                    Logger.InitLogger();

		            Application.EnableVisualStyles();
		            Application.SetCompatibleTextRenderingDefault(false);
		            Application.Run(new MainForm());
		        }
		        else
		        {
		            MessageBox.Show(Resources.AnotherInstanceLunched, Resources.ApplicationTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
		        }
		    }
		}
	}
}