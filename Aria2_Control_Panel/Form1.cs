using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aria2_Control_Panel
{
    public partial class Form1 : Form
    {
        string app_path = Application.StartupPath;
        string Conf_path = @"--conf-path=aria2.conf";
        DateTime GetDateTime = DateTime.Now;
        Process P = new Process();
        public static void GenerateExe(byte[] FileBytes, string DestinationPath)
        {
            string fullPath = Application.StartupPath + @"\" + @"aria2.exe";
            fullPath = DestinationPath;
            try
            {
                //1) Fetch Exe file content from Resources
                byte[] memoryFile = FileBytes;

                //2) Create file to be deleted complete execution
                FileStream aFile = new FileStream(DestinationPath, FileMode.Create, FileAccess.Write, FileShare.None, 20000, FileOptions.None);

                //3) Write Exe file content
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
            if(File.Exists(app_path + @"\aria2c.exe"))
            {}
            else
            {
                Insert_Text("aria2c.exe不存在");
                Insert_Text("提取檔案中.....");
                GenerateExe(Properties.Resources.aria2c, app_path + @"\aria2c.exe");
                Insert_Text("提取成功");
            }
        }
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
                    FileName = "taskill",
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
        public void Check_File_Exist()
        {
            string[] check_file_path = new string[] { @"aria2.conf", @"aria2.log" , @"aria2.session" };
            int count_file = check_file_path.GetUpperBound(0);
            for (int i = 0; i <= count_file; i++)
            {
               string Complete_path = app_path+ @"\"+ check_file_path[i];
                if (File.Exists(Complete_path))
                {
                    Insert_Text(check_file_path[i] + " 檔案存在");
                }
                else
                {
                    Insert_Text(check_file_path[i] + " 檔案不存在請創建它");
                    File.Create(app_path + @"\" + check_file_path[i]);
                    Insert_Text(check_file_path[i] + " 檔案創建成功");
                }
            }
        }
        public Form1()
        {
            InitializeComponent();

            RegistryKey rgkRun = Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);
            // 獲得應用進程名稱
            string strShortFileName = @"aria2c";
            string RegT = (string)rgkRun.GetValue(strShortFileName);
            Check_File_Exist();
            if (RegT == null)
            {
                checkBox1.Text = "設置開機啟動：目前為關閉狀態";
                checkBox1.Checked = false;
            }
            else
            {
                checkBox1.Text = "設置開機啟動：目前為開啟狀態";
                checkBox1.Checked = true;
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
            Process[] pname = Process.GetProcessesByName("aria2c");
            if (pname.Length == 0)
            { 
                Insert_Text("----------------------------------------------------------------------------------------------------------------------");
                Insert_Text(GetDateTime.ToString()+@" "+"目前為停止狀態");
                Insert_Text("----------------------------------------------------------------------------------------------------------------------");
            }
            else
            {
                Insert_Text("----------------------------------------------------------------------------------------------------------------------");
                Insert_Text(GetDateTime.ToString()+@" "+ "目前為啟動狀態");
                Insert_Text("----------------------------------------------------------------------------------------------------------------------");
            }
        }
        private void Start_Aria2_Click(object sender, EventArgs e)
        {
            Check_File_Exist();
            Check_aria2_file_Exists();
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
            Check_File_Exist();
            Check_aria2_file_Exists();
            Start_Proccess();
            Check_Process();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Check_Process();
            string[] check_file_path = new string[] { @"aria2.conf", @"aria2.log", @"aria2.session" };
            File.Create(app_path + @"\" + check_file_path[0]).Close();
            File.Create(app_path + @"\" + check_file_path[1]).Close();
            File.Create(app_path + @"\" + check_file_path[2]).Close();

        }

        private void checkBox1_Click(object sender, EventArgs e)
        {
            // 獲得應用進程路徑
            string strAssName = Application.StartupPath + @"\aria2c.exe";
            // 獲得應用進程名稱
            string strShortFileName = @"aria2c";
            string aria2_boost_up = app_path + @"\" + @"Boost_Up.vbs";
            string Cmd_Path = app_path + @"\start.cmd";
            string Cmd_comand = "cd"+@" "+ app_path+ "\r\n"+ "start"+@" "+"Boost_Up.vbs";
            ////////////////////////////////////////////////////////////////////
            string king1 = "CreateObject" + @"(" + @"""";
            string king2 = @"WScript" + @"." + @"Shell" + @"""" + ")" + "." + "Run" + @" ";
            string king3 = @"""" + app_path + @"\aria2c.exe" + @" " + @"--conf-path=aria2.conf" + @"""" + @",0";
            string Com_path = king1 + king2 + king3;
             ////////////////////////////////////////////////////////////////////
            if (checkBox1.Checked == true)
            {
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
                    checkBox1.Text = "設置開機啟動：目前為開啟狀態";
                }
                else
                { 
                    // 設置指定的註冊表項的指定名稱/值對。如果指定的項不存在，則創建該項。
                    rgkRun.SetValue(strShortFileName, Cmd_Path);
                    Insert_Text("添加開機啟動成功");
                    checkBox1.Text = "設置開機啟動：目前為開啟狀態";
                }
            }
            else if (checkBox1.Checked == false)
            {
                // 打開註冊表基項"HKEY_LOCAL_MACHINE"
                RegistryKey rgkRun = Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);
                if(File.Exists(aria2_boost_up))
                {
                    File.Delete(aria2_boost_up);
                    File.Delete(Cmd_Path);
                }
                else{ }
                if (rgkRun == null)
                { Insert_Text("已關閉開機啟動"); }
                else
                { 
                    // 刪除指定的註冊表項的指定名稱/值對。
                    rgkRun.DeleteValue(strShortFileName, false);
                    Insert_Text("已關閉開機啟動");
                    checkBox1.Text = "設置開機啟動：目前為關閉狀態";
                }
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

        private void 編輯設定檔ToolStripMenuItem_Click(object sender, EventArgs e)
        { 
            Form2 fm2 = new Form2();
            fm2.ShowDialog(this);
            if (fm2.DialogResult == DialogResult.OK)
            {
                //若使用者在Form2按下了OK，則進入這個判斷式
                Insert_Text("修改成功");
            }
            else if(fm2.DialogResult == DialogResult.Cancel)
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
            string Log_Path = app_path + @"\aria2.log";
            string Copy_Path = app_path + @"\Aria2_Control_Panel.log";
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
    }
}