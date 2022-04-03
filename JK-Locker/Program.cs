using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace JK_Locker
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            DefaultApp.DefaultSet();

            string filePath = "";
            if ((args != null) && (args.Length > 0))
            {
                for (int i = 0; i < args.Length; i++)
                {
                    // 对于路径中间带空格的会自动分割成多个参数传入
                    filePath += " " + args[i];
                }
                filePath.Trim();
            }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm(filePath));
        }
    }
}
