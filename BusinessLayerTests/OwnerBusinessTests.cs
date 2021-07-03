using BusinessLayer;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Shared.Interfaces.Business;
using Shared.Interfaces.Repository;
using Shared.Models;
using System.Collections.Generic;

namespace BusinessLayerTests
{
    [TestClass]
    public class OwnerBusinessTests
    {
        [TestMethod]
        public void IsOwnerInserted()
        {
            //Arrange
            var mockOwnerRepository = new Mock<IOwnerRepository>();
            Owner o = new Owner
            {
                Name = "Marko",
                Surname = "Radulovic",
                Gender = "Male",
                PhoneNumber = "0603025705",
                Address = "Pozega",
                Email = "radulovic.marko1999@gmail.com"
            };
            mockOwnerRepository.Setup(x => x.InsertOwner(o)).Returns(1);

            OwnerBusiness ownerBusiness = new OwnerBusiness(mockOwnerRepository.Object);

            //Act
            var result = ownerBusiness.insertOwner(o);

            //Assert
            Assert.AreEqual(1, result);
        }

        [TestMethod]

        public void IsgetOwnerByNameAndSurnameOK()
        {
            //Arrange
            var mockOwnerRepository = new Mock<IOwnerRepository>();
            List<Owner> listOfOwners = new List<Owner>();
            listOfOwners.Add(new Owner
            {
                Id = 3,
                Name = "Marko",
                Surname = "Radulovic",
                Gender = "Male",
                PhoneNumber = "0603025705",
                Address = "Pozega",
                Email = "radulovic.marko1999@gmail.com"
            });


            listOfOwners.Add(new Owner
            {
                Id = 1,
                Name = "Darko",
                Surname = "Radulovic",
                Gender = "Male",
                PhoneNumber = "0603373077",
                Address = "Pozega",
                Email = "darkodarko99@gmail.com"
            });

            listOfOwners.Add(new Owner
            {
                Id = 2,
                Name = "Nikola",
                Surname = "Milakovic",
                Gender = "Male",
                PhoneNumber = "0615847958",
                Address = "Pozega",
                Email = "nikola.milakovic@gmail.com"
            });

            mockOwnerRepository.Setup(x => x.GetAllOwners()).Returns(listOfOwners);

            var ownerBusiness = new OwnerBusiness(mockOwnerRepository.Object);

            //Act
            var result = ownerBusiness.getOwnerByNameAndSurname("Marko", "Radulovic");

            //Assert
            Assert.AreEqual(3, result.Id);
        }

        [TestMethod]

        public void IsOwnerUpdated()
        {
            var mockOwnerRepository = new Mock<IOwnerRepository>();

            Owner o = new Owner() { Id = 3, Name = "Marko", Surname = "Radulovic", Gender = "Male", PhoneNumber = "0603025705", Address = "Pozega", Email = "radul@gmail.com" };

            mockOwnerRepository.Setup(x => x.UpdateOwner(o)).Returns(1);

            var ownerBusiness = new OwnerBusiness(mockOwnerRepository.Object);

            //Act
            var result = ownerBusiness.updateOwner(o);

            //Assert
            Assert.AreEqual(1, result);

        }

        [TestMethod]
        public void IsOwnerDeleted()
        {
            var mockOwnerRepository = new Mock<IOwnerRepository>();

            Owner o = new Owner() { Id = 1, Name = "Marko", Surname = "Radulovic", Gender = "Male", PhoneNumber = "0603025705", Address = "Pozega", Email = "radul@gmail.com" };

            mockOwnerRepository.Setup(x => x.DeleteOwner(o)).Returns(1);

            var ownerBusiness = new OwnerBusiness(mockOwnerRepository.Object);

            //Act
            var result = ownerBusiness.deleteOwner(o);

            //Assert
            Assert.AreEqual(1, result);

        }

        [TestMethod]
        public void IsGetAllOwnersOK()
        {
            var mockOwnerRepository = new Mock<IOwnerRepository>();

            List<Owner> listOfOwners = new List<Owner>();
            listOfOwners.Add(new Owner
            {
                Id = 3,
                Name = "Marko",
                Surname = "Radulovic",
                Gender = "Male",
                PhoneNumber = "0603025705",
                Address = "Pozega",
                Email = "radulovic.marko1999@gmail.com"
            });


            listOfOwners.Add(new Owner
            {
                Id = 1,
                Name = "Darko",
                Surname = "Radulovic",
                Gender = "Male",
                PhoneNumber = "0603373077",
                Address = "Pozega",
                Email = "darkodarko99@gmail.com"
            });

            listOfOwners.Add(new Owner
            {
                Id = 2,
                Name = "Nikola",
                Surname = "Milakovic",
                Gender = "Male",
                PhoneNumber = "0615847958",
                Address = "Pozega",
                Email = "nikola.milakovic@gmail.com"
            });

            mockOwnerRepository.Setup(x => x.GetAllOwners()).Returns(listOfOwners);

            var ownerBusiness = new OwnerBusiness(mockOwnerRepository.Object);

            //Act
            var result = ownerBusiness.getAllOwners();

            //Assert
            Assert.AreEqual(3, result.Count);

        }
        [TestMethod]
        public void IsGetOwnerById()
        {
            var mockOwnerRepository = new Mock<IOwnerRepository>();

            List<Owner> listOfOwners = new List<Owner>();
            listOfOwners.Add(new Owner
            {
                Id = 3,
                Name = "Marko",
                Surname = "Radulovic",
                Gender = "Male",
                PhoneNumber = "0603025705",
                Address = "Pozega",
                Email = "radulovic.marko1999@gmail.com"
            });


            listOfOwners.Add(new Owner
            {
                Id = 1,
                Name = "Darko",
                Surname = "Radulovic",
                Gender = "Male",
                PhoneNumber = "0603373077",
                Address = "Pozega",
                Email = "darkodarko99@gmail.com"
            });

            listOfOwners.Add(new Owner
            {
                Id = 2,
                Name = "Nikola",
                Surname = "Milakovic",
                Gender = "Male",
                PhoneNumber = "0615847958",
                Address = "Pozega",
                Email = "nikola.milakovic@gmail.com"
            });

            mockOwnerRepository.Setup(x => x.GetAllOwners()).Returns(listOfOwners);

            var ownerBusiness = new OwnerBusiness(mockOwnerRepository.Object);

            //Act
            var result = ownerBusiness.getOwnerByID(2);

            //Assert
            Assert.AreEqual("Nikola", result.Name);
        }

    }
}