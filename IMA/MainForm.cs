using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IMA
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        PingFactory ping;

        public string LogPath
        {
            get { return logPath.Text; }
            set { logPath.Text = value; }
        }

        private void serverIP_TextChanged(object sender, EventArgs e)
        {

            UnlockButton();
        }

        private void saveLogPath_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog save = new FolderBrowserDialog();
            save.ShowDialog();
            LogPath = save.SelectedPath;
        }

        private void logPath_TextChanged(object sender, EventArgs e)
        {

            UnlockButton();
        }

        private void startBtn_Click(object sender, EventArgs e)
        {
            ping = new PingFactory(2000, serverIP.Text, 10000, 64, true, logPath.Text);
            ping.NewRecord += AddRecord;

            ping.timer.Start();
            startBtn.Enabled = false;
            stopBtn.Enabled = true;
        }

        private void AddRecord(string mess)
        {
            LogList.Items.Insert(0,mess);
        }

        private void stopBtn_Click(object sender, EventArgs e)
        {
            ping.timer.Stop();
            startBtn.Enabled = true;
            stopBtn.Enabled = false;
        }
        bool serverBool = false;
        bool logPathBool = false;
        private void UnlockButton()
        {
            if (!(logPath.Text.Length < 3))
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
            if (serverBool && logPathBool)
            {
                startBtn.Enabled = true;
            }
            else
            {
                startBtn.Enabled = false;
            }
        }





    }
}
