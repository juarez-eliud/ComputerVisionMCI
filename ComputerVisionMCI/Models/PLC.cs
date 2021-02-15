using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerVisionMCI.Models
{
    class PLC
    {
        public int Port { get; set; }
        public string IP { get; set; }
        public int Rack { get; set; }
        public int Slot { get; set; }
    }
}
