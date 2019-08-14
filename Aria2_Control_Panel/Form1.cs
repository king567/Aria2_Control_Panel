using Microsoft.Win32;
using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Threading;
using System.Windows.Forms;

namespace Aria2_Control_Panel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Check_Boost_Up_Status();
        }
        public static string Select_Combobox(int i)
        {
            string[] Select_Combobox = { "KB", "MB", "GB" };
            return Select_Combobox[i];
        }
        public static long FormatSize(Int64 bytes)
        {
            decimal number = (decimal)bytes;
            switch (Select_Combobox(Properties.Settings.Default.Log_Unit_Format))
            {
                case "KB":
                    number /= 1024;
                    break;
                case "MB":
                    number /= (1024 * 1024);
                    break;
                case "GB":
                    number /= (1024 * 1024 * 1024);
                    break;
                default:
                    number /= 1024;
                    break;
            }
            long log_size = Convert.ToInt64(number);
            return log_size;
        }
        public void Clean_Log_File()
        {
            //清空log檔
            long log_size = Convert.ToInt64(Properties.Settings.Default.Log_Size);
            long length = new FileInfo(Properties.Settings.Default.App_Path + @"\aria2.log").Length;
            if (log_size < FormatSize(length))
            {
                File.WriteAllText(Properties.Settings.Default.App_Path + @"\aria2.log", string.Empty);
                Insert_Text("已清空Log檔");
            }
        }
        public void Check_First_Time_Run()
        {
            //檢測是否首次執行
            if (Properties.Settings.Default.Run_Time == 0)
            {
                MessageBox.Show("歡迎使用Aria2 Control Panel");
                Insert_Text("第一次執行請先進行設定");
                Properties.Settings.Default.Run_Time = 1;
                Properties.Settings.Default.Save();
            }
        }
        public static void GenerateExe(byte[] FileBytes, string DestinationPath)
        {
            //提取aria2
            string fullPath = Properties.Settings.Default.App_Path + @"\" + @"aria2.exe";
            fullPath = DestinationPath;
            try
            {
                byte[] memoryFile = FileBytes;
                FileStream aFile = new FileStream(DestinationPath, FileMode.Create, FileAccess.Write, FileShare.None, 20000, FileOptions.None);
                aFile.Write(memoryFile, 0, memoryFile.Length);
                aFile.Flush();
                aFile.Close();
                Thread.Sleep(100);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                File.Delete(fullPath);
            }

        }
        public void Check_aria2_file_Exists()
        {
            //檢查是否存在aria2，不存在的話就提取
            if (File.Exists(Properties.Settings.Default.Aria2Exe_Path) == false)
            {
                Insert_Text("aria2c.exe不存在");
                Insert_Text("提取檔案中.....");
                GenerateExe(Properties.Resources.aria2c, Properties.Settings.Default.Aria2Exe_Path);
                Insert_Text("提取成功");
            }
        }
        public void Kill_process()
        {
            string ProcessName = "aria2c.exe";
            Process[] pname = Process.GetProcessesByName("aria2c");
            if (pname.Length != 0)
            {
                using (Process P = new Process())
                {
                    try
                    {
                        //使用C#方法停止Proccess
                        Process[] _proceses = null;
                        _proceses = Process.GetProcessesByName("aria2c");
                        foreach (Process proces in _proceses)
                        {
                            proces.Kill();
                        }
                    }
                    catch
                    {
                        //使用CMD方法停止Proccess
                        P.StartInfo = new ProcessStartInfo()
                        {
                            FileName = "taskill",
                            CreateNoWindow = true,
                            WindowStyle = ProcessWindowStyle.Hidden,
                            Arguments = "\"" + ProcessName + "\" /A /V"
                        };
                        P.Start();
                        P.WaitForExit(600);
                    }
                }
            }

        }
        public void Start_Proccess()
        {
            Process[] pname = Process.GetProcessesByName("aria2c");
            if (pname.Length == 0)
            {
                using (Process P = new Process())
                {
                    P.StartInfo.FileName = Properties.Settings.Default.Aria2Exe_Path;
                    P.StartInfo.Arguments = @"--conf-path=" + Properties.Settings.Default.Conf_Path;
                    P.StartInfo.RedirectStandardOutput = true;
                    P.StartInfo.UseShellExecute = false;
                    P.StartInfo.CreateNoWindow = true;
                    P.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                    P.Start();
                }
            }
        }
        public void Check_All_File()
        {
            string[] check_file_path = new string[] { @"aria2.conf", @"aria2.log", @"aria2.session" };
            int count_file = check_file_path.GetUpperBound(0);
            for (int i = 0; i <= count_file; i++)
            {
                string Complete_path = Properties.Settings.Default.App_Path + @"\" + check_file_path[i];
                if (File.Exists(Complete_path))
                {
                    Insert_Text(check_file_path[i] + " 檔案存在");
                }
                else
                {
                    using (var myFile = File.Create(Properties.Settings.Default.App_Path + @"\" + check_file_path[i]))
                    {
                        Insert_Text(check_file_path[i] + " 檔案不存在請創建它");
                        Insert_Text(check_file_path[i] + " 檔案創建成功");
                    }
                }
            }
        }
        public void Check_Log_File()
        {
            string Log_Path = Properties.Settings.Default.App_Path + @"\aria2.log";
            string Copy_Path = Properties.Settings.Default.App_Path + @"\Aria2_Control_Panel.log";
            if (File.Exists(Log_Path))
            {
                File.Copy(Log_Path, Copy_Path, true);
                string readText = File.ReadAllText(Copy_Path);
                Watch_Log_TextBox.Text = readText;
            }
            else
            {
                Watch_Log_TextBox.Text = "檔案不存在請創建它";
            }
            File.Delete(Copy_Path);
        }
        public void Check_Boost_Up_Status()
        {
            RegistryKey rgkRun = Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);
            // 獲得應用進程名稱
            string strShortFileName = @"aria2c";
            string RegT = (string)rgkRun.GetValue(strShortFileName);
            Check_All_File();
            if (RegT == null)
            {
                Boost_Up_label.Text = "設置開機啟動：目前為關閉狀態";
                pictureBox1.Image = Properties.Resources.switch_off;
                Check_Boost_Value = 0;
            }
            else
            {
                Boost_Up_label.Text = "設置開機啟動：目前為開啟狀態";
                pictureBox1.Image = Properties.Resources.switch_on;
                Check_Boost_Value = 1;
            }
        }
        public void Insert_Text(string content)
        {
            int count = Information_Box.Text.Length;
            string get_box_text = Information_Box.Text;
            Information_Box.Text = get_box_text.Insert(count, content + "\r\n");
            //////自動卷軸到最底下
            Information_Box.ScrollBars = ScrollBars.Vertical;
            Information_Box.SelectionStart = Information_Box.Text.Length;
            Information_Box.ScrollToCaret();
        }
        public void Check_Process()
        {
            DateTime GetDateTime = DateTime.Now;
            Process[] pname = Process.GetProcessesByName("aria2c");
            if (pname.Length == 0)
            {
                Insert_Text("----------------------------------------------------------------------------------------------------------------------");
                Insert_Text(GetDateTime.ToString() + @" " + "目前為停止狀態");
                Insert_Text("----------------------------------------------------------------------------------------------------------------------");
            }
            else
            {
                Insert_Text("----------------------------------------------------------------------------------------------------------------------");
                Insert_Text(GetDateTime.ToString() + @" " + "目前為啟動狀態");
                Insert_Text("----------------------------------------------------------------------------------------------------------------------");
            }
        }
        public void Control_TextBox(int Set_True)
        {
            TextBox[] TBox = new TextBox[] { this.Information_Box, this.Watch_Log_TextBox };
            ToolStripMenuItem[] toolStripMenuItems = new ToolStripMenuItem[] { this.Now_Status, this.Watch_Log };
            int Count = TBox.GetUpperBound(0);
            for (int i = 0; i <= Count; i++)
            {
                TBox[i].Visible = false;
                toolStripMenuItems[i].BackColor = Color.FromName("Gray");
            }
            TBox[Set_True].Visible = true;
            toolStripMenuItems[Set_True].BackColor = Color.FromName("WindowFrame");
        }
        private void Start_Aria2_Click(object sender, EventArgs e)
        {
            Check_All_File();
            Check_aria2_file_Exists();
            Start_Proccess();
            Check_Process();
        }

        private void Stop_Aria2_Click(object sender, EventArgs e)
        {
            Kill_process();
            Check_Process();
        }

        private void Restart_Aria2_Click(object sender, EventArgs e)
        {
            Kill_process();
            Check_All_File();
            Check_aria2_file_Exists();
            Start_Proccess();
            Check_Process();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Check_First_Time_Run();
            Check_Process();
            Clean_Log_File();
        }

        private void 編輯設定檔ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 fm2 = new Form2();
            fm2.ShowDialog(this);
            if (fm2.DialogResult == DialogResult.OK)
            {
                //若使用者在Form2按下了OK，則進入這個判斷式
                Insert_Text("修改成功");
            }
            else if (fm2.DialogResult == DialogResult.Cancel)
            {
                Insert_Text("修改失敗");
            }
            else
            {
                Insert_Text("修改失敗");
            }
        }

        private void Now_Status_Click(object sender, EventArgs e)
        {
            Control_TextBox(0);
        }

        private void Watch_Log_Click(object sender, EventArgs e)
        {
            Control_TextBox(1);
            Check_Log_File();
        }
        int Check_Boost_Value = 0;
        bool b = false;
        private void PictureBox1_Click(object sender, EventArgs e)
        {
            Check_Boost_Value = Check_Boost_Value ^ 1; //做 xor 運算 ，按一下 True ，再按一下 False......... 
            b = Convert.ToBoolean(Check_Boost_Value);
            // 獲得應用進程名稱
            string strShortFileName = @"aria2c";
            string aria2_boost_up = Properties.Settings.Default.App_Path + @"\" + @"Boost_Up.vbs";
            string Cmd_Path = Properties.Settings.Default.App_Path + @"\start.cmd";
            string Cmd_comand = "cd" + @" " + Properties.Settings.Default.App_Path + "\r\n" + "start" + @" " + "Boost_Up.vbs";
            ////////////////////////////////////////////////////////////////////
            string Cmd_1 = "CreateObject" + @"(" + @"""";
            string Cmd_2 = @"WScript" + @"." + @"Shell" + @"""" + ")" + "." + "Run" + @" ";
            string Cmd_3 = @"""" + Properties.Settings.Default.Aria2Exe_Path + @" " + @"--conf-path=aria2.conf" + @"""" + @",0";
            string Com_path = Cmd_1 + Cmd_2 + Cmd_3;
            ////////////////////////////////////////////////////////////////////
            if (b)
            {
                pictureBox1.Image = Properties.Resources.switch_on;
                // 打開註冊表基項"HKEY_LOCAL_MACHINE"
                RegistryKey rgkRun = Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);
                StreamWriter streamWriter = new StreamWriter(aria2_boost_up, true);
                StreamWriter Write_Cmd = new StreamWriter(Cmd_Path, true);
                if (File.Exists(aria2_boost_up))
                {
                    streamWriter.Write(Com_path);
                    Write_Cmd.Write(Cmd_comand);
                }
                else
                {
                    File.Create(aria2_boost_up);
                    File.Create(Cmd_Path);
                    //往VBS檔裡面寫入資料
                    streamWriter.Write(Com_path);
                    Write_Cmd.Write(Cmd_comand);
                }
                streamWriter.Flush();
                streamWriter.Close();
                Write_Cmd.Flush();
                Write_Cmd.Close();
                if (rgkRun == null)
                {   // 若不存在，創建註冊表基項"HKEY_LOCAL_MACHINE"
                    rgkRun = Registry.LocalMachine.CreateSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run");
                    // 設置指定的註冊表項的指定名稱/值對。如果指定的項不存在，則創建該項。
                    rgkRun.SetValue(strShortFileName, Cmd_Path);
                    Insert_Text("添加開機啟動成功");
                    Boost_Up_label.Text = "設置開機啟動：目前為開啟狀態";
                }
                else
                {
                    // 設置指定的註冊表項的指定名稱/值對。如果指定的項不存在，則創建該項。
                    rgkRun.SetValue(strShortFileName, Cmd_Path);
                    Insert_Text("添加開機啟動成功");
                    Boost_Up_label.Text = "設置開機啟動：目前為開啟狀態";
                }
            }
            else
            {
                pictureBox1.Image = Properties.Resources.switch_off;
                // 打開註冊表基項"HKEY_LOCAL_MACHINE"
                RegistryKey rgkRun = Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);
                if (File.Exists(aria2_boost_up))
                {
                    File.Delete(aria2_boost_up);
                    File.Delete(Cmd_Path);
                }
                else { }
                if (rgkRun == null)
                { Insert_Text("已關閉開機啟動"); }
                else
                {
                    // 刪除指定的註冊表項的指定名稱/值對。
                    rgkRun.DeleteValue(strShortFileName, false);
                    Insert_Text("已關閉開機啟動");
                    Boost_Up_label.Text = "設置開機啟動：目前為關閉狀態";
                }
            }
        }

        private void Click_Close(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Click_Maxsize_Windows(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
        }

        private void Click_Mini_Size_Windows(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Click_Minn_To_Task_Bar(object sender, EventArgs e)
        {
            this.Task_Bar_Icon.Text = "Aria2 Control Panel 已縮小至工作列";
            this.Task_Bar_Icon.Icon = Properties.Resources.icons8;
            this.WindowState = FormWindowState.Minimized;
            this.ShowInTaskbar = false;
            this.Task_Bar_Icon.Visible = true;
        }

        private void Task_Bar_Icon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Show();
                this.WindowState = FormWindowState.Normal;
                this.ShowInTaskbar = true;
            }
        }
        private void ToolStripMenuItem_Click_Start(object sender, EventArgs e)
        {
            Check_All_File();
            Check_aria2_file_Exists();
            Start_Proccess();
            Check_Process();
        }
        private void ToolStripMenuItem_Click_Stop(object sender, EventArgs e)
        {
            Kill_process();
            Check_Process();
        }

        private void ToolStripMenuItem_Click_Restart(object sender, EventArgs e)
        {
            Kill_process();
            Check_All_File();
            Check_aria2_file_Exists();
            Start_Proccess();
            Check_Process();
        }
        private void ToolStripMenuItem_Click_Close(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}