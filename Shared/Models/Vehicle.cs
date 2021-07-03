using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Models
{
    public class Vehicle
    {
        public String ChassisNumber { get; set; }
        public String Brand { get; set; }
        public String Type { get; set; }
        public int YearOfManufacture { get; set; }
        public String LicencePlate { get; set; }
        public int OwnerId { get; set; }
    }
}
