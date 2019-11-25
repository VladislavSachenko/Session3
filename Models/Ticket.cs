using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session3.Models
{
    class Ticket
    {
        public int ID { get; set; }
        public int UserID { get; set; }
        public User User { get; set; }

        public int ScheduleID { get; set; }
        public Schedule Schedule { get; set; }

        public int CabinTypeID { get; set; }
        public CabinType CabinType { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string PassportNumber { get; set; }
        public int PassportCountryID { get; set; }
        public string BookingReference { get; set; }
        public bool Confirmed { get; set; }
    }
}
