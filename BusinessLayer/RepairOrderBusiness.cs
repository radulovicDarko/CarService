using Shared.Interfaces.Business;
using Shared.Interfaces.Repository;
using Shared.Models;
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
        public List<RepairOrder> getAllRepairOrders()
        {
            return this.repairOrderRepository.GetAllRepairOrders();
        }
        public int insertRepairOrder(RepairOrder repairOrder)
        {
            return this.repairOrderRepository.InsertRepairOrder(repairOrder);
        }

        public int updateRepairOrder(RepairOrder repairOrder)
        {
            return this.repairOrderRepository.UpdateRepairOrder(repairOrder);
        }
        public int deleteRepairOrder(RepairOrder repairOrder)
        {
            return this.repairOrderRepository.DeleteRepairOrder(repairOrder);
        }
    }
}
