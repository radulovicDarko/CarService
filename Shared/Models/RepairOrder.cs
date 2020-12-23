﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Models
{
    public class RepairOrder
    {
        public String Id { get; set; }
        public String DateOfReceipt { get; set; }
        public String Description { get; set; }
        public decimal Price { get; set; }
    }
}
