using Shared.Interfaces.Repository;
using Shared.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
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
                temp.DateOfReceipt = sqlDataReader.GetDateTime(1).ToString();
                temp.Description = sqlDataReader.GetString(2);
                temp.Price = sqlDataReader.GetDecimal(3);
                temp.VehicleId = sqlDataReader.GetString(4);
                temp.RepairStatus = sqlDataReader.GetBoolean(5);

                ListToReturn.Add(temp);
            }

            DBConnection.CloseConnection();

            return ListToReturn;

        }

        public int InsertRepairOrder(RepairOrder repairOrder)
        {
            int result = DBConnection.EditData(string.Format("INSERT INTO RepairOrders VALUES ('{0}', '{1}', '{2}' , '{3}','{4}')",
                          repairOrder.DateOfReceipt,repairOrder.Description, repairOrder.Price, repairOrder.VehicleId,repairOrder.RepairStatus));

            DBConnection.CloseConnection();

            return result;
        }

        public int UpdateRepairOrder(RepairOrder repairOrder, int id)
        {
            var result = DBConnection.EditData(string.Format("UPDATE RepairOrders SET DateOfReceipt='{0}', Description ='{1}', Price ='{2}', VehicleId = '{3}' Where Id="+id, repairOrder.DateOfReceipt, repairOrder.Description, repairOrder.Price, repairOrder.VehicleId));

            DBConnection.CloseConnection();

            return result;
        }

        public int UpdateRepairStatus(int id)
        {
            var result = DBConnection.EditData(string.Format("UPDATE RepairOrders SET RepairStatus='{0}' Where Id=" + id, true));

            DBConnection.CloseConnection();

            return result;

        }

        public int DeleteRepairOrder(int repairOrderID)
        {
            var result = DBConnection.EditData("DELETE FROM RepairOrders WHERE Id=" + repairOrderID);

            DBConnection.CloseConnection();

            return result;
        }
    }
}