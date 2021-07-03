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
    public class VehicleRepository : IVehicleRepository
    {
        public List<Vehicle> GetAllVehicles()
        {
            List<Vehicle> listToReturn = new List<Vehicle>();

            SqlDataReader sqlDataReader = DBConnection.GetData("SELECT * FROM Vehicles");

            while (sqlDataReader.Read())
            {
                Vehicle temp = new Vehicle();

                temp.ChassisNumber = sqlDataReader.GetString(0);
                temp.Brand = sqlDataReader.GetString(1);
                temp.Type = sqlDataReader.GetString(2);
                temp.YearOfManufacture = sqlDataReader.GetInt32(3);
                temp.LicencePlate = sqlDataReader.GetString(4);
                temp.OwnerId = sqlDataReader.GetInt32(5);

                listToReturn.Add(temp);
            }

            DBConnection.CloseConnection();

            return listToReturn;
        }
        public int InsertVehicle(Vehicle temp)
        {
            int result = DBConnection.EditData(string.Format("INSERT INTO Vehicles VALUES ('{0}', '{1}', '{2}' , '{3}', '{4}', {5})",
                           temp.ChassisNumber, temp.Brand, temp.Type, temp.YearOfManufacture, temp.LicencePlate, temp.OwnerId));

            DBConnection.CloseConnection();

            return result;
        }
        public int UpdateVehicle(Vehicle vehicle, String chassisNumber)
        {
            int result = DBConnection.EditData(string.Format(
                    "UPDATE Vehicles SET ChassisNumber='{0}',Brand='{1}',Type ='{2}',YearOfManufacture='{3}',LicencePlate ='{4}',OwnerId='{5}'" +
                    "WHERE ChassisNumber='" +chassisNumber+ "'", vehicle.ChassisNumber, vehicle.Brand, vehicle.Type, vehicle.YearOfManufacture, vehicle.LicencePlate, vehicle.OwnerId));

            DBConnection.CloseConnection();

            return result;
        }
        public int DeleteVehicle(Vehicle vehicle)
        {

            int result = DBConnection.EditData("DELETE FROM Vehicles WHERE OwnerId=" + vehicle.OwnerId);

            DBConnection.CloseConnection();

            return result;
        }
    }
}