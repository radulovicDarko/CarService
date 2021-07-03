using Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Interfaces.Repository
{
    public interface IVehicleRepository
    {
        List<Vehicle> GetAllVehicles();
        int InsertVehicle(Vehicle temp);
        int UpdateVehicle(Vehicle vehicle, String number);
        int DeleteVehicle(Vehicle vehicle);
    }
}