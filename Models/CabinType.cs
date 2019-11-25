using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session3.Models
{
    class CabinType
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public List<Ticket> Tickets { get; set; }
    }
}
