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
    public partial class CarInspections : System.Web.UI.Page
    {
        private readonly IRepairOrderBusiness _repairOrderBusiness;
        private readonly IOwnerBusiness _ownerBusiness;
        private readonly IVehicleBusiness _vehicleBusiness;
        public CarInspections() { }
        public CarInspections(IRepairOrderBusiness repairOrderBusiness, IOwnerBusiness ownerBusiness, IVehicleBusiness vehicleBusiness)
        {
            this._ownerBusiness = ownerBusiness;
            this._vehicleBusiness = vehicleBusiness;
            this._repairOrderBusiness = repairOrderBusiness;
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            RefreshData();
            ButtonNewRepairOrder.Click += new EventHandler(this.ButtonNewRepairOrder_Click);
            ButtonUpdateRepairOrder.Click += new EventHandler(this.ButtonUpdateRepairOrder_Click);
            ButtonDeleteRepairOrder.Click += new EventHandler(this.ButtonDeleteRepairOrder_Click);
            ButtonCarInspectionHistory.Click += new EventHandler(this.ButtonCarInspectionHistory_Click);
        }
        private void RefreshData()
        {
            List<RepairOrder> repairOrders = _repairOrderBusiness.getActiveRepairOrders();

            ListBoxActiveCarInspections.Items.Clear();

            if (repairOrders.Count == 0)
                ListBoxActiveCarInspections.Items.Add("No active car inspections");

            foreach (RepairOrder repairOrder in repairOrders)
                if (!repairOrder.RepairStatus)
                    ListBoxActiveCarInspections.Items.Add("ID: " + repairOrder.Id + ". Date of receipt => " + repairOrder.DateOfReceipt + " Description => " + repairOrder.Description + " Price => " + repairOrder.Price + " Chassis number: " + repairOrder.VehicleId);
        }
        private void ButtonNewRepairOrder_Click(Object sender, EventArgs e)
        {
            Response.Redirect("~/NewRepairOrder.aspx");
        }
        private void ButtonUpdateRepairOrder_Click(Object sender, EventArgs e)
        {
            Response.Redirect("~/UpdateRepairOrder.aspx");
        }
        private void ButtonDeleteRepairOrder_Click(Object sender, EventArgs e)
        {
            Response.Redirect("~/DeleteRepairOrder.aspx");
        }
        private void ButtonCarInspectionHistory_Click(Object sender, EventArgs e)
        {
            Response.Redirect("~/CarInspectionHistory.aspx");
        }
    }
}