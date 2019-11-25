using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session3.Models
{
    class Route
    {
        public int ID { get; set; }
        public int DepartureAirportID { get; set; }
        public int ArrivalAirportID { get; set; }
        public int Distance { get; set; }
        public int FlightTime { get; set; }
    }
}
