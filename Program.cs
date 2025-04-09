using System;
using System.Windows.Forms;
namespace Private_Chat
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static async Task Main()
        {
			ApplicationConfiguration.Initialize();
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);

			// Crea e mostra la splash screen
			var formCaricamento = new Page_Loading();
			formCaricamento.Show();

			var form1 = new Form1();

			formCaricamento.Close();
			Application.Run(form1);
		}
	
	}
}