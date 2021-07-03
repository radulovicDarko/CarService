using System;
using System.Collections.Generic;
using BusinessLayer;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Shared.Interfaces.Repository;
using Shared.Models;

namespace BusinessLayerTests
{
    [TestClass]
    public class RepairOrderBusinessTests
    {
        [TestMethod]
        public void IsgetAllRepairOrdersOK()
        {
            var mockRepairOrderRepository = new Mock<IRepairOrderRepository>();

            List<RepairOrder> listOfRepairOrders = new List<RepairOrder>();
            listOfRepairOrders.Add(new RepairOrder
            {
                DateOfReceipt = "22/5/2020",
                Description = "Zamena bos pumpe.",
                Price = 200.5m,
                RepairStatus = true
            });

            listOfRepairOrders.Add(new RepairOrder
            {
                DateOfReceipt = "07/5/2020",
                Description = "Zamena auspuha.",
                Price = 35.5m,
                RepairStatus = true
            });

            listOfRepairOrders.Add(new RepairOrder
            {
                DateOfReceipt = "01/9/2020",
                Description = "Veliki servis.",
                Price = 15000.5m,
                RepairStatus = true
            });

            mockRepairOrderRepository.Setup(x => x.GetAllRepairOrders()).Returns(listOfRepairOrders);

            var repairOrderBusiness = new RepairOrderBusiness(mockRepairOrderRepository.Object);

            //Act
            var result = repairOrderBusiness.getAllRepairOrders();

            //Assert
            Assert.AreEqual(3, result.Count);
        }

        [TestMethod]
        public void IsUpdateRepairOrderOK()
        {
            var mockRepairOrderRepository = new Mock<IRepairOrderRepository>();

            List<RepairOrder> listOfRepairOrders = new List<RepairOrder>();
            RepairOrder ro = new RepairOrder() { Id = 1, DateOfReceipt = "22/5/2020", Description = "Zamena bos pumpe.", Price = 200.5m, RepairStatus = true };

            mockRepairOrderRepository.Setup(x => x.UpdateRepairOrder(ro, 1)).Returns(1);

            var repairOrderBusiness = new RepairOrderBusiness(mockRepairOrderRepository.Object);

            //Act
            var result = repairOrderBusiness.updateRepairOrder(ro, 1);

            //Assert
            Assert.AreEqual(1, result);
        }
    }
}