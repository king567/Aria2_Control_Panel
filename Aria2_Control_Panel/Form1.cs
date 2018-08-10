﻿using System;
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
        Process P = new Process();
        public void kill_process ()
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
            string conf = @"--conf-path=aria2.conf";

            P.StartInfo.FileName = "aria2c.exe";
            P.StartInfo.Arguments = conf;
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
        private void Start_Aria2_Click(object sender, EventArgs e)
        {
            Start_Proccess();
            Process[] pname = Process.GetProcessesByName("aria2c");
            if (pname.Length == 0)
                Insert_Text("stop");
            else
                Insert_Text("success");
        }

        private void Stop_Aria2_Click(object sender, EventArgs e)
        {
            kill_process();
            Process[] pname = Process.GetProcessesByName("aria2c");
            if (pname.Length == 0)
                Insert_Text("stop");
            else
                Insert_Text("success");
        }

        private void Restart_Aria2_Click(object sender, EventArgs e)
        {
            kill_process();
            Start_Proccess();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void Information_Box_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if ( checkBox1.Checked == true )
            {
                checkBox1.Text = "設置開機啟動：目前為開啟狀態";
            }
            else if ( checkBox1.Checked == false )
            {
                checkBox1.Text = "設置開機啟動：目前為關閉狀態";
            }
        }
    }
}
