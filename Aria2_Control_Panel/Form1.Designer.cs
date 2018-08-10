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
            this.Start_Aria2 = new System.Windows.Forms.Button();
            this.Stop_Aria2 = new System.Windows.Forms.Button();
            this.Restart_Aria2 = new System.Windows.Forms.Button();
            this.Information_Box = new System.Windows.Forms.TextBox();
            this.panel_label = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // Start_Aria2
            // 
            this.Start_Aria2.Location = new System.Drawing.Point(46, 35);
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
            this.Stop_Aria2.Location = new System.Drawing.Point(261, 35);
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
            this.Restart_Aria2.Location = new System.Drawing.Point(476, 35);
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
            this.Information_Box.Location = new System.Drawing.Point(46, 278);
            this.Information_Box.Multiline = true;
            this.Information_Box.Name = "Information_Box";
            this.Information_Box.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Information_Box.Size = new System.Drawing.Size(612, 199);
            this.Information_Box.TabIndex = 3;
            this.Information_Box.TextChanged += new System.EventHandler(this.Information_Box_TextChanged);
            // 
            // panel_label
            // 
            this.panel_label.AutoSize = true;
            this.panel_label.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.panel_label.Location = new System.Drawing.Point(53, 244);
            this.panel_label.Name = "panel_label";
            this.panel_label.Size = new System.Drawing.Size(89, 20);
            this.panel_label.TabIndex = 4;
            this.panel_label.Text = "目前狀態";
            this.panel_label.Click += new System.EventHandler(this.label1_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.ForeColor = System.Drawing.SystemColors.Control;
            this.checkBox1.Location = new System.Drawing.Point(347, 240);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(311, 24);
            this.checkBox1.TabIndex = 5;
            this.checkBox1.Text = "設置開機啟動：目前為關閉狀態";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(701, 500);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.panel_label);
            this.Controls.Add(this.Information_Box);
            this.Controls.Add(this.Restart_Aria2);
            this.Controls.Add(this.Stop_Aria2);
            this.Controls.Add(this.Start_Aria2);
            this.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = " Aria2 控制台";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Start_Aria2;
        private System.Windows.Forms.Button Stop_Aria2;
        private System.Windows.Forms.Button Restart_Aria2;
        private System.Windows.Forms.TextBox Information_Box;
        private System.Windows.Forms.Label panel_label;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}

