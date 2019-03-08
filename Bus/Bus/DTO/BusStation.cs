using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bus.DTO
{
    class BusStation
    {
        public int id { get; set; }
        public string BSX { get; set; }
        public string MSNVDRIVER { get; set; }
        public string MSNVCAST { get; set; }
        public string DepartureTime { get; set; }
        public string TimeBack { get; set; }
    }
}
