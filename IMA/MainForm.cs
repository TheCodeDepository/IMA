using System;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IMA
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            backgroundWorkerPing.WorkerReportsProgress = true;
            backgroundWorkerPing.WorkerSupportsCancellation = true;

        }

        /*
            Propertys and Fields
                                    */
        #region
        public string LogPath
        {
            get { return logPath.Text; }
            set { logPath.Text = value; }
        }

        public int Interval
        {
            get { return int.Parse(IntervalTb.Text); }
            set { IntervalTb.Text = value.ToString(); }
        }

        public int Timeout
        {
            get { return int.Parse(TimeoutPeriod.Text); }
            set { TimeoutPeriod.Text = value.ToString(); }
        }

        private readonly Stopwatch _stopwatch = new Stopwatch();
        private static PingFactory ping { get; set; }

        #endregion


        /*
            Buttons
                     */
        #region
        bool tf = false;
        private void StartStop()
        {
            tf = !tf;
            if (tf)
            {
                backgroundWorkerPing.RunWorkerAsync();
                pingInterval.Start();

                
                _stopwatch.Start();
                cancel = false;
                saveLogPath.Enabled = false;
                TimeoutPeriod.Enabled = false;
                serverIP.Enabled = false;
                startBtn.Enabled = false;
                stopBtn.Enabled = true;
                IntervalTb.Enabled = false;
            }
            else
            {
                stopBtn.Enabled = false;
                cancel = true;
                

            }

        }

        private void startBtn_Click(object sender, EventArgs e)
        {
            ping = new PingFactory(serverIP.Text, Timeout, 64, true, logPath.Text, 500000, Interval);
            StartStop();
        }

        private void stopBtn_Click(object sender, EventArgs e)
        {
            StartStop();
        }

        private void saveLogPath_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog save = new FolderBrowserDialog();
            save.ShowDialog();
            LogPath = save.SelectedPath;
        }

        private void serverIP_TextChanged(object sender, EventArgs e)
        {
            UnlockButton();
        }

        private void logPath_TextChanged(object sender, EventArgs e)
        {
            UnlockButton();
        }

        private void IntervalTb_TextChanged(object sender, EventArgs e)
        {
            UnlockButton();
        }

        private void TimeoutPeriod_TextChanged(object sender, EventArgs e)
        {
            UnlockButton();
        }

        private void UnlockButton()
        {
            bool timeoutBool = false;
            bool intervalBool = false;
            bool serverBool = false;
            bool logPathBool = false;

            if (logPath.Text.Length > 3)
            {
                logPathBool = true;
            }
            else
            {
                logPathBool = false;
            }

            string[] tmp = serverIP.Text.Split('.');
            if (tmp.Length == 4)
            {
                serverBool = true;
            }
            else
            {
                serverBool = false;
            }

            int tmpTimeout;
            if (int.TryParse(TimeoutPeriod.Text, out tmpTimeout))
            {
                timeoutBool = true;
            }
            else
            {
                timeoutBool = false;
            }

            int tmpInterval;
            if (int.TryParse(IntervalTb.Text, out tmpInterval))
            {
                intervalBool = true;
            }
            else
            {
                intervalBool = false;
            }

            if (serverBool && logPathBool && timeoutBool && intervalBool)
            {
                startBtn.Enabled = true;
            }
            else
            {
                startBtn.Enabled = false;
            }
        }
        #endregion


        /*
            Ping BackgroundWorker
                                    */
        #region
        Stopwatch pingInterval = new Stopwatch();
        private void backgroundWorkerPing_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            pingInterval.Restart();
            ping.SendPing();


            if (pingInterval.ElapsedMilliseconds < ping.interval)
            {
                int tmp = ping.interval - (int)pingInterval.ElapsedMilliseconds;
                Thread.Sleep(tmp);
            }

        }

        bool cancel = false;
        private void backgroundWorkerPing_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            LogList.Items.Insert(0, ping.RecentLog);

            LongestFailure.Text = ping.LongestFaliure.ToString(@"hh\:mm\:ss");
            numOfFaliures.Text = ping.numOfFaliures.ToString();

            int count = LogList.Items.Count;
            if (count > 200)
            {
                LogList.Items.RemoveAt(count - 1);
            }

            timeElapsedLabel.Text = _stopwatch.Elapsed.ToString(@"hh\:mm\:ss");
            if (cancel == false)
            {
                backgroundWorkerPing.RunWorkerAsync();

            }
            else
            {
                backgroundWorkerPing.CancelAsync();
                pingInterval.Stop();
                
                startBtn.Enabled = true;
                _stopwatch.Stop();
                saveLogPath.Enabled = true;
                TimeoutPeriod.Enabled = true;
                serverIP.Enabled = true;
                IntervalTb.Enabled = true;
            }
        }
        #endregion


        /*
            Helper Methods
                            */
        #region
        private void KeyDownNums(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar))
            {
                e.Handled = true;
            }
            if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
  
        }
        #endregion


    }
}
