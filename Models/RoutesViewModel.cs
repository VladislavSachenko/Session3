using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session3.Models
{
    class RoutesViewModel
    {
        public int ID { get; set; }
        public string From { get; set; }
        public string To { get; set; }
        public DateTime Date { get; set; }
        public TimeSpan Time { get; set; }
        public string FlightNumber { get; set; }
        public decimal CabinPrice { get; set; }
        public int NumbersOfStops { get; set; }
        public Route _Route { get; set; }
        public RoutesViewModel(Route r, DateTime date)
        {
            _Route = r;
            ID = r.ID;
            From = r.ArrivalAirport.Name;
            To = r.DepartureAirport.Name;

            //Schedule sch = r.Schedules.FirstOrDefault(date)
            Date = r.Schedules.FirstOrDefault().Date;
            Time = r.Schedules.FirstOrDefault().Time;        
        }
    }
}
