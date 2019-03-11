using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.BusManager.DTO
{
    public class BusDTO
    {
        public string Id { get; set; }
        public string BSX { get; set; }
        public string Brand { get; set; }
        public DateTime DateRegistration { get; set; }
        public string OwnerID { get; set; }
        public string RouteID { get; set; }
    }
}
