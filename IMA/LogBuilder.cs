using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace IMA
{
    class LogBuilder
    {
        public LogBuilder(string ServerIP, int TTL, int Bytes, int Timeout)
        {
            this.ServerIP = ServerIP;
            this.TTL = TTL;
            this.Bytes = Bytes;
            this.Timeout = Timeout;
        }

        public string ServerIP { get; }
        public int TTL { get; }
        public int Bytes { get; }
        public int Timeout { get; }

        public string successLog(long ResponseTime, string status)
        {

            string tmplog;
            string currentTimeStr = string.Format("{0:dd/MM/yy H:mm:ss}", DateTime.Now);

            tmplog = string.Format($"Server IP: {ServerIP}  Response Time: {ResponseTime}  Date & Time: {currentTimeStr}  Status: {status}  TTL: {TTL}  Bytes: {Bytes}  Timeout Period: {Timeout}");

            tmplog = string.Format($"Server IP:{ServerIP} TTL:{TTL} Bytes:{Bytes} Timeout Period:{Timeout}ms Date & Time:{currentTimeStr} Status:{status} Response Time:{ResponseTime}ms");

            tmplog = string.Format($"Server IP: {ServerIP}  Date & Time: {currentTimeStr}  Timeout Period: {Timeout}  Status: {status}");
            return tmplog;

        }



    }



}

