using System;
using System.Windows.Forms;

namespace Aria2_Control_Panel
{
    static class Program
    {
        /// <summary>
        /// 應用程式的主要進入點。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Properties.Settings.Default.App_Path = Application.StartupPath;
            Properties.Settings.Default.Conf_Path = Application.StartupPath + @"/aria2.conf";
            Properties.Settings.Default.Aria2Exe_Path = Application.StartupPath + @"\aria2c.exe";
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
