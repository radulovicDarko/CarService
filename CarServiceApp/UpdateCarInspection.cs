using Shared.Interfaces.Business;
using Shared.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarServiceApp
{
    public partial class UpdateCarInspection : Form
    {
        private readonly IRepairOrderBusiness _repairOrderBusiness;
        private readonly IVehicleBusiness _vehicleBusiness;
        private readonly IOwnerBusiness _ownerBusiness; 
        private String chassisNumberRegex = "[0-9a-zA-Z]{13}";
        private String licencePlateRegex = "[a-zA-Z][a-zA-Z][0-9][0-9][0-9][a-zA-Z][a-zA-Z]";
        private bool valid = false;
        public UpdateCarInspection(IRepairOrderBusiness repairOrderBusiness, IVehicleBusiness vehicleBusiness, IOwnerBusiness ownerBusiness)
        {
            this._ownerBusiness = ownerBusiness;
            this._vehicleBusiness = vehicleBusiness;
            this._repairOrderBusiness = repairOrderBusiness;
            InitializeComponent();
        }

        private void resetData()
        {
            textBoxBrand.Text = "";
            textBoxChassisNumber.Text = "";
            textBoxLicencePlate.Text = "";
            textBoxMalfunctionDescription.Text = "";
            textBoxRepairPrice.Text = "";
            textBoxType.Text = "";
            textBoxYearOfManufacture.Text = "";
        }

        private void buttonUpdateInfo_Click(object sender, EventArgs e)
        {
            try
            {
                int resultUpdateVehicle = 0;
                int resultUpdateRepairOrder = 0;

                if (!Regex.Match(textBoxChassisNumber.Text, chassisNumberRegex).Success)
                {
                    labelEmailRegex.Text = "Enter valid chassis number!";
                    valid = false;
                }
                else
                {
                    labelEmailRegex.Text = "";
                    valid = true;
                }

                if (!Regex.Match(textBoxLicencePlate.Text, licencePlateRegex).Success)
                {
                    labelLicencePlateRegex.Text = "Enter valid licence plate number!";
                    valid = false;
                }
                else
                {
                    labelLicencePlateRegex.Text = "";
                    valid = true;
                }

                int id = UpdateCarInspectionInfo.id;

                Vehicle vehicle = new Vehicle();
                RepairOrder temp = _repairOrderBusiness.getRepairOrderByID(id);

                vehicle.OwnerId = _vehicleBusiness.getVehicleByID(temp.VehicleId).OwnerId;
                vehicle.ChassisNumber = textBoxChassisNumber.Text;
                vehicle.Brand = textBoxBrand.Text;
                vehicle.Type = textBoxType.Text;
                vehicle.YearOfManufacture = Convert.ToInt32(textBoxYearOfManufacture.Text);
                vehicle.LicencePlate = textBoxLicencePlate.Text;

                if (valid)
                    resultUpdateVehicle = _vehicleBusiness.updateVehicle(vehicle, temp.VehicleId);

                RepairOrder repairOrder = new RepairOrder();

                repairOrder.DateOfReceipt = DateTime.Now.ToString();
                repairOrder.Description = textBoxMalfunctionDescription.Text;
                repairOrder.Price = Convert.ToDecimal(textBoxRepairPrice.Text);
                repairOrder.VehicleId = textBoxChassisNumber.Text;

                if (valid)
                    resultUpdateRepairOrder = _repairOrderBusiness.updateRepairOrder(repairOrder, id);

                if (resultUpdateRepairOrder != 0 && resultUpdateVehicle != 0) { 
                    MessageBox.Show("Successfully updated data!", "Success");
                    resetData();
            }
            }
            catch
            {
                MessageBox.Show("Make sure you filled up all the gaps correctly!", "Warning");
            }
        }
        

        private void RefreshData() {
            List<Owner> owners = _ownerBusiness.getAllOwners();

            comboBoxOwners.Items.Clear();

            foreach (Owner o in owners)
                comboBoxOwners.Items.Add(o.ToString());
            if(owners.Count != 0)
                comboBoxOwners.SelectedIndex = 0;
        }

        private void UpdateCarInspection_Load(object sender, EventArgs e)
        {
            RefreshData();        
        }
        private void buttonAddOwner_Click(object sender, EventArgs e)
        {
            AddClient addOwner = new AddClient(_ownerBusiness);
            addOwner.ShowDialog();

            RefreshData();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Are you sure to close this window?", "Cancel", MessageBoxButtons.YesNo);

            if (confirmResult == DialogResult.Yes)
                this.Dispose();
        }
    }
}
