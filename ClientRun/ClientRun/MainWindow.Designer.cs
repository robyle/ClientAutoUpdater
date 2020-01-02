namespace ClientRun
{
    partial class MainWindow
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.cbAutoUpdater = new System.Windows.Forms.CheckBox();
            this.rtbLog = new System.Windows.Forms.RichTextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(124, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "软件当前版本号:V2";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(153, 65);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(138, 30);
            this.button1.TabIndex = 1;
            this.button1.Text = "手动点击更新";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cbAutoUpdater
            // 
            this.cbAutoUpdater.AutoSize = true;
            this.cbAutoUpdater.Location = new System.Drawing.Point(181, 112);
            this.cbAutoUpdater.Name = "cbAutoUpdater";
            this.cbAutoUpdater.Size = new System.Drawing.Size(72, 16);
            this.cbAutoUpdater.TabIndex = 2;
            this.cbAutoUpdater.Text = "自动更新";
            this.cbAutoUpdater.UseVisualStyleBackColor = true;
            this.cbAutoUpdater.CheckedChanged += new System.EventHandler(this.cbAutoUpdater_CheckedChanged);
            // 
            // rtbLog
            // 
            this.rtbLog.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbLog.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.rtbLog.Location = new System.Drawing.Point(0, 159);
            this.rtbLog.Name = "rtbLog";
            this.rtbLog.Size = new System.Drawing.Size(496, 153);
            this.rtbLog.TabIndex = 3;
            this.rtbLog.Text = "";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 130);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "查看更新";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 312);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.rtbLog);
            this.Controls.Add(this.cbAutoUpdater);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "软件更新";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox cbAutoUpdater;
        private System.Windows.Forms.RichTextBox rtbLog;
        private System.Windows.Forms.Button button2;
    }
}

