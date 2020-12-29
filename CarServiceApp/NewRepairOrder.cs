using Shared.Interfaces.Business;
using Shared.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarServiceApp
{
    public partial class NewRepairOrder : Form
    {
        private readonly IOwnerBusiness _ownerBusiness;
        private readonly IVehicleBusiness _vehicleBusiness;
        private readonly IRepairOrderBusiness _repairOrderBusiness;
        public NewRepairOrder(IOwnerBusiness ownerBusiness, IVehicleBusiness vehicleBusiness, IRepairOrderBusiness repairOrderBusiness)
        {
            this._repairOrderBusiness = repairOrderBusiness;
            this._ownerBusiness = ownerBusiness;
            this._vehicleBusiness = vehicleBusiness;
            InitializeComponent();
        }

        private void NewCarInspection_Load(object sender, EventArgs e)
        {
            RefreshData();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Are you sure to close this window?", "Cancel", MessageBoxButtons.YesNo);

            if (confirmResult == DialogResult.Yes)
                this.Dispose();
        }

        private void resetData()
        {
            textBoxChassisNumber.Text = "";
            textBoxBrand.Text = "";
            textBoxType.Text = "";
            textBoxLicencePlate.Text = "";
            textBoxMalfunctionDescription.Text = "";
            textBoxRepairPrice.Text = "";
            textBoxYearOfManufacture.Text = "";
            comboBoxOwners.SelectedIndex = 0;
        }

        private void buttonNewRepairOrder_Click(object sender, EventArgs e)
        {
            try
            {
                RepairOrder repairOrder = new RepairOrder();
                
                repairOrder.DateOfReceipt = DateTime.Now.ToString();
                repairOrder.Description = textBoxMalfunctionDescription.Text;
                repairOrder.Price = Convert.ToDecimal(textBoxRepairPrice.Text);
                repairOrder.VehicleId = textBoxChassisNumber.Text;
                repairOrder.RepairStatus = false;
              
                int resultInsertRepairOrder = _repairOrderBusiness.insertRepairOrder(repairOrder);
              
                Vehicle vehicle = new Vehicle();
               
                vehicle.ChassisNumber = textBoxChassisNumber.Text;
                vehicle.Brand = textBoxBrand.Text;
                vehicle.Type = textBoxType.Text;
                vehicle.YearOfManufacture = Convert.ToInt32(textBoxYearOfManufacture.Text);
                vehicle.LicencePlate = textBoxLicencePlate.Text;
                
                var array = comboBoxOwners.SelectedItem.ToString().Split(' ');

                String name = array[0];
                String surname = array[1];

                vehicle.OwnerId = _ownerBusiness.getOwnerByNameAndSurname(name, surname).Id;

                int resultInsertVehicle = _vehicleBusiness.insertVehicle(vehicle);
                          
               if (resultInsertRepairOrder != 0 && resultInsertVehicle != 0)
                   MessageBox.Show("Successfully inserted data!", "Success");

                resetData();
            }
            catch(Exception ex) 
            {
                MessageBox.Show("Make sure you filled up all the gaps correctly!","Warning");
                Console.WriteLine(ex.StackTrace);
            }
        }

        private void RefreshData()
        {
            List<Owner> owners = _ownerBusiness.getAllOwners();

            comboBoxOwners.Items.Clear();

            foreach (Owner o in owners)
                comboBoxOwners.Items.Add(o.Name + " " + o.Surname);
            
        }

        private void buttonAddOwner_Click(object sender, EventArgs e)
        {
            AddClient addOwner = new AddClient(_ownerBusiness);
            addOwner.ShowDialog();

            RefreshData();
        }
    }
}
