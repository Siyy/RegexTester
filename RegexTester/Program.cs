using System;
using System.Collections.Generic;
//using System.Linq;
using System.Windows.Forms;

namespace Jiuyong
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            if (DateTime.Now.Year < 2014)
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new RegexTesterForm());
			}
			else
			{
				MessageBox.Show("I'm so sorry. your time is Out .\r\nPlease download new version form\r\n UnMean.Net .");
			}
        }
    }
}
