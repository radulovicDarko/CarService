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
        public RepairOrder getRepairOrderByID(int id)
        {
            return this.repairOrderRepository.GetAllRepairOrders().Where(r => r.Id == id).First();
        }
        public List<RepairOrder> getActiveRepairOrders()
        {
            return this.repairOrderRepository.GetAllRepairOrders().Where(r => !r.RepairStatus).ToList();
        }
        public int insertRepairOrder(RepairOrder repairOrder)
        {
            return this.repairOrderRepository.InsertRepairOrder(repairOrder);
        }

        public int updateRepairOrder(RepairOrder repairOrder, int id)
        {
            return this.repairOrderRepository.UpdateRepairOrder(repairOrder,id);
        }
        public int deleteRepairOrder(int repairOrderID)
        {
            return this.repairOrderRepository.DeleteRepairOrder(repairOrderID);
        }
        public int updateRepairStatus(int id)
        {
            return this.repairOrderRepository.UpdateRepairStatus(id);
        }
    }
}
