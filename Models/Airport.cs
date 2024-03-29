﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Session3.Models
{
    class Airport
    {
        public int ID { get; set; }
        public int CountryID { get; set; }
        public Country Country { get; set; }
        public string IATACode { get; set; }
        public string Name { get; set; }
        public List<Route> ArrivalRoutes { get; set; }
        public List<Route> DepatureRoutes { get; set; }
    }
}
