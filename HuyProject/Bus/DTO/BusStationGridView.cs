using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bus.DTO
{
    public class BusStationGridView
    {
        public int ID { get; set; }
        public string BXS { get; set; }
        public string BusID { get; set; }
        public string MSNVDRIVER { get; set; }
        public string MSNVCAST { get; set; }
        public string DepartureTime { get; set; }
        public string TimeBack { get; set; }
        public string Status { get; set; }
    }

    public enum Change
    {
        ready = 1,
        late = 2,
        finished = 3,
        doing =4
    }
}
