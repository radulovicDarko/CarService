using Shared.Interfaces.Business;
using Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CarServiceWebApplication1
{
    public partial class DeleteRepairOrder : System.Web.UI.Page
    {
        private readonly IRepairOrderBusiness _repairOrderBusiness;
        public static int id;
        public DeleteRepairOrder() { }
        public DeleteRepairOrder(IRepairOrderBusiness repairOrderBusiness)
        {
            this._repairOrderBusiness = repairOrderBusiness;
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            RefreshData();
            ButtonDeleteInfo.Click += new EventHandler(this.ButtonDeleteInfo_Click);
            ButtonClose.Click += new EventHandler(this.ButtonClose_Click);
        }
        private void ButtonDeleteInfo_Click(object sender, EventArgs e)
        {
            try
            {
                id = Convert.ToInt32(TextBoxCarInspectionsID.Text);

                if (_repairOrderBusiness.getRepairOrderByID(id) != null)
                {
                    this._repairOrderBusiness.deleteRepairOrder(id);
                    ClientScript.RegisterStartupScript(this.GetType(), "Success", "alert('Repair order has been deleted from database!');", true);

                    RefreshData();
                }
            }

            catch
            {
                ClientScript.RegisterStartupScript(this.GetType(), "Warning", "alert('Make sure you entered correct ID!');", true);
            }

            RefreshData();
        }
        private void RefreshData()
        {
            List<RepairOrder> repairOrders = _repairOrderBusiness.getAllRepairOrders();

            ListBoxActive.Items.Clear();

            if (repairOrders.Count == 0)
                ListBoxActive.Items.Add("No active car inspections");

            foreach (RepairOrder repairOrder in repairOrders)
                ListBoxActive.Items.Add("ID: " + repairOrder.Id + ". Date of receipt => " + repairOrder.DateOfReceipt + " Description => " + repairOrder.Description + " Price => " + repairOrder.Price + " Vehicle ID: " + repairOrder.VehicleId);
        }
        private void ButtonClose_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/CarInspections.aspx");
        }
    }
}