using BusinessLayer;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Shared.Interfaces.Repository;
using Shared.Models;
using System.Collections.Generic;

namespace BusinessLayerTests
{
    [TestClass]
    public class VehicleBusinessTests
    {
        [TestMethod]
        public void IsVehicleInserted()
        {
            //Arrange
            var mockVehicleRepository = new Mock<IVehicleRepository>();
            Vehicle v = new Vehicle
            {
                ChassisNumber = "02131248",
                Brand = "Ford",
                Type = "Cabriolet",
                YearOfManufacture = 2009,
                LicencePlate = "PZ-058-SW",
            };
            mockVehicleRepository.Setup(x => x.InsertVehicle(v)).Returns(1);

            VehicleBusiness vehicleBusiness = new VehicleBusiness(mockVehicleRepository.Object);

            //Act
            var result = vehicleBusiness.insertVehicle(v);

            //Assert
            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void IsgetVehicleByIDOK()
        {
            //Arrange
            var mockVehicleRepository = new Mock<IVehicleRepository>();
            List<Vehicle> listOfVehicles = new List<Vehicle>();
            listOfVehicles.Add(new Vehicle
            {
                ChassisNumber = "02131248",
                Brand = "Ford",
                Type = "Cabriolet",
                YearOfManufacture = 2009,
                LicencePlate = "PZ-058-SW",
            });

            listOfVehicles.Add(new Vehicle
            {
                ChassisNumber = "412318",
                Brand = "BMW",
                Type = "Sportscar",
                YearOfManufacture = 2018,
                LicencePlate = "GH-849-SW",
            });

            listOfVehicles.Add(new Vehicle
            {
                ChassisNumber = "987795",
                Brand = "Audi",
                Type = "Racing car",
                YearOfManufacture = 2020,
                LicencePlate = "AS-122-ER",
            });

            mockVehicleRepository.Setup(x => x.GetAllVehicles()).Returns(listOfVehicles);

            VehicleBusiness vehicleBusiness = new VehicleBusiness(mockVehicleRepository.Object);

            //Act
            var result = vehicleBusiness.getVehicleByID("987795");

            //Assert
            Assert.AreEqual(result.Brand, "Audi");
        }

    }
}