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
    public partial class UpdateRepairOrder : System.Web.UI.Page
    {
        private readonly IRepairOrderBusiness _repairOrderBusiness;
        private readonly IVehicleBusiness _vehicleBusiness;
        private readonly IOwnerBusiness _ownerBusiness;
        public static int id;
        public UpdateRepairOrder() { }
        public UpdateRepairOrder(IRepairOrderBusiness repairOrderBusiness, IVehicleBusiness vehicleBusiness, IOwnerBusiness ownerBusiness)
        {
            this._ownerBusiness = ownerBusiness;
            this._vehicleBusiness = vehicleBusiness;
            this._repairOrderBusiness = repairOrderBusiness;
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            RefreshData();
            ButtonUpdate.Click += new EventHandler(this.ButtonUpdate_Click);
            ButtonCloseInspection.Click += new EventHandler(this.ButtonCloseInspection_Click);
            ButtonClose.Click += new EventHandler(this.ButtonClose_Click);
        }
        private void RefreshData()
        {
            List<RepairOrder> repairOrders = _repairOrderBusiness.getAllRepairOrders();

            ListBoxActiveCarInspections.Items.Clear();

            if (repairOrders.Count == 0)
                ListBoxActiveCarInspections.Items.Add("No active car inspections");

            foreach (RepairOrder repairOrder in repairOrders)
                if(!repairOrder.RepairStatus)
                    ListBoxActiveCarInspections.Items.Add("ID: " + repairOrder.Id + ". Date of receipt => " + repairOrder.DateOfReceipt + " Description => " + repairOrder.Description + " Price => " + repairOrder.Price + " Vehicle ID: " + repairOrder.VehicleId);
        }
        private void ButtonUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                id = Convert.ToInt32(TextBoxID.Text);

                if (_repairOrderBusiness.getRepairOrderByID(id) != null)
                {
                    Response.Redirect("~/UpdateRepairOrderInfo.aspx");
                }
            }

            catch
            {
                ClientScript.RegisterStartupScript(this.GetType(), "Warning", "alert('Make sure you entered correct ID!');", true);
            }
        }
        private void ButtonCloseInspection_Click(object sender, EventArgs e)
        {
            try
            {
                id = Convert.ToInt32(TextBoxID.Text);

                if (_repairOrderBusiness.getRepairOrderByID(id) != null)
                {
                        _repairOrderBusiness.updateRepairStatus(id);
                        RefreshData();
                }
            }

            catch
            {
                ClientScript.RegisterStartupScript(this.GetType(), "Warning", "alert('Make sure you entered correct ID!');", true);
            }
        }
        private void ButtonClose_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/CarInspections.aspx");
        }

        protected void ButtonUpdate_Click1(object sender, EventArgs e)
        {

        }
    }
}