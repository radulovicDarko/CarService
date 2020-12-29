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
    public class OwnerRepository : IOwnerRepository
    {
        public List<Owner> GetAllOwners()
        {
            List<Owner> listToReturn = new List<Owner>();

            SqlDataReader sqlDataReader = DBConnection.GetData("SELECT * FROM Owners");

            while (sqlDataReader.Read())
            {
                Owner temp = new Owner();

                temp.Id = sqlDataReader.GetInt32(0);
                temp.Name = sqlDataReader.GetString(1);
                temp.Surname = sqlDataReader.GetString(2);
                temp.Gender = sqlDataReader.GetString(3);
                temp.PhoneNumber = sqlDataReader.GetString(4);
                temp.Address = sqlDataReader.GetString(5);
                temp.Email = sqlDataReader.GetString(6);

                listToReturn.Add(temp);
            }

            DBConnection.CloseConnection();

            return listToReturn;
        }

        public int InsertOwner(Owner owner)
        {
            int result = DBConnection.EditData(string.Format("INSERT INTO Owners VALUES ('{0}', '{1}', '{2}' , '{3}', '{4}', '{5}')",
                           owner.Name, owner.Surname, owner.Gender, owner.PhoneNumber, owner.Address, owner.Email));

            DBConnection.CloseConnection();

            return result;
        }

        public int UpdateOwner(Owner owner)
        {
            int result = DBConnection.EditData(string.Format(
                    "UPDATE Owners SET Name='{0}',Surname='{1}',Gender ='{2}',MobilePhone='{3}',Address ='{4}',Email='{5}'" +
                    "WHERE Id='" +owner.Id+"'", owner.Name, owner.Surname, owner.Gender, owner.PhoneNumber, owner.Address, owner.Email));

            DBConnection.CloseConnection();

            return result;
        }

        public int DeleteOwner(Owner owner)
        {
            var result = DBConnection.EditData("DELETE FROM Owners WHERE Id=" + owner.Id);

            DBConnection.CloseConnection();

            return result;
        }


    }
}

