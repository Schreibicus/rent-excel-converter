using System;
using System.Windows.Forms;
using Interface.Views;
using Presenters.IPresenters;
using Presenters.Presenters;

namespace Interface
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            IPresenterMain presenterMain = new PresenterMain(new FormMain());
            presenterMain.Run();
        }
    }
}
