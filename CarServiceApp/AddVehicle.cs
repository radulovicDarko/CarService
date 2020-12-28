using Shared.Interfaces.Business;
using Shared.Models;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CarServiceApp
{
    public partial class AddVehicle : Form
    {
        private readonly IOwnerBusiness _ownerBusiness;
        private readonly IVehicleBusiness _vehicleBusiness;
        public AddVehicle(IVehicleBusiness vehicleBusiness, IOwnerBusiness ownerBusiness)
        {
            this._ownerBusiness = ownerBusiness;
            this._vehicleBusiness = vehicleBusiness;
            InitializeComponent();
        }

        private void buttonNewRepairOrder_Click(object sender, EventArgs e)
        {
            List<Owner> owners = new List<Owner>();
            Vehicle vehicle = new Vehicle();

            vehicle.ChassisNumber = textBoxChassisNumber.Text;
            vehicle.Brand = textBoxBrand.Text;
            vehicle.LicencePlate = textBoxLicencePlate.Text;
            vehicle.Type = textBoxType.Text;
            vehicle.YearOfManufacture = Convert.ToInt32(textBoxYearOfManufacture.Text);

            String input = comboBoxOwners.SelectedItem.ToString();

            var array = input.Split(' ');

            foreach (Owner o in owners)
                if (o.Name.Equals(array[0]) && o.Surname.Equals(array[1]))
                    vehicle.OwnerId = o.Id;

            int result =_vehicleBusiness.insertVehicle(vehicle);

            if (result == 0)
                MessageBox.Show("Data is not inserted to database! Try again!", "ERROR");
        }

        private void AddVehicle_Load(object sender, EventArgs e)
        {
            List<Owner> owners = _ownerBusiness.getAllOwners();

            foreach (Owner o in owners)
                comboBoxOwners.Items.Add(o.ToString());
        }
    }
}
