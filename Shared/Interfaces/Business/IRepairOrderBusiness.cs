using Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Interfaces.Business
{
    public interface IRepairOrderBusiness
    {
        List<RepairOrder> getAllRepairOrders();
        int insertRepairOrder(RepairOrder repairOrder);
        int updateRepairOrder(RepairOrder repairOrder, int id);
        int deleteRepairOrder(int repairOrderID);
        RepairOrder getRepairOrderByID(int id);
        List<RepairOrder> getActiveRepairOrders();
        int updateRepairStatus(int id);
    }
}
