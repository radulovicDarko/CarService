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
        int updateRepairOrder(RepairOrder repairOrder);
        int deleteRepairOrder(RepairOrder repairOrder);

    }
}
