using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bus.DTO
{
    class ScheduleViewModelOnBus
    {
        public string BusID { get; set; }
        private string departureTime;
        public string DepartureTime {
            get { return departureTime; }
            set { departureTime = value.ToString(); }
        }
        public string TimeBack { get; set; }
        public int Status { get; set; }
    }
}
