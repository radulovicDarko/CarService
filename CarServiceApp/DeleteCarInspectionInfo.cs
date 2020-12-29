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
    public partial class DeleteCarInspectionInfo : Form
    {
        private readonly IRepairOrderBusiness _repairOrderBusiness;
        public static int id;
        public DeleteCarInspectionInfo(IRepairOrderBusiness repairOrderBusiness)
        {
            this._repairOrderBusiness = repairOrderBusiness;
            InitializeComponent();
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                id = Convert.ToInt32(textBoxInspectionID.Text);

                if (_repairOrderBusiness.getRepairOrderByID(id) != null)
                {
                    var confirmResult = MessageBox.Show("Are you sure to delete this repair order?", "Cancel", MessageBoxButtons.YesNo);

                    if (confirmResult == DialogResult.Yes)
                        this._repairOrderBusiness.deleteRepairOrder(id);

                    RefreshData();
                }
            }

            catch
            {
                MessageBox.Show("Make sure you entered correct ID!", "Warning");
            }

            RefreshData();
        }

        private void RefreshData()
        {
            List<RepairOrder> repairOrders = _repairOrderBusiness.getAllRepairOrders();

            textBoxInspectionID.Text = "";

            listBoxActiveCarInspections.Items.Clear();

            if (repairOrders.Count == 0)
                listBoxActiveCarInspections.Items.Add("No active car inspections");
            else
                foreach (RepairOrder repairOrder in repairOrders)
                    if(!repairOrder.RepairStatus)
                        listBoxActiveCarInspections.Items.Add("ID: " + repairOrder.Id + ". Date of receipt => " + repairOrder.DateOfReceipt + " Description => " + repairOrder.Description + " Price => " + repairOrder.Price + " Vehicle ID: " + repairOrder.VehicleId);
        }

        private void DeleteCarInspectionInfo_Load(object sender, EventArgs e)
        {
            RefreshData();
        }
    }
}
