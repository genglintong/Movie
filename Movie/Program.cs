using LogLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Movie
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            TraceHelper.GetInstance().Info("程序开始...", "Main Function");

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Form config = new Form2();

            config.ShowDialog();

            if(config.DialogResult == DialogResult.OK)
            {
                Application.Run(new Form1());
            }
        }
    }
}
