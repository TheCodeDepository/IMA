namespace IMA
{
    partial class MainForm
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
            this.logPathLabel = new System.Windows.Forms.Label();
            this.logPath = new System.Windows.Forms.TextBox();
            this.saveLogPath = new System.Windows.Forms.Button();
            this.startBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.serverIP = new System.Windows.Forms.TextBox();
            this.stopBtn = new System.Windows.Forms.Button();
            this.timeElapsedLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.LogList = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // logPathLabel
            // 
            this.logPathLabel.AutoSize = true;
            this.logPathLabel.Location = new System.Drawing.Point(14, 15);
            this.logPathLabel.Name = "logPathLabel";
            this.logPathLabel.Size = new System.Drawing.Size(72, 13);
            this.logPathLabel.TabIndex = 0;
            this.logPathLabel.Text = "Log Location:";
            // 
            // logPath
            // 
            this.logPath.Location = new System.Drawing.Point(87, 11);
            this.logPath.Multiline = true;
            this.logPath.Name = "logPath";
            this.logPath.Size = new System.Drawing.Size(251, 21);
            this.logPath.TabIndex = 1;
            this.logPath.Text = "C:\\";
            this.logPath.TextChanged += new System.EventHandler(this.logPath_TextChanged);
            // 
            // saveLogPath
            // 
            this.saveLogPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F);
            this.saveLogPath.Location = new System.Drawing.Point(318, 12);
            this.saveLogPath.Name = "saveLogPath";
            this.saveLogPath.Size = new System.Drawing.Size(19, 19);
            this.saveLogPath.TabIndex = 2;
            this.saveLogPath.Text = "...";
            this.saveLogPath.UseVisualStyleBackColor = true;
            this.saveLogPath.Click += new System.EventHandler(this.saveLogPath_Click);
            // 
            // startBtn
            // 
            this.startBtn.Enabled = false;
            this.startBtn.Location = new System.Drawing.Point(17, 79);
            this.startBtn.Name = "startBtn";
            this.startBtn.Size = new System.Drawing.Size(75, 23);
            this.startBtn.TabIndex = 3;
            this.startBtn.Text = "Start";
            this.startBtn.UseVisualStyleBackColor = true;
            this.startBtn.Click += new System.EventHandler(this.startBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Server IP:";
            // 
            // serverIP
            // 
            this.serverIP.Location = new System.Drawing.Point(87, 38);
            this.serverIP.Multiline = true;
            this.serverIP.Name = "serverIP";
            this.serverIP.Size = new System.Drawing.Size(251, 21);
            this.serverIP.TabIndex = 6;
            this.serverIP.TextChanged += new System.EventHandler(this.serverIP_TextChanged);
            // 
            // stopBtn
            // 
            this.stopBtn.Enabled = false;
            this.stopBtn.Location = new System.Drawing.Point(17, 108);
            this.stopBtn.Name = "stopBtn";
            this.stopBtn.Size = new System.Drawing.Size(75, 23);
            this.stopBtn.TabIndex = 7;
            this.stopBtn.Text = "Stop";
            this.stopBtn.UseVisualStyleBackColor = true;
            this.stopBtn.Click += new System.EventHandler(this.stopBtn_Click);
            // 
            // timeElapsedLabel
            // 
            this.timeElapsedLabel.AutoSize = true;
            this.timeElapsedLabel.Location = new System.Drawing.Point(292, 84);
            this.timeElapsedLabel.Name = "timeElapsedLabel";
            this.timeElapsedLabel.Size = new System.Drawing.Size(35, 13);
            this.timeElapsedLabel.TabIndex = 8;
            this.timeElapsedLabel.Text = "label2";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(179, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Time Elapsed:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(155, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Number of Failures:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(155, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Longest Faliure:";
            // 
            // LogList
            // 
            this.LogList.FormattingEnabled = true;
            this.LogList.Location = new System.Drawing.Point(13, 148);
            this.LogList.Name = "LogList";
            this.LogList.Size = new System.Drawing.Size(590, 420);
            this.LogList.TabIndex = 12;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(615, 585);
            this.Controls.Add(this.LogList);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.timeElapsedLabel);
            this.Controls.Add(this.stopBtn);
            this.Controls.Add(this.serverIP);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.startBtn);
            this.Controls.Add(this.saveLogPath);
            this.Controls.Add(this.logPath);
            this.Controls.Add(this.logPathLabel);
            this.DoubleBuffered = true;
            this.Name = "MainForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label logPathLabel;
        private System.Windows.Forms.TextBox logPath;
        private System.Windows.Forms.Button saveLogPath;
        private System.Windows.Forms.Button startBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox serverIP;
        private System.Windows.Forms.Button stopBtn;
        private System.Windows.Forms.Label timeElapsedLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox LogList;
    }
}

