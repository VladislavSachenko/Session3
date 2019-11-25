using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session3.Models
{
    class Schedule
    {
        public int ID { get; set; }
        public DateTime Date { get; set; }
        public TimeSpan Time { get; set; }

        public int AircraftID { get; set; }
        public Aircraft Aircraft { get; set; }

        public int RouteID { get; set; }
        public Route Route { get; set; }

        public decimal EconomyPrice { get; set; }
        public bool Confirmed { get; set; }
        public string FlightNumber { get; set; }

        public List<Ticket> Tickets { get; set; }

    }
}
