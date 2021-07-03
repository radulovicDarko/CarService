using Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Interfaces.Repository
{
    public interface IRepairOrderRepository
    {
        List<RepairOrder> GetAllRepairOrders();
        int InsertRepairOrder(RepairOrder repairOrder);
        int UpdateRepairOrder(RepairOrder repairOrder, int id);
        int DeleteRepairOrder(int repairOrderID);
        int UpdateRepairStatus(int id);
    }
}
