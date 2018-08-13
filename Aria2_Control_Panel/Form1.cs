using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aria2_Control_Panel
{
    public partial class Form1 : Form
    {
        string app_path = Application.StartupPath;
        string Conf_path = @"--conf-path=aria2.conf";
        Process P = new Process();
        public void kill_process()
        {
            string ProcessName = "aria2c.exe";
            try
            {
                P.StartInfo = new ProcessStartInfo()
                {
                    FileName = "taskkill",
                    CreateNoWindow = true,
                    WindowStyle = ProcessWindowStyle.Hidden,
                    Arguments = "/F /IM \"" + ProcessName + "\""
                };
                P.Start();
                P.WaitForExit(600);
            }
            catch
            {
                P.StartInfo = new ProcessStartInfo()
                {
                    FileName = "tskill",
                    CreateNoWindow = true,
                    WindowStyle = ProcessWindowStyle.Hidden,
                    Arguments = "\"" + ProcessName + "\" /A /V"
                };
                P.Start();
                P.WaitForExit(600);
            }
        }
        public void Start_Proccess()
        {
            P.StartInfo.FileName = app_path + @"\aria2c.exe";
            P.StartInfo.Arguments = Conf_path;
            P.StartInfo.RedirectStandardOutput = true;
            P.StartInfo.UseShellExecute = false;
            P.StartInfo.CreateNoWindow = true;
            P.StartInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
            P.Start();
        }
        public Form1()
        {
            InitializeComponent();
        }
        public void Insert_Text(string content)
        {
            int count = Information_Box.Text.Length;
            string get_box_text = Information_Box.Text;
            Information_Box.Text = get_box_text.Insert(count, content + "\r\n");
        }
        public void Check_Process()
        {
            Process[] pname = Process.GetProcessesByName("aria2c");
            if (pname.Length == 0)
                Insert_Text("stop");
            else
                Insert_Text("success");
        }
        private void Start_Aria2_Click(object sender, EventArgs e)
        {
            Start_Proccess();
            Check_Process();
        }

        private void Stop_Aria2_Click(object sender, EventArgs e)
        {
            kill_process();
            Check_Process();
        }

        private void Restart_Aria2_Click(object sender, EventArgs e)
        {
            kill_process();
            Start_Proccess();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Check_Process();

        }

        private void Information_Box_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                RegistryKey RKey = Registry.LocalMachine.CreateSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Run");
                RKey.SetValue("aria2", app_path + @"\aria2c.exe" + @"" + Conf_path);
                checkBox1.Text = "設置開機啟動：目前為開啟狀態";
            }
            else if (checkBox1.Checked == false)
            {
                checkBox1.Text = "設置開機啟動：目前為關閉狀態";
            }
        }

        private void 編輯設定檔ToolStripMenuItem_Click(object sender, EventArgs e)
        { 
            Form2 fm2 = new Form2();
            fm2.ShowDialog(this);
            if (fm2.DialogResult == System.Windows.Forms.DialogResult.OK)
            {
                //若使用者在Form2按下了OK，則進入這個判斷式
                Insert_Text("修改成功");
            }
            else
            {
                Insert_Text("修改失敗");
            }

        }
    }
}