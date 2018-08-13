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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Default_Download_Path = new System.Windows.Forms.TextBox();
            this.Save_Conf = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.Default_Log_Path = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Default_Session_Path = new System.Windows.Forms.TextBox();
            this.View_All_Conf_File = new System.Windows.Forms.TextBox();
            this.Exit_Bt = new System.Windows.Forms.Button();
            this.Reset = new System.Windows.Forms.Button();
            this.Default_Input_file = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.Default_Input_file);
            this.groupBox1.Controls.Add(this.Reset);
            this.groupBox1.Controls.Add(this.Exit_Bt);
            this.groupBox1.Controls.Add(this.View_All_Conf_File);
            this.groupBox1.Controls.Add(this.Default_Session_Path);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.Default_Log_Path);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.Save_Conf);
            this.groupBox1.Controls.Add(this.Default_Download_Path);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 426);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "設定檔";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "預設下載路徑：";
            // 
            // Default_Download_Path
            // 
            this.Default_Download_Path.Location = new System.Drawing.Point(163, 24);
            this.Default_Download_Path.Name = "Default_Download_Path";
            this.Default_Download_Path.Size = new System.Drawing.Size(580, 25);
            this.Default_Download_Path.TabIndex = 1;
            // 
            // Save_Conf
            // 
            this.Save_Conf.Location = new System.Drawing.Point(628, 270);
            this.Save_Conf.Name = "Save_Conf";
            this.Save_Conf.Size = new System.Drawing.Size(115, 67);
            this.Save_Conf.TabIndex = 2;
            this.Save_Conf.Text = "儲存";
            this.Save_Conf.UseVisualStyleBackColor = true;
            this.Save_Conf.Click += new System.EventHandler(this.Save_Conf_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "日誌路徑：";
            // 
            // Default_Log_Path
            // 
            this.Default_Log_Path.Location = new System.Drawing.Point(163, 67);
            this.Default_Log_Path.Name = "Default_Log_Path";
            this.Default_Log_Path.Size = new System.Drawing.Size(580, 25);
            this.Default_Log_Path.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Session存放路徑：";
            // 
            // Default_Session_Path
            // 
            this.Default_Session_Path.Location = new System.Drawing.Point(163, 109);
            this.Default_Session_Path.Name = "Default_Session_Path";
            this.Default_Session_Path.Size = new System.Drawing.Size(580, 25);
            this.Default_Session_Path.TabIndex = 6;
            // 
            // View_All_Conf_File
            // 
            this.View_All_Conf_File.Location = new System.Drawing.Point(19, 191);
            this.View_All_Conf_File.Multiline = true;
            this.View_All_Conf_File.Name = "View_All_Conf_File";
            this.View_All_Conf_File.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.View_All_Conf_File.Size = new System.Drawing.Size(582, 229);
            this.View_All_Conf_File.TabIndex = 7;
            // 
            // Exit_Bt
            // 
            this.Exit_Bt.Location = new System.Drawing.Point(628, 353);
            this.Exit_Bt.Name = "Exit_Bt";
            this.Exit_Bt.Size = new System.Drawing.Size(115, 67);
            this.Exit_Bt.TabIndex = 8;
            this.Exit_Bt.Text = "離開";
            this.Exit_Bt.UseVisualStyleBackColor = true;
            // 
            // Reset
            // 
            this.Reset.Location = new System.Drawing.Point(628, 191);
            this.Reset.Name = "Reset";
            this.Reset.Size = new System.Drawing.Size(115, 67);
            this.Reset.TabIndex = 9;
            this.Reset.Text = "重設";
            this.Reset.UseVisualStyleBackColor = true;
            this.Reset.Click += new System.EventHandler(this.Reset_Click);
            // 
            // Default_Input_file
            // 
            this.Default_Input_file.Location = new System.Drawing.Point(163, 149);
            this.Default_Input_file.Name = "Default_Input_file";
            this.Default_Input_file.Size = new System.Drawing.Size(580, 25);
            this.Default_Input_file.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 15);
            this.label4.TabIndex = 11;
            this.label4.Text = "Input-File";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form2";
            this.Text = "編輯設定檔";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button Save_Conf;
        private System.Windows.Forms.TextBox Default_Download_Path;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Default_Session_Path;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Default_Log_Path;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox View_All_Conf_File;
        private System.Windows.Forms.Button Exit_Bt;
        private System.Windows.Forms.Button Reset;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Default_Input_file;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}