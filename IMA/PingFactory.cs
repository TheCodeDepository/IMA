using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace IMA
{
    class PingFactory
    {
        public PingFactory(int timerInterval, string ip, int timeout, int gateNumber, bool canFragment, string Directory)
        {
            string data = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";
            Buffer = Encoding.ASCII.GetBytes(data);
            ServerIP = ip;
            TimeOut = timeout;
            CanFragment = canFragment;
            GateNumber = gateNumber;
            this.Directory = Directory;
            CreateNewLogPath(Directory);
            timer = new Timer(timerInterval);
            timer.Elapsed += SendPing;
            lineCount = 20;
        }
        public Action<string> NewRecord;
        private string Directory { get; set; }
        public Timer timer { get; set; }
        public int lineCount { get; set; }
        private byte[] Buffer { get; set; }
        private string ServerIP { get; set; }
        private int TimeOut { get; set; }
        private int GateNumber { get; set; }
        private bool CanFragment { get; set; }
        private string LogPath { get; set; }
        public string RecentLog { get; set; }

        public void SendPing(object sender, ElapsedEventArgs e)
        {
            Ping pingSender = new Ping();
            PingOptions options = new PingOptions(GateNumber, CanFragment);
            PingReply reply = pingSender.Send(ServerIP, TimeOut, Buffer, options);
            AppendLog(reply);

        }


        int linesPrinted = 0;

        public void AppendLog(PingReply reply)
        {
            string tmplog;
            DateTime time = DateTime.Now;
            string date = string.Format("{0:dd/MM/yy H:mm:ss}", time);
            if (reply.Status == IPStatus.Success)
            {   
                tmplog = string.Format($"Server IP: {ServerIP}  Response Time: {reply.RoundtripTime}  TTL: {reply.Options.Ttl}  Bytes: {reply.Buffer.Length}  Date & Time: {date}");
                WriteToLog(LogPath, tmplog);         
                linesPrinted++;
            }
            else
            {
                tmplog = string.Format($"Server IP: {ServerIP}  Response Time: {reply.Status}  Date & Time: {date}");
                WriteToLog(Directory+"\\Faliure.txt", tmplog);
                WriteToLog(LogPath, tmplog);
            }

        }



        private void WriteToLog(string path, string mess)
        {
            RecentLog = mess;
          
            
            NewRecord(mess);
            using (StreamWriter file = new StreamWriter(path, true))
            {
                file.WriteLine(mess);
            }
            if (linesPrinted == lineCount)
            {
                CreateNewLogPath(Directory);
            }
        }

        private void CreateNewLogPath(string dir)
        {
            DateTime time = DateTime.Now;
            string date = string.Format("{0:dd.MM.yy HH.mm}", time);
            LogPath = string.Format($"{dir}\\{date}.txt");
        }
    }
}
