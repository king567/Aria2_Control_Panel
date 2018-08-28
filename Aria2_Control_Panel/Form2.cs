﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using System.Xml;

namespace Aria2_Control_Panel
{
    public partial class Form2 : Form
    {
        string app_path = Application.StartupPath; 
        public Form2()
        {
            InitializeComponent();
            Save_Conf.DialogResult = DialogResult.OK;
            Exit_Bt.DialogResult = DialogResult.Cancel;
        }
        public void Edit_Aria2_Xml(string select_node, string content)
        {
            string xml_path = app_path + @"\Aria2.xml"; //設定xml檔案路徑
            XmlDocument XDoc = new XmlDocument();
            XDoc.Load(xml_path);
            XmlNode Aria2_Node = XDoc.SelectSingleNode("Aria2"+@"/"+select_node);
            if (Aria2_Node == null)
            {
                XmlNode Aria_Element = XDoc.SelectSingleNode("Aria2");
                XmlElement Sub_Element = XDoc.CreateElement(select_node);
                Sub_Element.InnerText = content;
                Aria_Element.InsertAfter(Sub_Element, Aria_Element.FirstChild);
                XDoc.Save("Aria2.xml");
            }
            else
            {
                Aria2_Node.InnerText = content;
                XDoc.Save("Aria2.xml");
            }
        }
        public string Read_Select_Xml(string select_node)
        {
            string xml_path = app_path + @"\Aria2.xml"; //設定xml檔案路徑
            XmlDocument XDoc = new XmlDocument();
            XDoc.Load(xml_path);
            XmlNode Aria2_Node = XDoc.SelectSingleNode("Aria2" + @"/" + select_node);
            return Aria2_Node.InnerText;
        }
        public void Conf_TXT()
        {
            string[] content = { "dir", "log", "save-session", "input-fil", "log-level", "split", "max-connection-per-server" , "ALL_Conf_File" };
            string xml_path = app_path + @"\Aria2.xml"; //設定xml檔案路徑
            XmlDocument XDoc = new XmlDocument();
            XDoc.Load(xml_path);
            XmlNode Aria2_Node = XDoc.SelectSingleNode("Aria2/Run_Time");
            if (Read_Select_Xml("Run_Time") == "2")
            {   
                Aria2_Node.InnerText = 3.ToString();
                Default_Download_Path.Text = app_path;
                Default_Log_Path.Text = app_path + @"\aria2.log";
                Default_Session_Path.Text = app_path + @"\aria2.session";
                Default_Input_file.Text = app_path + @"\aria2.session";
                Log_Level_Box.Text = "info";
                View_All_Conf_File.Text = Conf_file();
            }
            else
            {
                Default_Download_Path.Text = Read_Select_Xml(content[0]);
                Default_Log_Path.Text = Read_Select_Xml(content[1]);
                Default_Session_Path.Text = Read_Select_Xml(content[2]);
                Default_Input_file.Text = Read_Select_Xml(content[3]);
                Log_Level_Box.Text = Read_Select_Xml(content[4]);
                split_numericUpDown.Value = Convert.ToInt32(Read_Select_Xml(content[5]));
                server_number_numericUpDown.Value = Convert.ToInt32(Read_Select_Xml(content[6]));
                View_All_Conf_File.Text = Read_Select_Xml(content[7]);
            }
             XDoc.Save("Aria2.xml");
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            Conf_TXT();
        }
        private void Save_Conf_Click(object sender, EventArgs e)
        {
            StreamWriter streamWriter = new StreamWriter(app_path + @"\aria2.conf");
            streamWriter.WriteLine
                (
                "dir="+Default_Download_Path.Text+ "\r\n" +
                "log=" + Default_Log_Path.Text + "\r\n" +
                "save-session=" + Default_Session_Path.Text + "\r\n" +
                "input-file=" + Default_Input_file.Text + "\r\n" +
                "log-level=" + Log_Level_Box.Text + "\r\n" +
                "split=" + split_numericUpDown.Value + "\r\n" +
                "max-connection-per-server=" + server_number_numericUpDown.Value + "\r\n" +
                View_All_Conf_File.Text + "\r\n" 
                );

                Edit_Aria2_Xml("dir", Default_Download_Path.Text);
                Edit_Aria2_Xml("log",Default_Log_Path.Text);
                Edit_Aria2_Xml("save-session", Default_Session_Path.Text);
                Edit_Aria2_Xml("input-fil", Default_Input_file.Text);
                Edit_Aria2_Xml("log-level", Log_Level_Box.Text);
                Edit_Aria2_Xml("split",  split_numericUpDown.Value.ToString());
                Edit_Aria2_Xml("max-connection-per-server", server_number_numericUpDown.Value.ToString());
                Edit_Aria2_Xml("ALL_Conf_File", View_All_Conf_File.Text);
            streamWriter.Flush();
            streamWriter.Close();
            MessageBox.Show("儲存成功");
            this.Close();
        }
        private void Reset_Click(object sender, EventArgs e)
        {
            Default_Download_Path.Text = app_path;
            Default_Log_Path.Text = app_path + @"\aria2.log";
            Default_Session_Path.Text = app_path + @"\aria2.session";
            Default_Input_file.Text = app_path + @"\aria2.session";
            Log_Level_Box.Text = "info";
            split_numericUpDown.Value = 128;
            server_number_numericUpDown.Value = 128;
            View_All_Conf_File.Text = Conf_file();
        }
        static string Conf_file()
        {
          string conf_file2 = @"save-session-interval=60
force-save=true
remote-time=true
max-concurrent-downloads=5
max-tries=0
retry-wait=10
continue=true
max-overall-download-limit=0
max-overall-upload-limit=50K
max-upload-limit=20
# Http/FTP options
connect-timeout=120
lowest-speed-limit=10K
max-file-not-found=2
min-split-size=1k
check-certificate=false
http-no-cache=true
http-accept-gzip=true
check-integrity=true
download-result=full
# FTP Specific Options
# 當下載的是一個種子(以.torrent結尾)時, 自動開始BT任務, 默認:true
#follow-torrent=true
# BT監聽端口, 當端口被屏蔽時使用, 默認:6881-6999
listen-port=51413
# 單個種子最大連接數, 默認:55
bt-max-peers=55
# 打開DHT功能, PT需要禁用, 默認:true
enable-dht=false
# 打開IPv6 DHT功能, PT需要禁用
#enable-dht6=false
# DHT網絡監聽端口, 默認:6881-6999
#dht-listen-port=6881-6999
# 本地節點查找, PT需要禁用, 默認:false
#bt-enable-lpd=false
# 種子交換, PT需要禁用, 默認:true
enable-peer-exchange=false
# 每個種子限速, 對少種的PT很有用, 默認:50K
#bt-request-peer-speed-limit=50K
# 客戶端偽裝, PT需要
peer-id-prefix=-TR2770-
user-agent=Transmission/2.77
# 當種子的分享率達到這個數時, 自動停止做種, 0為一直做種, 默認:1.0
seed-ratio=1.0
# 強制保存會話, 即使任務已經完成, 默認:false
# 較新的版本開啟後會在任務完成後依然保留.aria2文件
force-save=false
# BT校驗相關, 默認:true
bt-hash-check-seed=true
# 繼續之前的BT任務時, 無需再次校驗, 默認:false
bt-seed-unverified=true
# 保存磁力鏈接元數據為種子文件(.torrent文件), 默認:false
bt-save-metadata=true
# RPC Options
enable-rpc=true
pause=true
rpc-allow-origin-all=true
rpc-listen-all=true
rpc-save-upload-metadata=true

# Advanced Options
daemon=true
disable-ipv6=true
enable-mmap=true
file-allocation=falloc
max-download-result=120
#no-file-allocation-limit=32M
force-sequential=true
";
return conf_file2;
        }
        public void Control_TextBox(int Set_True)
        {
            TextBox[] TBox = new TextBox[] { this.View_All_Conf_File, this.Watch_Now_File_Textbox};
            int Count = TBox.GetUpperBound(0);
            for (int i = 0; i <= Count; i++)
            {
                TBox[i].Visible = false;
            }
            TBox[Set_True].Visible = true;
        }

