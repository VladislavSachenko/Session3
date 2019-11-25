using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session3.Models
{
    class Country
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Airport> Airports { get; set; }
        public List<Route> Routes { get; set; }
    }
}
