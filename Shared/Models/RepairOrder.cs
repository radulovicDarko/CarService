using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Models
{
    public class RepairOrder
    {
        public int Id { get; set; }
        public String DateOfReceipt { get; set; }
        public String Description { get; set; }
        public decimal Price { get; set; }
        public String VehicleId { get; set; }
        public bool RepairStatus { get; set; }

    }
}
