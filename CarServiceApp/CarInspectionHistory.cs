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
    public partial class CarInspectionHistory : Form
    {
        private readonly IRepairOrderBusiness _repairOrderBusiness;
        public CarInspectionHistory(IRepairOrderBusiness repairOrderBusiness)
        {
            this._repairOrderBusiness = repairOrderBusiness;
            InitializeComponent();
        }

        private void CarInspectionHistory_Load(object sender, EventArgs e)
        {
            List<RepairOrder> repairOrders = this._repairOrderBusiness.getAllRepairOrders();

            listBoxCarInspectionHistory.Items.Clear();

            if (repairOrders.Count == 0)
                listBoxCarInspectionHistory.Items.Add("No car inspections");
            else
                foreach (RepairOrder repairOrder in repairOrders)
                listBoxCarInspectionHistory.Items.Add("ID: " + repairOrder.Id + ". Date of receipt => " + repairOrder.DateOfReceipt + " Description => " + repairOrder.Description+" Price => " + repairOrder.Price + " Vehicle ID: " + repairOrder.VehicleId);
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Are you sure to close this window?", "Cancel", MessageBoxButtons.YesNo);

            if (confirmResult == DialogResult.Yes)
                this.Dispose();
        }
    }
}
