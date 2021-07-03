using Shared.Interfaces.Business;
using Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CarServiceWebApplication1
{
    public partial class UpdateRepairOrderInfo : System.Web.UI.Page
    {
        private readonly IOwnerBusiness _ownerBusiness;
        private readonly IVehicleBusiness _vehicleBusiness;
        private readonly IRepairOrderBusiness _repairOrderBusiness;
        private String chassisNumberRegex = "[0-9a-zA-Z]{13}";
        private String licencePlateRegex = "[a-zA-Z][a-zA-Z][0-9][0-9][0-9][a-zA-Z][a-zA-Z]";
        private bool valid = false;
        public UpdateRepairOrderInfo() { }
        public UpdateRepairOrderInfo(IOwnerBusiness ownerBusiness, IVehicleBusiness vehicleBusiness, IRepairOrderBusiness repairOrderBusiness)
        {
            this._repairOrderBusiness = repairOrderBusiness;
            this._ownerBusiness = ownerBusiness;
            this._vehicleBusiness = vehicleBusiness;
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            RefreshData();
            ButtonAddOwner.Click += new EventHandler(this.ButtonAddOwner_Click);
            ButtonClose.Click += new EventHandler(this.ButtonClose_Click);
            ButtonUpdateRepairOrder.Click += new EventHandler(this.ButtonUpdateRepairOrder_Click);
        }
        private void RefreshData()
        {
            List<Owner> owners = _ownerBusiness.getAllOwners();

            DropDownListOwner.Items.Clear();

            foreach (Owner o in owners)
                DropDownListOwner.Items.Add(o.Name + " " + o.Surname);
        }
        private void ButtonAddOwner_Click(Object sender, EventArgs e)
        {
            Response.Redirect("~/AddOwner.aspx");
        }
        private void ButtonClose_Click(Object sender, EventArgs e)
        {
            Response.Redirect("~/CarInspections.aspx");
        }
        private void ButtonUpdateRepairOrder_Click(Object sender, EventArgs e)
        { 
            try
            {
                int resultUpdateVehicle = 0;
                int resultUpdateRepairOrder = 0;

                if (!Regex.Match(TextBoxChassisNumber.Text, chassisNumberRegex).Success)
                {
                    LabelChassisNumberRegex.Text = "Enter valid chassis number!";
                    valid = false;
                }
                else
                {
                    LabelChassisNumberRegex.Text = "";
                    valid = true;
                }

                if (!Regex.Match(TextBoxLicencePlate.Text, licencePlateRegex).Success)
                {
                    LabelLicencePlateRegex.Text = "Enter valid licence plate number!";
                    valid = false;
                }
                else
                {
                    LabelLicencePlateRegex.Text = "";
                    valid = true;
                }
                int id = UpdateRepairOrder.id;

                Vehicle vehicle = new Vehicle();
                RepairOrder temp = _repairOrderBusiness.getRepairOrderByID(id);

                vehicle.OwnerId = _vehicleBusiness.getVehicleByID(temp.VehicleId).OwnerId;
                vehicle.ChassisNumber = TextBoxChassisNumber.Text;
                vehicle.Brand = TextBoxBrand.Text;
                vehicle.Type = TextBoxType.Text;
                vehicle.YearOfManufacture = Convert.ToInt32(TextBoxYearOfManufacture.Text);
                vehicle.LicencePlate = TextBoxLicencePlate.Text;

                resultUpdateVehicle = _vehicleBusiness.updateVehicle(vehicle, temp.VehicleId);

                RepairOrder repairOrder = new RepairOrder();

                repairOrder.DateOfReceipt = DateTime.Now.ToString();
                repairOrder.Description = TextBoxMalfunctionDescription.Text;
                repairOrder.Price = Convert.ToDecimal(TextBoxRepairPrice.Text);
                repairOrder.VehicleId = TextBoxChassisNumber.Text;

                resultUpdateRepairOrder = _repairOrderBusiness.updateRepairOrder(repairOrder, id);

                if (resultUpdateRepairOrder != 0 && resultUpdateVehicle != 0)
                {
                    ClientScript.RegisterStartupScript(this.GetType(), "Success", "alert('Successfully updated data!');", true);
                    resetData();
                }
            }
            catch
            {
                ClientScript.RegisterStartupScript(this.GetType(), "Warning", "alert('Make sure you filled up all the gaps correctly!');", true);
            }
        }
        private void resetData()
        {
            TextBoxChassisNumber.Text = "";
            TextBoxBrand.Text = "";
            TextBoxType.Text = "";
            TextBoxLicencePlate.Text = "";
            TextBoxMalfunctionDescription.Text = "";
            TextBoxRepairPrice.Text = "";
            TextBoxYearOfManufacture.Text = "";
            DropDownListOwner.SelectedIndex = 0;
        }
    }
}