using System;
using System.IO;
using System.Windows.Forms;

namespace Aria2_Control_Panel
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            Save_Conf.DialogResult = DialogResult.OK;
            Exit_Bt.DialogResult = DialogResult.Cancel;
        }
        public void Conf_TXT()
        {
            if (Properties.Settings.Default.Run_Time == 1)
            {
                //初次運行
                Default_Download_Path.Text = Properties.Settings.Default.App_Path;
                Default_Log_Path.Text = Properties.Settings.Default.App_Path + @"\aria2.log";
                Default_Session_Path.Text = Properties.Settings.Default.App_Path + @"\aria2.session";
                Default_Input_file.Text = Properties.Settings.Default.App_Path + @"\aria2.session";
                Log_Level_Box.SelectedIndex = Properties.Settings.Default.Log_Level_Box;
                View_All_Conf_File.Text = Conf_file();
                Properties.Settings.Default.Run_Time = 2;
            }
            else
            {
                Default_Download_Path.Text = Properties.Settings.Default.Download_Path;
                Default_Log_Path.Text = Properties.Settings.Default.Log_Path;
                Default_Session_Path.Text = Properties.Settings.Default.Session_Path;
                Default_Input_file.Text = Properties.Settings.Default.Input_file_Path;
                Log_Level_Box.SelectedIndex = Properties.Settings.Default.Log_Level_Box;
                split_numericUpDown.Value = Properties.Settings.Default.split;
                server_number_numericUpDown.Value = Properties.Settings.Default.max_connection_per_server;
                View_All_Conf_File.Text = Properties.Settings.Default.Conf_File;
            }
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            Unit.SelectedIndex = Properties.Settings.Default.Log_Unit_Format;
            Log_Level_Box.SelectedIndex = Properties.Settings.Default.Log_Level_Box;
            Conf_TXT();
        }
        private void Save_Conf_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Log_Unit_Format = Unit.SelectedIndex;
            Properties.Settings.Default.Log_Level_Box = Log_Level_Box.SelectedIndex;
            Properties.Settings.Default.Download_Path = Default_Download_Path.Text;
            Properties.Settings.Default.Log_Path = Default_Log_Path.Text;
            Properties.Settings.Default.Session_Path = Default_Session_Path.Text;
            Properties.Settings.Default.Input_file_Path = Default_Input_file.Text;
            Properties.Settings.Default.Save();
            StreamWriter streamWriter = new StreamWriter(Properties.Settings.Default.App_Path + @"\aria2.conf");
            streamWriter.WriteLine
                (
                "dir=" + Default_Download_Path.Text + "\r\n" +
                "log=" + Default_Log_Path.Text + "\r\n" +
                "save-session=" + Default_Session_Path.Text + "\r\n" +
                "input-file=" + Default_Input_file.Text + "\r\n" +
                "log-level=" + Log_Level_Box.Text + "\r\n" +
                "split=" + split_numericUpDown.Value + "\r\n" +
                "max-connection-per-server=" + server_number_numericUpDown.Value + "\r\n" +
                View_All_Conf_File.Text + "\r\n"
                );
            streamWriter.Flush();
            streamWriter.Close();
            MessageBox.Show("儲存成功");
            this.Close();
        }
        private void Reset_Click(object sender, EventArgs e)
        {
            Default_Download_Path.Text = Properties.Settings.Default.App_Path;
            Default_Log_Path.Text = Properties.Settings.Default.App_Path + @"\aria2.log";
            Default_Session_Path.Text = Properties.Settings.Default.App_Path + @"\aria2.session";
            Default_Input_file.Text = Properties.Settings.Default.App_Path + @"\aria2.session";
            Log_Level_Box.SelectedIndex = 1;
            Unit.SelectedIndex = 0;
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
            TextBox[] TBox = new TextBox[] { this.View_All_Conf_File, this.Watch_Now_File_Textbox };
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
            string Log_Path = Properties.Settings.Default.App_Path + @"\aria2.conf";
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
            if (file.FileName.ToString() != "")
            {
                this.Default_Log_Path.Text = file.FileName.ToString();
            }
        }

        private void Select_Path_button3_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog
            {
                Filter = "aria2|*.session"
            };
            file.ShowDialog();
            if (file.FileName.ToString() != "")
            {
                this.Default_Session_Path.Text = file.FileName.ToString();
            }
        }

        private void Select_Path_button4_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog
            {
                Filter = "aria2|*.session"
            };
            file.ShowDialog();
            if (file.FileName.ToString() != "")
            {
                this.Default_Input_file.Text = file.FileName.ToString();
            }
        }
    }
}
