using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestOrganiser
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
            if (FileHandling.SaveFileExists())
            {
                DoubleWeekView.Double_Week_View dwv = new DoubleWeekView.Double_Week_View();
                AppWideInfo.doubleWeekView = dwv;

                FileHandling.Load();


                Application.Run(dwv);
            }
            else
            {
                DoubleWeekView.Double_Week_View dwv = new DoubleWeekView.Double_Week_View();
                AppWideInfo.doubleWeekView = dwv;
                Application.Run(dwv);
            }
        }
    }
}
