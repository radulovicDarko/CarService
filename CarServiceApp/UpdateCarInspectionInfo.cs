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
    public partial class UpdateCarInspectionInfo : Form
    {
        private readonly IRepairOrderBusiness _repairOrderBusiness;
        private readonly IVehicleBusiness _vehicleBusiness;
        private readonly IOwnerBusiness _ownerBusiness;
        public static int id;
        public UpdateCarInspectionInfo(IRepairOrderBusiness repairOrderBusiness, IVehicleBusiness vehicleBusiness, IOwnerBusiness ownerBusiness)
        {
            this._ownerBusiness = ownerBusiness;
            this._vehicleBusiness = vehicleBusiness;
            this._repairOrderBusiness = repairOrderBusiness;
            InitializeComponent();
        }

        private void UpdateCarInspectionInfo_Load(object sender, EventArgs e)
        {
            RefreshData();
        }

        private void RefreshData()
        {
            List<RepairOrder> repairOrders = _repairOrderBusiness.getAllRepairOrders();

            textBoxInspectionID.Text = "";

            listBoxCarInspections.Items.Clear();

            if (repairOrders.Count == 0)
                listBoxCarInspections.Items.Add("No active car inspections");
            else
                foreach (RepairOrder repairOrder in repairOrders)
                listBoxCarInspections.Items.Add("ID: " + repairOrder.Id + ". Date of receipt => " + repairOrder.DateOfReceipt + " Description => " + repairOrder.Description + " Price => " + repairOrder.Price + " Vehicle ID: " + repairOrder.VehicleId);
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                id = Convert.ToInt32(textBoxInspectionID.Text);

                if (_repairOrderBusiness.getRepairOrderByID(id) != null)
                {
                        UpdateCarInspection updateCarInspection = new UpdateCarInspection(_repairOrderBusiness, _vehicleBusiness, _ownerBusiness);
                        updateCarInspection.ShowDialog();

                        RefreshData();
                }
            }

            catch
            {
                MessageBox.Show("Make sure you entered correct ID!", "Warning");
            }
        }

        private void buttonCloseInspection_Click(object sender, EventArgs e)
        {
            try
            {
                id = Convert.ToInt32(textBoxInspectionID.Text);

                if (_repairOrderBusiness.getRepairOrderByID(id) != null)
                {
                    var confirmResult = MessageBox.Show("Are you sure to change the status of this inspection to \"Done\"?", "Cancel", MessageBoxButtons.YesNo);

                    if (confirmResult == DialogResult.Yes)
                    {
                        _repairOrderBusiness.updateRepairStatus(id);
                        RefreshData();
                    }
                }
            }

            catch
            {
                MessageBox.Show("Make sure you entered correct ID!", "Warning");
            }
        }
    }
}
