using Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Interfaces.Business
{
    public interface IVehicleBusiness
    {
        List<Vehicle> getAllVehicles();
        int insertVehicle(Vehicle temp);
        int updateVehicle(Vehicle vehicle, String number);
        int deleteVehicle(Vehicle vehicle);
        Vehicle getVehicleByID(string chassisNumber);
        List<Vehicle> getVehiclesByOwnerID(int id);
    }
}