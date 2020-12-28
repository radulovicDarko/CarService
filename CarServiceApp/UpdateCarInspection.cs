﻿using Shared.Interfaces.Business;
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
    public partial class UpdateCarInspection : Form
    {
        private readonly IRepairOrderBusiness _repairOrderBusiness;
        private readonly IVehicleBusiness _vehicleBusiness;
        private readonly IOwnerBusiness _ownerBusiness;
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
                int id = UpdateCarInspectionInfo.id;

                Vehicle vehicle = new Vehicle();
                RepairOrder temp = _repairOrderBusiness.getRepairOrderByID(id);

                vehicle.OwnerId = _vehicleBusiness.getVehicleByID(temp.VehicleId).OwnerId;
                vehicle.ChassisNumber = textBoxChassisNumber.Text;
                vehicle.Brand = textBoxBrand.Text;
                vehicle.Type = textBoxType.Text;
                vehicle.YearOfManufacture = Convert.ToInt32(textBoxYearOfManufacture.Text);
                vehicle.LicencePlate = textBoxLicencePlate.Text;

                int resultUpdateVehicle = _vehicleBusiness.updateVehicle(vehicle, temp.VehicleId);

                RepairOrder repairOrder = new RepairOrder();

                repairOrder.DateOfReceipt = DateTime.Now.ToString();
                repairOrder.Description = textBoxMalfunctionDescription.Text;
                repairOrder.Price = Convert.ToDecimal(textBoxRepairPrice.Text);
                repairOrder.VehicleId = textBoxChassisNumber.Text;

                int resultUpdateRepairOrder = _repairOrderBusiness.updateRepairOrder(repairOrder, id);

                if (resultUpdateRepairOrder != 0 && resultUpdateVehicle != 0) { 
                    MessageBox.Show("Successfully inserted data!", "Success");
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
            comboBoxOwners.SelectedIndex = 0;
        }

        private void UpdateCarInspection_Load(object sender, EventArgs e)
        {
            RefreshData();
        }

        private void buttonAddOwner_Click(object sender, EventArgs e)
        {
            AddOwner addOwner = new AddOwner(_ownerBusiness);
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
