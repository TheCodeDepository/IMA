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
            this.numOfFaliures = new System.Windows.Forms.Label();
            this.LongestFailure = new System.Windows.Forms.Label();
            this.timeoutLabel = new System.Windows.Forms.Label();
            this.TimeoutPeriod = new System.Windows.Forms.TextBox();
            this.backgroundWorkerPing = new System.ComponentModel.BackgroundWorker();
            this.label5 = new System.Windows.Forms.Label();
            this.IntervalTb = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // logPathLabel
            // 
            this.logPathLabel.AutoSize = true;
            this.logPathLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logPathLabel.Location = new System.Drawing.Point(16, 17);
            this.logPathLabel.Name = "logPathLabel";
            this.logPathLabel.Size = new System.Drawing.Size(81, 15);
            this.logPathLabel.TabIndex = 0;
            this.logPathLabel.Text = "Log Location:";
            // 
            // logPath
            // 
            this.logPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logPath.Location = new System.Drawing.Point(106, 14);
            this.logPath.Name = "logPath";
            this.logPath.ReadOnly = true;
            this.logPath.Size = new System.Drawing.Size(292, 21);
            this.logPath.TabIndex = 1;
            this.logPath.Text = "C:\\Users\\marti\\Desktop\\Logs";
            this.logPath.TextChanged += new System.EventHandler(this.logPath_TextChanged);
            // 
            // saveLogPath
            // 
            this.saveLogPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            this.saveLogPath.Location = new System.Drawing.Point(373, 15);
            this.saveLogPath.Name = "saveLogPath";
            this.saveLogPath.Size = new System.Drawing.Size(24, 19);
            this.saveLogPath.TabIndex = 2;
            this.saveLogPath.Text = "...";
            this.saveLogPath.UseVisualStyleBackColor = true;
            this.saveLogPath.Click += new System.EventHandler(this.saveLogPath_Click);
            // 
            // startBtn
            // 
            this.startBtn.Enabled = false;
            this.startBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.startBtn.Location = new System.Drawing.Point(20, 91);
            this.startBtn.Name = "startBtn";
            this.startBtn.Size = new System.Drawing.Size(87, 27);
            this.startBtn.TabIndex = 3;
            this.startBtn.Text = "Start";
            this.startBtn.UseVisualStyleBackColor = true;
            this.startBtn.Click += new System.EventHandler(this.startBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(38, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "Server IP:";
            // 
            // serverIP
            // 
            this.serverIP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.serverIP.Location = new System.Drawing.Point(106, 44);
            this.serverIP.Name = "serverIP";
            this.serverIP.Size = new System.Drawing.Size(292, 21);
            this.serverIP.TabIndex = 6;
            this.serverIP.Text = "8.8.8.8";
            this.serverIP.TextChanged += new System.EventHandler(this.serverIP_TextChanged);
            // 
            // stopBtn
            // 
            this.stopBtn.Enabled = false;
            this.stopBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.stopBtn.Location = new System.Drawing.Point(20, 125);
            this.stopBtn.Name = "stopBtn";
            this.stopBtn.Size = new System.Drawing.Size(87, 27);
            this.stopBtn.TabIndex = 7;
            this.stopBtn.Text = "Stop";
            this.stopBtn.UseVisualStyleBackColor = true;
            this.stopBtn.Click += new System.EventHandler(this.stopBtn_Click);
            // 
            // timeElapsedLabel
            // 
            this.timeElapsedLabel.AutoSize = true;
            this.timeElapsedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.timeElapsedLabel.Location = new System.Drawing.Point(269, 92);
            this.timeElapsedLabel.Name = "timeElapsedLabel";
            this.timeElapsedLabel.Size = new System.Drawing.Size(55, 15);
            this.timeElapsedLabel.TabIndex = 8;
            this.timeElapsedLabel.Text = "00:00:00";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label2.Location = new System.Drawing.Point(164, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 15);
            this.label2.TabIndex = 9;
            this.label2.Text = "Time Elapsed:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label3.Location = new System.Drawing.Point(131, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 15);
            this.label3.TabIndex = 10;
            this.label3.Text = "Number of Failures:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label4.Location = new System.Drawing.Point(154, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 15);
            this.label4.TabIndex = 11;
            this.label4.Text = "Longest Faliure:";
            // 
            // LogList
            // 
            this.LogList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LogList.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.LogList.FormattingEnabled = true;
            this.LogList.ItemHeight = 15;
            this.LogList.Location = new System.Drawing.Point(15, 171);
            this.LogList.Name = "LogList";
            this.LogList.Size = new System.Drawing.Size(688, 484);
            this.LogList.TabIndex = 12;
            // 
            // numOfFaliures
            // 
            this.numOfFaliures.AutoSize = true;
            this.numOfFaliures.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.numOfFaliures.Location = new System.Drawing.Point(269, 113);
            this.numOfFaliures.Name = "numOfFaliures";
            this.numOfFaliures.Size = new System.Drawing.Size(14, 15);
            this.numOfFaliures.TabIndex = 17;
            this.numOfFaliures.Text = "0";
            // 
            // LongestFailure
            // 
            this.LongestFailure.AutoSize = true;
            this.LongestFailure.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.LongestFailure.Location = new System.Drawing.Point(269, 134);
            this.LongestFailure.Name = "LongestFailure";
            this.LongestFailure.Size = new System.Drawing.Size(55, 15);
            this.LongestFailure.TabIndex = 18;
            this.LongestFailure.Text = "00:00:00";
            // 
            // timeoutLabel
            // 
            this.timeoutLabel.AutoSize = true;
            this.timeoutLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeoutLabel.Location = new System.Drawing.Point(412, 16);
            this.timeoutLabel.Name = "timeoutLabel";
            this.timeoutLabel.Size = new System.Drawing.Size(55, 15);
            this.timeoutLabel.TabIndex = 19;
            this.timeoutLabel.Text = "Timeout:";
            // 
            // TimeoutPeriod
            // 
            this.TimeoutPeriod.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimeoutPeriod.Location = new System.Drawing.Point(469, 14);
            this.TimeoutPeriod.Name = "TimeoutPeriod";
            this.TimeoutPeriod.Size = new System.Drawing.Size(107, 21);
            this.TimeoutPeriod.TabIndex = 20;
            this.TimeoutPeriod.TextChanged += new System.EventHandler(this.TimeoutPeriod_TextChanged);
            this.TimeoutPeriod.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyDownNums);
            // 
            // backgroundWorkerPing
            // 
            this.backgroundWorkerPing.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorkerPing_DoWork);
            this.backgroundWorkerPing.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorkerPing_RunWorkerCompleted);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(418, 47);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 15);
            this.label5.TabIndex = 21;
            this.label5.Text = "Interval:";
            // 
            // IntervalTb
            // 
            this.IntervalTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IntervalTb.Location = new System.Drawing.Point(469, 44);
            this.IntervalTb.Name = "IntervalTb";
            this.IntervalTb.Size = new System.Drawing.Size(107, 21);
            this.IntervalTb.TabIndex = 22;
            this.IntervalTb.TextChanged += new System.EventHandler(this.IntervalTb_TextChanged);
            this.IntervalTb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyDownNums);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(717, 675);
            this.Controls.Add(this.IntervalTb);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TimeoutPeriod);
            this.Controls.Add(this.timeoutLabel);
            this.Controls.Add(this.LongestFailure);
            this.Controls.Add(this.numOfFaliures);
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
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
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
        private System.Windows.Forms.Label numOfFaliures;
        private System.Windows.Forms.Label LongestFailure;
        private System.Windows.Forms.Label timeoutLabel;
        private System.Windows.Forms.TextBox TimeoutPeriod;
        private System.ComponentModel.BackgroundWorker backgroundWorkerPing;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox IntervalTb;
    }
}