        private void Edit_File_Button_Click(object sender, EventArgs e)
        {
            Control_TextBox(0);
        }

        private void Watch_Now_File_Button_Click(object sender, EventArgs e)
        {
            Control_TextBox(1);
            string Log_Path= app_path + @"\aria2.conf";
            string readText = File.ReadAllText(Log_Path);
            Watch_Now_File_Textbox.Text = readText;
        }

        private void Exit_Bt_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void Select_Path_button1_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folder = new FolderBrowserDialog();
            folder.ShowDialog();
            this.Default_Download_Path.Text = folder.SelectedPath;
        }
        private void Select_Path_button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog
            {
                Filter = "aria2|*.log"
            };
            file.ShowDialog();
            if(file.FileName.ToString() == "")
            { }
            else
            {
                this.Default_Log_Path.Text = "log=" + file.FileName.ToString();
            } 
        }

        private void Select_Path_button3_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog
            {
                Filter = "aria2|*.session"
            };
            file.ShowDialog();
            if (file.FileName.ToString() == "")
            { }
            else
            {
                this.Default_Session_Path.Text = "save-session=" + file.FileName.ToString();
            }
        }

        private void Select_Path_button4_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog
            {
                Filter = "aria2|*.session"
            };
            file.ShowDialog();
            if (file.FileName.ToString() == "")
            { }
            else
            {
                this.Default_Input_file.Text = "input-file=" + file.FileName.ToString();
            }
        }
    }
}
