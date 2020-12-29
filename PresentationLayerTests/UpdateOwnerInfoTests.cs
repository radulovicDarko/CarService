using System.Collections.Generic;
using System.Windows.Forms;
using CarServiceApp;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Shared.Interfaces.Business;
using Shared.Models;

namespace PresentationLayerTests
{
    [TestClass]
    public class UpdateOwnerInfoTests
    {
        [TestMethod]
        public void IsDataRefreshed()
        {
            //Arrange
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

            listOfOwners.Add(new Owner
            {
                Id = 2,
                Name = "Stefan",
                Surname = "Radkonjac",
                Gender = "Male",
                PhoneNumber = "0658956324",
                Address = "ivanjica",
                Email = "stefan.rakonjac@gmail.com"
            });

            var mockOwnerBusiness = new Mock<IOwnerBusiness>();

            mockOwnerBusiness.Setup(x => x.getAllOwners()).Returns(listOfOwners);

            var UpdateOwnerInfo = new UpdateOwnerInfo (mockOwnerBusiness.Object);

            //Act
            PrivateObject obj = new PrivateObject(UpdateOwnerInfo);
            obj.Invoke("RefreshData");
            ListBox listBoxClients = (ListBox)obj.GetFieldOrProperty("listBoxClients");

            //Assert
            Assert.AreEqual(4, listBoxClients.Items.Count);

        }
    }
}
