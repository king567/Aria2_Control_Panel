namespace Aria2_Control_Panel
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.server_number_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.split_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Log_size = new System.Windows.Forms.Label();
            this.Log_Level_Box = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Select_Path_button4 = new System.Windows.Forms.Button();
            this.Default_Download_Path = new System.Windows.Forms.TextBox();
            this.Select_Path_button3 = new System.Windows.Forms.Button();
            this.Select_Path_button1 = new System.Windows.Forms.Button();
            this.Default_Input_file = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Select_Path_button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.Default_Log_Path = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Default_Session_Path = new System.Windows.Forms.TextBox();
            this.Watch_Now_File_Button = new System.Windows.Forms.Button();
            this.Edit_File_Button = new System.Windows.Forms.Button();
            this.Reset = new System.Windows.Forms.Button();
            this.Exit_Bt = new System.Windows.Forms.Button();
            this.View_All_Conf_File = new System.Windows.Forms.TextBox();
            this.Save_Conf = new System.Windows.Forms.Button();
            this.Watch_Now_File_Textbox = new System.Windows.Forms.TextBox();
            this.Unit = new System.Windows.Forms.ComboBox();
            this.Log_size_textbox = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.server_number_numericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.split_numericUpDown)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Controls.Add(this.Watch_Now_File_Button);
            this.groupBox1.Controls.Add(this.Edit_File_Button);
            this.groupBox1.Controls.Add(this.Reset);
            this.groupBox1.Controls.Add(this.Exit_Bt);
            this.groupBox1.Controls.Add(this.View_All_Conf_File);
            this.groupBox1.Controls.Add(this.Save_Conf);
            this.groupBox1.Controls.Add(this.Watch_Now_File_Textbox);
            this.groupBox1.Location = new System.Drawing.Point(2, -9);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(618, 435);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.groupBox3);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Location = new System.Drawing.Point(7, 18);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(604, 176);
            this.panel1.TabIndex = 20;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.server_number_numericUpDown);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.split_numericUpDown);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Location = new System.Drawing.Point(4, 178);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox3.Size = new System.Drawing.Size(579, 65);
            this.groupBox3.TabIndex = 21;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "多線程設定";
            // 
            // server_number_numericUpDown
            // 
            this.server_number_numericUpDown.Location = new System.Drawing.Point(210, 22);
            this.server_number_numericUpDown.Margin = new System.Windows.Forms.Padding(2);
            this.server_number_numericUpDown.Maximum = new decimal(new int[] {
            128,
            0,
            0,
            0});
            this.server_number_numericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.server_number_numericUpDown.Name = "server_number_numericUpDown";
            this.server_number_numericUpDown.Size = new System.Drawing.Size(55, 22);
            this.server_number_numericUpDown.TabIndex = 28;
            this.server_number_numericUpDown.Value = new decimal(new int[] {
            128,
            0,
            0,
            0});
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(133, 30);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 12);
            this.label7.TabIndex = 27;
            this.label7.Text = "伺服器數目：";
            // 
            // split_numericUpDown
            // 
            this.split_numericUpDown.Location = new System.Drawing.Point(62, 22);
            this.split_numericUpDown.Margin = new System.Windows.Forms.Padding(2);
            this.split_numericUpDown.Maximum = new decimal(new int[] {
            128,
            0,
            0,
            0});
            this.split_numericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.split_numericUpDown.Name = "split_numericUpDown";
            this.split_numericUpDown.Size = new System.Drawing.Size(55, 22);
            this.split_numericUpDown.TabIndex = 26;
            this.split_numericUpDown.Value = new decimal(new int[] {
            128,
            0,
            0,
            0});
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 30);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 12);
            this.label6.TabIndex = 25;
            this.label6.Text = "線程數：";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Unit);
            this.groupBox2.Controls.Add(this.Log_size_textbox);
            this.groupBox2.Controls.Add(this.Log_size);
            this.groupBox2.Controls.Add(this.Log_Level_Box);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.Select_Path_button4);
            this.groupBox2.Controls.Add(this.Default_Download_Path);
            this.groupBox2.Controls.Add(this.Select_Path_button3);
            this.groupBox2.Controls.Add(this.Select_Path_button1);
            this.groupBox2.Controls.Add(this.Default_Input_file);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.Select_Path_button2);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.Default_Log_Path);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.Default_Session_Path);
            this.groupBox2.Location = new System.Drawing.Point(2, 2);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(580, 172);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "設定檔";
            // 
            // Log_size
            // 
            this.Log_size.AutoSize = true;
            this.Log_size.Location = new System.Drawing.Point(212, 140);
            this.Log_size.Name = "Log_size";
            this.Log_size.Size = new System.Drawing.Size(60, 12);
            this.Log_size.TabIndex = 21;
            this.Log_size.Text = "Log大小：";
            // 
            // Log_Level_Box
            // 
            this.Log_Level_Box.FormattingEnabled = true;
            this.Log_Level_Box.Items.AddRange(new object[] {
            "debug",
            "info",
            "notice",
            "warn ",
            "error"});
            this.Log_Level_Box.Location = new System.Drawing.Point(109, 137);
            this.Log_Level_Box.Margin = new System.Windows.Forms.Padding(2);
            this.Log_Level_Box.Name = "Log_Level_Box";
            this.Log_Level_Box.Size = new System.Drawing.Size(56, 20);
            this.Log_Level_Box.TabIndex = 20;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 141);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 12);
            this.label5.TabIndex = 19;
            this.label5.Text = "Log等級：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 17);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "預設下載路徑：";
            // 
            // Select_Path_button4
            // 
            this.Select_Path_button4.Location = new System.Drawing.Point(542, 100);
            this.Select_Path_button4.Margin = new System.Windows.Forms.Padding(2);
            this.Select_Path_button4.Name = "Select_Path_button4";
            this.Select_Path_button4.Size = new System.Drawing.Size(37, 18);
            this.Select_Path_button4.TabIndex = 18;
            this.Select_Path_button4.Text = "...";
            this.Select_Path_button4.UseVisualStyleBackColor = true;
            this.Select_Path_button4.Click += new System.EventHandler(this.Select_Path_button4_Click);
            // 
            // Default_Download_Path
            // 
            this.Default_Download_Path.Location = new System.Drawing.Point(109, 9);
            this.Default_Download_Path.Margin = new System.Windows.Forms.Padding(2);
            this.Default_Download_Path.Name = "Default_Download_Path";
            this.Default_Download_Path.Size = new System.Drawing.Size(429, 22);
            this.Default_Download_Path.TabIndex = 1;
            // 
            // Select_Path_button3
            // 
            this.Select_Path_button3.Location = new System.Drawing.Point(542, 68);
            this.Select_Path_button3.Margin = new System.Windows.Forms.Padding(2);
            this.Select_Path_button3.Name = "Select_Path_button3";
            this.Select_Path_button3.Size = new System.Drawing.Size(37, 18);
            this.Select_Path_button3.TabIndex = 17;
            this.Select_Path_button3.Text = "...";
            this.Select_Path_button3.UseVisualStyleBackColor = true;
            this.Select_Path_button3.Click += new System.EventHandler(this.Select_Path_button3_Click);
            // 
            // Select_Path_button1
            // 
            this.Select_Path_button1.Location = new System.Drawing.Point(542, 10);
            this.Select_Path_button1.Margin = new System.Windows.Forms.Padding(2);
            this.Select_Path_button1.Name = "Select_Path_button1";
            this.Select_Path_button1.Size = new System.Drawing.Size(37, 18);
            this.Select_Path_button1.TabIndex = 15;
            this.Select_Path_button1.Text = "...";
            this.Select_Path_button1.UseVisualStyleBackColor = true;
            this.Select_Path_button1.Click += new System.EventHandler(this.Select_Path_button1_Click);
            // 
            // Default_Input_file
            // 
            this.Default_Input_file.Location = new System.Drawing.Point(109, 101);
            this.Default_Input_file.Margin = new System.Windows.Forms.Padding(2);
            this.Default_Input_file.Name = "Default_Input_file";
            this.Default_Input_file.Size = new System.Drawing.Size(429, 22);
            this.Default_Input_file.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 109);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 12);
            this.label4.TabIndex = 11;
            this.label4.Text = "Input-File：";
            // 
            // Select_Path_button2
            // 
            this.Select_Path_button2.Location = new System.Drawing.Point(542, 40);
            this.Select_Path_button2.Margin = new System.Windows.Forms.Padding(2);
            this.Select_Path_button2.Name = "Select_Path_button2";
            this.Select_Path_button2.Size = new System.Drawing.Size(37, 18);
            this.Select_Path_button2.TabIndex = 16;
            this.Select_Path_button2.Text = "...";
            this.Select_Path_button2.UseVisualStyleBackColor = true;
            this.Select_Path_button2.Click += new System.EventHandler(this.Select_Path_button2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 49);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "日誌路徑：";
            // 
            // Default_Log_Path
            // 
            this.Default_Log_Path.Location = new System.Drawing.Point(109, 41);
            this.Default_Log_Path.Margin = new System.Windows.Forms.Padding(2);
            this.Default_Log_Path.Name = "Default_Log_Path";
            this.Default_Log_Path.Size = new System.Drawing.Size(429, 22);
            this.Default_Log_Path.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 76);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 12);
            this.label3.TabIndex = 5;
            this.label3.Text = "Session存放路徑：";
            // 
            // Default_Session_Path
            // 
            this.Default_Session_Path.Location = new System.Drawing.Point(109, 68);
            this.Default_Session_Path.Margin = new System.Windows.Forms.Padding(2);
            this.Default_Session_Path.Name = "Default_Session_Path";
            this.Default_Session_Path.Size = new System.Drawing.Size(429, 22);
            this.Default_Session_Path.TabIndex = 6;
            // 
            // Watch_Now_File_Button
            // 
            this.Watch_Now_File_Button.Location = new System.Drawing.Point(122, 199);
            this.Watch_Now_File_Button.Margin = new System.Windows.Forms.Padding(2);
            this.Watch_Now_File_Button.Name = "Watch_Now_File_Button";
            this.Watch_Now_File_Button.Size = new System.Drawing.Size(107, 25);
            this.Watch_Now_File_Button.TabIndex = 13;
            this.Watch_Now_File_Button.Text = "查看目前設定檔";
            this.Watch_Now_File_Button.UseVisualStyleBackColor = true;
            this.Watch_Now_File_Button.Click += new System.EventHandler(this.Watch_Now_File_Button_Click);
            // 
            // Edit_File_Button
            // 
            this.Edit_File_Button.Location = new System.Drawing.Point(7, 199);
            this.Edit_File_Button.Margin = new System.Windows.Forms.Padding(2);
            this.Edit_File_Button.Name = "Edit_File_Button";
            this.Edit_File_Button.Size = new System.Drawing.Size(102, 25);
            this.Edit_File_Button.TabIndex = 12;
            this.Edit_File_Button.Text = "編輯全部設定檔";
            this.Edit_File_Button.UseVisualStyleBackColor = true;
            this.Edit_File_Button.Click += new System.EventHandler(this.Edit_File_Button_Click);
            // 
            // Reset
            // 
            this.Reset.Location = new System.Drawing.Point(524, 218);
            this.Reset.Margin = new System.Windows.Forms.Padding(2);
            this.Reset.Name = "Reset";
            this.Reset.Size = new System.Drawing.Size(86, 54);
            this.Reset.TabIndex = 9;
            this.Reset.Text = "重設";
            this.Reset.UseVisualStyleBackColor = true;
            this.Reset.Click += new System.EventHandler(this.Reset_Click);
            // 
            // Exit_Bt
            // 
            this.Exit_Bt.Location = new System.Drawing.Point(524, 358);
            this.Exit_Bt.Margin = new System.Windows.Forms.Padding(2);
            this.Exit_Bt.Name = "Exit_Bt";
            this.Exit_Bt.Size = new System.Drawing.Size(86, 54);
            this.Exit_Bt.TabIndex = 8;
            this.Exit_Bt.Text = "離開";
            this.Exit_Bt.UseVisualStyleBackColor = true;
            this.Exit_Bt.Click += new System.EventHandler(this.Exit_Bt_Click);
            // 
            // View_All_Conf_File
            // 
            this.View_All_Conf_File.Location = new System.Drawing.Point(7, 229);
            this.View_All_Conf_File.Margin = new System.Windows.Forms.Padding(2);
            this.View_All_Conf_File.Multiline = true;
            this.View_All_Conf_File.Name = "View_All_Conf_File";
            this.View_All_Conf_File.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.View_All_Conf_File.Size = new System.Drawing.Size(480, 184);
            this.View_All_Conf_File.TabIndex = 7;
            // 
            // Save_Conf
            // 
            this.Save_Conf.Location = new System.Drawing.Point(524, 287);
            this.Save_Conf.Margin = new System.Windows.Forms.Padding(2);
            this.Save_Conf.Name = "Save_Conf";
            this.Save_Conf.Size = new System.Drawing.Size(86, 54);
            this.Save_Conf.TabIndex = 2;
            this.Save_Conf.Text = "儲存";
            this.Save_Conf.UseVisualStyleBackColor = true;
            this.Save_Conf.Click += new System.EventHandler(this.Save_Conf_Click);
            // 
            // Watch_Now_File_Textbox
            // 
            this.Watch_Now_File_Textbox.BackColor = System.Drawing.Color.Black;
            this.Watch_Now_File_Textbox.ForeColor = System.Drawing.Color.Lime;
            this.Watch_Now_File_Textbox.Location = new System.Drawing.Point(7, 229);
            this.Watch_Now_File_Textbox.Margin = new System.Windows.Forms.Padding(2);
            this.Watch_Now_File_Textbox.Multiline = true;
            this.Watch_Now_File_Textbox.Name = "Watch_Now_File_Textbox";
            this.Watch_Now_File_Textbox.ReadOnly = true;
            this.Watch_Now_File_Textbox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Watch_Now_File_Textbox.Size = new System.Drawing.Size(480, 184);
            this.Watch_Now_File_Textbox.TabIndex = 14;
            // 
            // Unit
            // 
            this.Unit.FormattingEnabled = true;
            this.Unit.Items.AddRange(new object[] {
            "KB",
            "MB",
            "GB"});
            this.Unit.Location = new System.Drawing.Point(370, 136);
            this.Unit.Margin = new System.Windows.Forms.Padding(2);
            this.Unit.Name = "Unit";
            this.Unit.Size = new System.Drawing.Size(50, 20);
            this.Unit.TabIndex = 30;
            // 
            // Log_size_textbox
            // 
            this.Log_size_textbox.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Aria2_Control_Panel.Properties.Settings.Default, "Log_Size", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.Log_size_textbox.Location = new System.Drawing.Point(272, 135);
            this.Log_size_textbox.Name = "Log_size_textbox";
            this.Log_size_textbox.Size = new System.Drawing.Size(90, 22);
            this.Log_size_textbox.TabIndex = 29;
            this.Log_size_textbox.Text = global::Aria2_Control_Panel.Properties.Settings.Default.Log_Size;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 431);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form2";
            this.Text = "編輯設定檔";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.server_number_numericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.split_numericUpDown)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button Save_Conf;
        private System.Windows.Forms.TextBox View_All_Conf_File;
        private System.Windows.Forms.Button Exit_Bt;
        private System.Windows.Forms.Button Reset;
        private System.Windows.Forms.Button Watch_Now_File_Button;
        private System.Windows.Forms.Button Edit_File_Button;
        private System.Windows.Forms.TextBox Watch_Now_File_Textbox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.NumericUpDown server_number_numericUpDown;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown split_numericUpDown;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox Log_Level_Box;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Select_Path_button4;
        private System.Windows.Forms.TextBox Default_Download_Path;
        private System.Windows.Forms.Button Select_Path_button3;
        private System.Windows.Forms.Button Select_Path_button1;
        private System.Windows.Forms.TextBox Default_Input_file;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Select_Path_button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Default_Log_Path;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Default_Session_Path;
        private System.Windows.Forms.TextBox Log_size_textbox;
        private System.Windows.Forms.Label Log_size;
        private System.Windows.Forms.ComboBox Unit;
    }
}