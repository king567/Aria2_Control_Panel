namespace Aria2_Control_Panel
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Start_Aria2 = new System.Windows.Forms.Button();
            this.Stop_Aria2 = new System.Windows.Forms.Button();
            this.Restart_Aria2 = new System.Windows.Forms.Button();
            this.Information_Box = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Boost_Up_label = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.Now_Status = new System.Windows.Forms.ToolStripMenuItem();
            this.Watch_Log = new System.Windows.Forms.ToolStripMenuItem();
            this.Watch_Log_TextBox = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.編輯設定檔ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dragControl1 = new Aria2_Control_Panel.DragControl();
            this.dragControl2 = new Aria2_Control_Panel.DragControl();
            this.dragControl3 = new Aria2_Control_Panel.DragControl();
            this.dragControl4 = new Aria2_Control_Panel.DragControl();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Start_Aria2
            // 
            this.Start_Aria2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(227)))), ((int)(((byte)(218)))));
            this.Start_Aria2.Location = new System.Drawing.Point(15, 23);
            this.Start_Aria2.Margin = new System.Windows.Forms.Padding(12, 13, 12, 13);
            this.Start_Aria2.Name = "Start_Aria2";
            this.Start_Aria2.Size = new System.Drawing.Size(196, 81);
            this.Start_Aria2.TabIndex = 0;
            this.Start_Aria2.Text = "啟動";
            this.Start_Aria2.UseVisualStyleBackColor = false;
            this.Start_Aria2.Click += new System.EventHandler(this.Start_Aria2_Click);
            // 
            // Stop_Aria2
            // 
            this.Stop_Aria2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(227)))), ((int)(((byte)(218)))));
            this.Stop_Aria2.Location = new System.Drawing.Point(221, 23);
            this.Stop_Aria2.Margin = new System.Windows.Forms.Padding(12, 13, 12, 13);
            this.Stop_Aria2.Name = "Stop_Aria2";
            this.Stop_Aria2.Size = new System.Drawing.Size(196, 81);
            this.Stop_Aria2.TabIndex = 1;
            this.Stop_Aria2.Text = "停止";
            this.Stop_Aria2.UseVisualStyleBackColor = false;
            this.Stop_Aria2.Click += new System.EventHandler(this.Stop_Aria2_Click);
            // 
            // Restart_Aria2
            // 
            this.Restart_Aria2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(227)))), ((int)(((byte)(218)))));
            this.Restart_Aria2.Location = new System.Drawing.Point(427, 23);
            this.Restart_Aria2.Margin = new System.Windows.Forms.Padding(12, 13, 12, 13);
            this.Restart_Aria2.Name = "Restart_Aria2";
            this.Restart_Aria2.Size = new System.Drawing.Size(196, 81);
            this.Restart_Aria2.TabIndex = 2;
            this.Restart_Aria2.Text = "重啟";
            this.Restart_Aria2.UseVisualStyleBackColor = false;
            this.Restart_Aria2.Click += new System.EventHandler(this.Restart_Aria2_Click);
            // 
            // Information_Box
            // 
            this.Information_Box.BackColor = System.Drawing.Color.Black;
            this.Information_Box.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Information_Box.Font = new System.Drawing.Font("新細明體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Information_Box.ForeColor = System.Drawing.Color.Lime;
            this.Information_Box.Location = new System.Drawing.Point(15, 165);
            this.Information_Box.Multiline = true;
            this.Information_Box.Name = "Information_Box";
            this.Information_Box.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Information_Box.Size = new System.Drawing.Size(612, 199);
            this.Information_Box.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Boost_Up_label);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.menuStrip2);
            this.groupBox1.Controls.Add(this.Information_Box);
            this.groupBox1.Controls.Add(this.Restart_Aria2);
            this.groupBox1.Controls.Add(this.Stop_Aria2);
            this.groupBox1.Controls.Add(this.Start_Aria2);
            this.groupBox1.Controls.Add(this.Watch_Log_TextBox);
            this.groupBox1.Location = new System.Drawing.Point(12, 88);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(646, 384);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            // 
            // Boost_Up_label
            // 
            this.Boost_Up_label.AutoSize = true;
            this.Boost_Up_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(227)))), ((int)(((byte)(218)))));
            this.Boost_Up_label.Location = new System.Drawing.Point(342, 128);
            this.Boost_Up_label.Name = "Boost_Up_label";
            this.Boost_Up_label.Size = new System.Drawing.Size(289, 20);
            this.Boost_Up_label.TabIndex = 11;
            this.Boost_Up_label.Text = "設置開機啟動：目前為關閉狀態";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Aria2_Control_Panel.Properties.Resources.switch_on;
            this.pictureBox1.Location = new System.Drawing.Point(296, 115);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(40, 40);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.PictureBox1_Click);
            // 
            // menuStrip2
            // 
            this.menuStrip2.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.menuStrip2.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Now_Status,
            this.Watch_Log});
            this.menuStrip2.Location = new System.Drawing.Point(15, 128);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(178, 27);
            this.menuStrip2.TabIndex = 8;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // Now_Status
            // 
            this.Now_Status.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.Now_Status.Name = "Now_Status";
            this.Now_Status.Size = new System.Drawing.Size(81, 23);
            this.Now_Status.Text = "目前狀態";
            this.Now_Status.Click += new System.EventHandler(this.Now_Status_Click);
            // 
            // Watch_Log
            // 
            this.Watch_Log.BackColor = System.Drawing.Color.Gray;
            this.Watch_Log.Name = "Watch_Log";
            this.Watch_Log.Size = new System.Drawing.Size(89, 23);
            this.Watch_Log.Text = "查看log檔";
            this.Watch_Log.Click += new System.EventHandler(this.Watch_Log_Click);
            // 
            // Watch_Log_TextBox
            // 
            this.Watch_Log_TextBox.BackColor = System.Drawing.Color.Black;
            this.Watch_Log_TextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Watch_Log_TextBox.Font = new System.Drawing.Font("新細明體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Watch_Log_TextBox.ForeColor = System.Drawing.Color.Lime;
            this.Watch_Log_TextBox.Location = new System.Drawing.Point(15, 165);
            this.Watch_Log_TextBox.Multiline = true;
            this.Watch_Log_TextBox.Name = "Watch_Log_TextBox";
            this.Watch_Log_TextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Watch_Log_TextBox.Size = new System.Drawing.Size(612, 199);
            this.Watch_Log_TextBox.TabIndex = 9;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(169)))), ((int)(((byte)(222)))));
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(669, 58);
            this.panel1.TabIndex = 8;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Aria2_Control_Panel.Properties.Resources.Panel_Img_50;
            this.pictureBox2.Location = new System.Drawing.Point(12, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(50, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 18F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(7)))), ((int)(((byte)(7)))));
            this.label1.Location = new System.Drawing.Point(71, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 37);
            this.label1.TabIndex = 4;
            this.label1.Text = "Aria2 控制台";
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(169)))), ((int)(((byte)(222)))));
            this.button4.Dock = System.Windows.Forms.DockStyle.Right;
            this.button4.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(98)))), ((int)(((byte)(112)))));
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Century", 12F);
            this.button4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(7)))), ((int)(((byte)(7)))));
            this.button4.Image = global::Aria2_Control_Panel.Properties.Resources.window_shade;
            this.button4.Location = new System.Drawing.Point(373, 0);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(71, 58);
            this.button4.TabIndex = 3;
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(169)))), ((int)(((byte)(222)))));
            this.button3.Dock = System.Windows.Forms.DockStyle.Right;
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(98)))), ((int)(((byte)(112)))));
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Century", 12F);
            this.button3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(7)))), ((int)(((byte)(7)))));
            this.button3.Image = global::Aria2_Control_Panel.Properties.Resources.minimize_window;
            this.button3.Location = new System.Drawing.Point(444, 0);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 58);
            this.button3.TabIndex = 2;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(169)))), ((int)(((byte)(222)))));
            this.button2.Dock = System.Windows.Forms.DockStyle.Right;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(98)))), ((int)(((byte)(112)))));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(7)))), ((int)(((byte)(7)))));
            this.button2.Image = global::Aria2_Control_Panel.Properties.Resources.maximize_window;
            this.button2.Location = new System.Drawing.Point(519, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 58);
            this.button2.TabIndex = 1;
            this.button2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(169)))), ((int)(((byte)(222)))));
            this.button1.Dock = System.Windows.Forms.DockStyle.Right;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(98)))), ((int)(((byte)(112)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(7)))), ((int)(((byte)(7)))));
            this.button1.Image = global::Aria2_Control_Panel.Properties.Resources.close_window;
            this.button1.Location = new System.Drawing.Point(594, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 58);
            this.button1.TabIndex = 0;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(169)))), ((int)(((byte)(222)))));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.編輯設定檔ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 58);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(669, 28);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 編輯設定檔ToolStripMenuItem
            // 
            this.編輯設定檔ToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(227)))), ((int)(((byte)(218)))));
            this.編輯設定檔ToolStripMenuItem.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.編輯設定檔ToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlText;
            this.編輯設定檔ToolStripMenuItem.Name = "編輯設定檔ToolStripMenuItem";
            this.編輯設定檔ToolStripMenuItem.Size = new System.Drawing.Size(101, 24);
            this.編輯設定檔ToolStripMenuItem.Text = "編輯設定檔";
            this.編輯設定檔ToolStripMenuItem.Click += new System.EventHandler(this.編輯設定檔ToolStripMenuItem_Click);
            // 
            // dragControl1
            // 
            this.dragControl1.SelectControl = this.panel1;
            // 
            // dragControl2
            // 
            this.dragControl2.SelectControl = this.pictureBox2;
            // 
            // dragControl3
            // 
            this.dragControl3.SelectControl = this.label1;
            // 
            // dragControl4
            // 
            this.dragControl4.SelectControl = this;
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(98)))), ((int)(((byte)(112)))));
            this.ClientSize = new System.Drawing.Size(669, 482);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = " Aria2 控制台";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Start_Aria2;
        private System.Windows.Forms.Button Stop_Aria2;
        private System.Windows.Forms.Button Restart_Aria2;
        private System.Windows.Forms.TextBox Information_Box;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem Watch_Log;
        private System.Windows.Forms.TextBox Watch_Log_TextBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label Boost_Up_label;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 編輯設定檔ToolStripMenuItem;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private DragControl dragControl1;
        private DragControl dragControl2;
        private DragControl dragControl3;
        private DragControl dragControl4;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ToolStripMenuItem Now_Status;
    }
}

