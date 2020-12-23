using Shared.Interfaces.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class VehicleBusiness : IVehicleRepository
    {
        private readonly IVehicleRepository vehicleRepository;

        public VehicleBusiness(IVehicleRepository _vehicleRepository)
        {
            this.vehicleRepository = _vehicleRepository;
        } 
    }
}
