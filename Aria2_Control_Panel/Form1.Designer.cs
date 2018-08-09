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
            this.SuspendLayout();
            // 
            // Start_Aria2
            // 
            this.Start_Aria2.Location = new System.Drawing.Point(70, 35);
            this.Start_Aria2.Margin = new System.Windows.Forms.Padding(12, 13, 12, 13);
            this.Start_Aria2.Name = "Start_Aria2";
            this.Start_Aria2.Size = new System.Drawing.Size(274, 108);
            this.Start_Aria2.TabIndex = 0;
            this.Start_Aria2.Text = "啟動";
            this.Start_Aria2.UseVisualStyleBackColor = true;
            this.Start_Aria2.Click += new System.EventHandler(this.Start_Aria2_Click);
            // 
            // Stop_Aria2
            // 
            this.Stop_Aria2.Location = new System.Drawing.Point(70, 169);
            this.Stop_Aria2.Margin = new System.Windows.Forms.Padding(12, 13, 12, 13);
            this.Stop_Aria2.Name = "Stop_Aria2";
            this.Stop_Aria2.Size = new System.Drawing.Size(274, 108);
            this.Stop_Aria2.TabIndex = 1;
            this.Stop_Aria2.Text = "停止";
            this.Stop_Aria2.UseVisualStyleBackColor = true;
            this.Stop_Aria2.Click += new System.EventHandler(this.Stop_Aria2_Click);
            // 
            // Restart_Aria2
            // 
            this.Restart_Aria2.Location = new System.Drawing.Point(70, 307);
            this.Restart_Aria2.Margin = new System.Windows.Forms.Padding(12, 13, 12, 13);
            this.Restart_Aria2.Name = "Restart_Aria2";
            this.Restart_Aria2.Size = new System.Drawing.Size(274, 108);
            this.Restart_Aria2.TabIndex = 2;
            this.Restart_Aria2.Text = "重啟";
            this.Restart_Aria2.UseVisualStyleBackColor = true;
            this.Restart_Aria2.Click += new System.EventHandler(this.Restart_Aria2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(413, 447);
            this.Controls.Add(this.Restart_Aria2);
            this.Controls.Add(this.Stop_Aria2);
            this.Controls.Add(this.Start_Aria2);
            this.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = " Aria2 控制台";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Start_Aria2;
        private System.Windows.Forms.Button Stop_Aria2;
        private System.Windows.Forms.Button Restart_Aria2;
    }
}

