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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.編輯設定檔ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Start_Aria2 = new System.Windows.Forms.Button();
            this.Stop_Aria2 = new System.Windows.Forms.Button();
            this.Restart_Aria2 = new System.Windows.Forms.Button();
            this.Information_Box = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.Now_Status = new System.Windows.Forms.ToolStripMenuItem();
            this.Watch_Log = new System.Windows.Forms.ToolStripMenuItem();
            this.Watch_Log_TextBox = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Boost_Up_label = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.menuStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.編輯設定檔ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(774, 28);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 編輯設定檔ToolStripMenuItem
            // 
            this.編輯設定檔ToolStripMenuItem.Name = "編輯設定檔ToolStripMenuItem";
            this.編輯設定檔ToolStripMenuItem.Size = new System.Drawing.Size(96, 24);
            this.編輯設定檔ToolStripMenuItem.Text = "編輯設定檔";
            this.編輯設定檔ToolStripMenuItem.Click += new System.EventHandler(this.編輯設定檔ToolStripMenuItem_Click);
            // 
            // Start_Aria2
            // 
            this.Start_Aria2.Location = new System.Drawing.Point(33, 49);
            this.Start_Aria2.Margin = new System.Windows.Forms.Padding(12, 13, 12, 13);
            this.Start_Aria2.Name = "Start_Aria2";
            this.Start_Aria2.Size = new System.Drawing.Size(182, 182);
            this.Start_Aria2.TabIndex = 0;
            this.Start_Aria2.Text = "啟動";
            this.Start_Aria2.UseVisualStyleBackColor = true;
            this.Start_Aria2.Click += new System.EventHandler(this.Start_Aria2_Click);
            // 
            // Stop_Aria2
            // 
            this.Stop_Aria2.Location = new System.Drawing.Point(239, 49);
            this.Stop_Aria2.Margin = new System.Windows.Forms.Padding(12, 13, 12, 13);
            this.Stop_Aria2.Name = "Stop_Aria2";
            this.Stop_Aria2.Size = new System.Drawing.Size(182, 182);
            this.Stop_Aria2.TabIndex = 1;
            this.Stop_Aria2.Text = "停止";
            this.Stop_Aria2.UseVisualStyleBackColor = true;
            this.Stop_Aria2.Click += new System.EventHandler(this.Stop_Aria2_Click);
            // 
            // Restart_Aria2
            // 
            this.Restart_Aria2.Location = new System.Drawing.Point(445, 49);
            this.Restart_Aria2.Margin = new System.Windows.Forms.Padding(12, 13, 12, 13);
            this.Restart_Aria2.Name = "Restart_Aria2";
            this.Restart_Aria2.Size = new System.Drawing.Size(182, 182);
            this.Restart_Aria2.TabIndex = 2;
            this.Restart_Aria2.Text = "重啟";
            this.Restart_Aria2.UseVisualStyleBackColor = true;
            this.Restart_Aria2.Click += new System.EventHandler(this.Restart_Aria2_Click);
            // 
            // Information_Box
            // 
            this.Information_Box.BackColor = System.Drawing.Color.Black;
            this.Information_Box.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Information_Box.Font = new System.Drawing.Font("新細明體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Information_Box.ForeColor = System.Drawing.Color.Lime;
            this.Information_Box.Location = new System.Drawing.Point(34, 297);
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
            this.groupBox1.Location = new System.Drawing.Point(40, 48);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(695, 520);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "控制";
            // 
            // menuStrip2
            // 
            this.menuStrip2.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.menuStrip2.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Now_Status,
            this.Watch_Log});
            this.menuStrip2.Location = new System.Drawing.Point(33, 266);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(177, 28);
            this.menuStrip2.TabIndex = 8;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // Now_Status
            // 
            this.Now_Status.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.Now_Status.Name = "Now_Status";
            this.Now_Status.Size = new System.Drawing.Size(81, 24);
            this.Now_Status.Text = "目前狀態";
            this.Now_Status.Click += new System.EventHandler(this.Now_Status_Click);
            // 
            // Watch_Log
            // 
            this.Watch_Log.BackColor = System.Drawing.Color.Gray;
            this.Watch_Log.Name = "Watch_Log";
            this.Watch_Log.Size = new System.Drawing.Size(88, 24);
            this.Watch_Log.Text = "查看log檔";
            this.Watch_Log.Click += new System.EventHandler(this.Watch_Log_Click);
            // 
            // Watch_Log_TextBox
            // 
            this.Watch_Log_TextBox.BackColor = System.Drawing.Color.Black;
            this.Watch_Log_TextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Watch_Log_TextBox.Font = new System.Drawing.Font("新細明體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Watch_Log_TextBox.ForeColor = System.Drawing.Color.Lime;
            this.Watch_Log_TextBox.Location = new System.Drawing.Point(33, 297);
            this.Watch_Log_TextBox.Multiline = true;
            this.Watch_Log_TextBox.Name = "Watch_Log_TextBox";
            this.Watch_Log_TextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Watch_Log_TextBox.Size = new System.Drawing.Size(612, 199);
            this.Watch_Log_TextBox.TabIndex = 9;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Aria2_Control_Panel.Properties.Resources.switch_on;
            this.pictureBox1.Location = new System.Drawing.Point(280, 247);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(40, 40);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Boost_Up_label
            // 
            this.Boost_Up_label.AutoSize = true;
            this.Boost_Up_label.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Boost_Up_label.Location = new System.Drawing.Point(338, 257);
            this.Boost_Up_label.Name = "Boost_Up_label";
            this.Boost_Up_label.Size = new System.Drawing.Size(289, 20);
            this.Boost_Up_label.TabIndex = 11;
            this.Boost_Up_label.Text = "設置開機啟動：目前為關閉狀態";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(774, 601);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = " Aria2 控制台";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 編輯設定檔ToolStripMenuItem;
        private System.Windows.Forms.Button Start_Aria2;
        private System.Windows.Forms.Button Stop_Aria2;
        private System.Windows.Forms.Button Restart_Aria2;
        private System.Windows.Forms.TextBox Information_Box;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem Now_Status;
        private System.Windows.Forms.ToolStripMenuItem Watch_Log;
        private System.Windows.Forms.TextBox Watch_Log_TextBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label Boost_Up_label;
    }
}

