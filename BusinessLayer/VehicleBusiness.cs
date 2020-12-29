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
        public int updateVehicle(Vehicle vehicle, String number)
        {
            return this.vehicleRepository.UpdateVehicle(vehicle,number);
        }
        public int deleteVehicle(Vehicle vehicle)
        {
            return this.vehicleRepository.DeleteVehicle(vehicle);
        }
        public Vehicle getVehicleByID(string chassisNumber) 
        {
            return this.vehicleRepository.GetAllVehicles().Where(v => v.ChassisNumber == chassisNumber).FirstOrDefault();
        }
        public List<Vehicle> getVehiclesByOwnerID(int id) 
        {
            return this.vehicleRepository.GetAllVehicles().Where(v => v.OwnerId == id).ToList<Vehicle>();
        }
    }
}