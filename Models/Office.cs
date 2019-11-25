using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session3.Models
{
    class Office
    {
        public int ID { get; set; }
        public int CountryID { get; set; }
        public Country Country { get; set; }
        public string Title { get; set; }
        public string Phone { get; set; }
        public string Contact { get; set; }
        public List<User> Users { get; set; }
    }
}
