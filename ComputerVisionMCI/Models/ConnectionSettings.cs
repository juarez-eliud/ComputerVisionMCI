using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerVisionMCI.Models
{
    class ConnectionSettings
    {
        public int Port { get; set; }
        public string IP { get; set; }
        public int Rack { get; set; }
        public int Slot { get; set; }

        //public ConnectionSettings(int p, string ip, int r, int s)
        //{
        //    Port = p;
        //    IP = ip;
        //    Rack = r;
        //    Slot = s;
        //}
    }
}
