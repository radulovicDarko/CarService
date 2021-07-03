using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Models
{
    public class Owner
    {
        public int Id { get; set; }
        public String Name { get; set; }
        public String Surname { get; set; }
        public String Gender { get; set; }
        public String PhoneNumber { get; set; }
        public String Address { get; set; }
        public String Email { get; set; }

        public override string ToString()
        {
            return Name+" "+Surname;
        }
    }
}
