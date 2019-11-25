using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session3.Models
{
    class Role
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public List<User> Users { get; set; }
    }
}
