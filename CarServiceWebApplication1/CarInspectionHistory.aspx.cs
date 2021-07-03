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
    public partial class CarInspectionHistory : System.Web.UI.Page
    {
        private readonly IRepairOrderBusiness _repairOrderBusiness;
        public CarInspectionHistory() { }
        public CarInspectionHistory(IRepairOrderBusiness repairOrderBusiness)
        {
            this._repairOrderBusiness = repairOrderBusiness;
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            ButtonClose.Click += new EventHandler(this.ButtonClose_Click);
        
        List<RepairOrder> repairOrders = this._repairOrderBusiness.getAllRepairOrders();

            ListBoxCarInspectionHistory.Items.Clear();

            if (repairOrders.Count == 0)
                ListBoxCarInspectionHistory.Items.Add("No car inspections");
            else
                foreach (RepairOrder repairOrder in repairOrders)
                ListBoxCarInspectionHistory.Items.Add("ID: " + repairOrder.Id + ". Date of receipt => " + repairOrder.DateOfReceipt + " Description => " + repairOrder.Description + " Price => " + repairOrder.Price + " Vehicle ID: " + repairOrder.VehicleId);
        }
        private void ButtonClose_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/CarInspections.aspx");
        }
    }
}