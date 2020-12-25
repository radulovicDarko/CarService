using Shared.Interfaces.Repository;
using Shared.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Models
{
    public class RepairOrderRepository : IRepairOrderRepository
    {
        public List<RepairOrder> GetAllRepairOrders()
        {
            List<RepairOrder> ListToReturn = new List<RepairOrder>();

            SqlDataReader sqlDataReader = DBConnection.GetData("SELECT * from RepairOrders");

            while (sqlDataReader.Read())
            {
                RepairOrder temp = new RepairOrder();

                temp.Id = sqlDataReader.GetInt32(0);
                temp.DateOfReceipt = sqlDataReader.GetString(1);
                temp.Description = sqlDataReader.GetString(2);
                temp.Price = sqlDataReader.GetDecimal(3);
                temp.VehicleId = sqlDataReader.GetString(4);

                ListToReturn.Add(temp);
            }

            return ListToReturn;

        }

        public int InsertRepairOrder(RepairOrder repairOrder)
        {
            int result = DBConnection.EditData(string.Format("INSERT INTO RepairOrders VALUES ('{0}', '{1}', '{2}' , '{3}')",
                           repairOrder.DateOfReceipt, repairOrder.Description, repairOrder.Price, repairOrder.VehicleId));

            return result;
        }

        public int UpdateRepairOrder(RepairOrder repairOrder)
        {
            var result = DBConnection.EditData(string.Format("UPDATE RepairOrders SET ='{0}', DateOfReceipt='{1}', Description ='{2}', Price ='{3}', VehicleId = '{4}'", repairOrder.DateOfReceipt, repairOrder.Description, repairOrder.Price, repairOrder.VehicleId));

            return result;
        }

        public int DeleteRepairOrder(RepairOrder repairOrder)
        {
            var result = DBConnection.EditData("DELETE FROM RepairOrders WHERE Id=" + repairOrder.Id);

            return result;
        }


    }
}