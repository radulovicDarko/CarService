using Shared.Interfaces.Business;
using Shared.Interfaces.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class RepairOrderBusiness : IRepairOrderBusiness
    {
        private readonly IRepairOrderRepository repairOrderRepository;

        public RepairOrderBusiness(IRepairOrderRepository _repairOrderRepository)
        {
            this.repairOrderRepository = _repairOrderRepository;
        }
    }
}
