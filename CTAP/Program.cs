using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Threading;
using System.Globalization;

namespace Monitor
{
    static class Program
    {
        /// <summary>
        /// 應用程式的主要進入點。
        /// </summary>
        [STAThread]
        static void Main()
        {
            if (System.Diagnostics.Process.GetProcessesByName(System.Diagnostics.Process.GetCurrentProcess().ProcessName).Length > 1)
            {
                MessageBox.Show("CTAP Already Exist!");
                return;
            }

            if (MessageBox.Show("Use English UI?", "Language Select", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Thread.CurrentThread.CurrentUICulture = new CultureInfo("en");
            }
            else
            {
                Thread.CurrentThread.CurrentUICulture = new CultureInfo("zh-TW");
            }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(CTAP.getSingleton());
        }
    }
}