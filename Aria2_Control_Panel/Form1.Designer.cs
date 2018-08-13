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
            this.panel_label = new System.Windows.Forms.Label();
            this.Restart_Aria2 = new System.Windows.Forms.Button();
            this.Information_Box = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
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
            // panel_label
            // 
            this.panel_label.AutoSize = true;
            this.panel_label.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.panel_label.Location = new System.Drawing.Point(39, 259);
            this.panel_label.Name = "panel_label";
            this.panel_label.Size = new System.Drawing.Size(89, 20);
            this.panel_label.TabIndex = 4;
            this.panel_label.Text = "目前狀態";
            this.panel_label.Click += new System.EventHandler(this.label1_Click);
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
            this.Information_Box.TextChanged += new System.EventHandler(this.Information_Box_TextChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.ForeColor = System.Drawing.SystemColors.Control;
            this.checkBox1.Location = new System.Drawing.Point(335, 258);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(311, 24);
            this.checkBox1.TabIndex = 5;
            this.checkBox1.Text = "設置開機啟動：目前為關閉狀態";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.Click += new System.EventHandler(this.checkBox1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Controls.Add(this.Information_Box);
            this.groupBox1.Controls.Add(this.Restart_Aria2);
            this.groupBox1.Controls.Add(this.panel_label);
            this.groupBox1.Controls.Add(this.Stop_Aria2);
            this.groupBox1.Controls.Add(this.Start_Aria2);
            this.groupBox1.Location = new System.Drawing.Point(40, 48);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(695, 520);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "控制";
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
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 編輯設定檔ToolStripMenuItem;
        private System.Windows.Forms.Button Start_Aria2;
        private System.Windows.Forms.Button Stop_Aria2;
        private System.Windows.Forms.Label panel_label;
        private System.Windows.Forms.Button Restart_Aria2;
        private System.Windows.Forms.TextBox Information_Box;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

