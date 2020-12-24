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
    public class VehicleBusiness : IVehicleBusiness
    {
        private readonly IVehicleRepository vehicleRepository;

        public VehicleBusiness(IVehicleRepository _vehicleRepository)
        {
            this.vehicleRepository = _vehicleRepository;
        }


        public List<Vehicle> getAllVehicles()
        {
            return this.vehicleRepository.GetAllVehicles();
        }
        public int insertVehicle(Vehicle temp)
        {
            return this.vehicleRepository.InsertVehicle(temp);
        }
        public int updateVehicle(Vehicle vehicle)
        {
            return this.vehicleRepository.UpdateVehicle(vehicle);
        }
        public int deleteVehicle(Owner owner)
        {
            return this.vehicleRepository.DeleteVehicle(owner);
        }
    }
}