using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Diagnostics;
using System.ComponentModel;

namespace IMA
{
    class PingFactory
    {
        public PingFactory(string ip, int timeout, int gateNumber, bool canFragment, string Directory, int lineCount, int pingInterval)
        {
            string data = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";
            Buffer = Encoding.ASCII.GetBytes(data);
            ServerIP = ip.Trim(' ');
            TimeOut = timeout;
            CanFragment = canFragment;
            GateNumber = gateNumber;
            this.Directory = Directory;
            CreateNewLogPath(Directory);
            this.lineCount = lineCount;
            numOfFaliures = 0;
            interval = pingInterval;
        }


        Stopwatch __timeoutWatch = new Stopwatch();
        private string Directory { get; set; }
        private int lineCount { get; set; }
        private byte[] Buffer { get; set; }
        private string ServerIP { get; set; }
        private int TimeOut { get; set; }
        private int GateNumber { get; set; }
        private bool CanFragment { get; set; }
        private string LogPath { get; set; }
        public string RecentLog { get; set; }
        public int numOfFaliures { get; private set; }
        public TimeSpan LongestFaliure { get; private set; }
        public int interval { get; set; }

        public void SendPing()
        {
            Ping pingSender = new Ping();
            PingOptions options = new PingOptions(GateNumber, CanFragment);

            try
            {

                PingReply reply = pingSender.Send(ServerIP, TimeOut, Buffer, options);
                AppendLog(reply);

            }
            catch (Exception)
            {
                
                if (!__timeoutWatch.IsRunning)
                {
                    lastTimeOut = DateTime.Now;
                    string date = string.Format("{0:dd/MM/yy H:mm:ss}", DateTime.Now);
                    RecentLog = string.Format($"Server IP: {ServerIP}  Date & Time: {date}  Timeout Period: {TimeOut}  Status: PingException");
                    WriteToLog(Directory + "\\FailureOverview.txt", RecentLog);
                    __timeoutWatch.Start();
                }
            }
        }

        private void GenerateLog(PingReply reply)
        {
            string tmplog;
            string currentTimeStr = string.Format("{0:dd/MM/yy H:mm:ss}", DateTime.Now);

            switch (reply.Status)
            {
                case IPStatus.Success:
                    if (__timeoutWatch.IsRunning)
                    {
                        tmplog = string.Format($"Server IP: {ServerIP}  Date & Time: {currentTimeStr}  Status: {reply.Status}  Down Time: {__timeoutWatch.Elapsed}  Timeout Period: {TimeOut}");
                        RecentLog = tmplog;
                        numOfFaliures++;
                        if (__timeoutWatch.Elapsed > LongestFaliure)
                        {

                            LongestFaliure = __timeoutWatch.Elapsed;
                        }
                        WriteToLog(Directory + "\\FailureOverview.txt", tmplog);
                        WriteToLog(LogPath, tmplog);
                        numOfFaliures++;
                        __timeoutWatch.Stop();
                    }
                    tmplog = string.Format($"Server IP: {ServerIP}  Response Time: {reply.RoundtripTime}  Date & Time: {currentTimeStr}  Status: {reply.Status}  TTL: {reply.Options.Ttl}  Bytes: {reply.Buffer.Length}  Timeout Period: {TimeOut}");

                    RecentLog = tmplog;
                    WriteToLog(LogPath, tmplog);
                    linesPrinted++;
                    break;                
                default:
                    if (!__timeoutWatch.IsRunning)
                    {
                        __timeoutWatch.Reset();
                        __timeoutWatch.Start();
                        lastTimeOut = DateTime.Now;
                    }
                    tmplog = string.Format($"Server IP: {ServerIP}  Date & Time: {currentTimeStr}  Timeout Period: {TimeOut}  Status: {reply.Status}");
                    RecentLog = tmplog;
                    WriteToLog(Directory + "\\Faliure.txt", tmplog);
                    WriteToLog(LogPath, tmplog);
                    break;

            }
        }

        private void GenerateLog(string status)
        {
            string date = string.Format("{0:dd/MM/yy H:mm:ss}", DateTime.Now);
            RecentLog = string.Format($"Server IP: {ServerIP}  Date & Time: {date}  Timeout Period: {TimeOut}  Status: PingException");
            WriteToLog(Directory + "\\FailureOverview.txt", RecentLog);
            __timeoutWatch.Start();
        }


        int linesPrinted = 0;
        DateTime lastTimeOut;

        private void AppendLog(PingReply reply)
        {
            DateTime time = DateTime.Now;

            string tmplog;
            string date = string.Format("{0:dd/MM/yy H:mm:ss}", time);
            if (reply.Status == IPStatus.Success)
            {
                if (__timeoutWatch.IsRunning)
                {
                    tmplog = string.Format($"Server IP: {ServerIP}  Date & Time: {date}  Status: {reply.Status}  Down Time: {__timeoutWatch.Elapsed}  Timeout Length: {TimeOut}");
                    RecentLog = tmplog;
                    numOfFaliures++;
                    if (__timeoutWatch.Elapsed > LongestFaliure)
                    {

                        LongestFaliure = __timeoutWatch.Elapsed;
                    }
                    WriteToLog(Directory + "\\FailureOverview.txt", tmplog);
                    WriteToLog(LogPath, tmplog);
                    numOfFaliures++;
                    __timeoutWatch.Stop();
                }
                tmplog = string.Format($"Server IP: {ServerIP}  Response Time: {reply.RoundtripTime}  Date & Time: {date}  Status: {reply.Status}  TTL: {reply.Options.Ttl}  Bytes: {reply.Buffer.Length}  Timeout Period: {TimeOut}");

                RecentLog = tmplog;
                WriteToLog(LogPath, tmplog);
               
            }
            else
            {
                if (!__timeoutWatch.IsRunning)
                {
                    __timeoutWatch.Reset();
                    __timeoutWatch.Start();
                    lastTimeOut = DateTime.Now;
                }
                tmplog = string.Format($"Server IP: {ServerIP}  Date & Time: {date}  Timeout Period: {TimeOut}  Status: {reply.Status}");
                RecentLog = tmplog;
                WriteToLog(Directory + "\\Faliure.txt", tmplog);
                WriteToLog(LogPath, tmplog);


            }



        }



        private void WriteToLog(string path, string mess)
        {
            RecentLog = mess;
            linesPrinted++;
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
