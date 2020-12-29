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
    public partial class NewRepairOrder : System.Web.UI.Page
    {
        private readonly IOwnerBusiness _ownerBusiness;
        private readonly IVehicleBusiness _vehicleBusiness;
        private readonly IRepairOrderBusiness _repairOrderBusiness; 
        private String chassisNumberRegex = "[0-9a-zA-Z]{13}";
        private String licencePlateRegex = "[a-zA-Z][a-zA-Z][0-9][0-9][0-9][a-zA-Z][a-zA-Z]";
        private bool valid = false;
        public NewRepairOrder() { }
        public NewRepairOrder(IOwnerBusiness ownerBusiness, IVehicleBusiness vehicleBusiness, IRepairOrderBusiness repairOrderBusiness)
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
            ButtonCreateNewRepairOrder.Click += new EventHandler(this.ButtonCreateNewRepairOrder_Click);
        }
        private void RefreshData()
        {
            List<Owner> owners = _ownerBusiness.getAllOwners();

            DropDownListOwner.Items.Clear();

            foreach (Owner o in owners)
                DropDownListOwner.Items.Add(o.Name + " " + o.Surname);
        }
        private void ButtonAddOwner_Click(Object sender,EventArgs e)
        {
            Response.Redirect("~/AddOwner.aspx");
        }
        private void ButtonClose_Click(Object sender, EventArgs e)
        {
            Response.Redirect("~/CarInspections.aspx");
        }   
        private void ButtonCreateNewRepairOrder_Click(Object sender, EventArgs e)
        {
            try
            {
                int resultInsertVehicle = 0;
                int resultInsertRepairOrder = 0;

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
                RepairOrder repairOrder = new RepairOrder();

                repairOrder.DateOfReceipt = DateTime.Now.ToString();
                repairOrder.Description = TextBoxMalfunctionDescription.Text;
                repairOrder.Price = Convert.ToDecimal(TextBoxRepairPrice.Text);
                repairOrder.VehicleId = TextBoxChassisNumber.Text;
                repairOrder.RepairStatus = false;

             

                Vehicle vehicle = new Vehicle();

                vehicle.ChassisNumber = TextBoxChassisNumber.Text;
                vehicle.Brand = TextBoxBrand.Text;
                vehicle.Type = TextBoxType.Text;
                vehicle.YearOfManufacture = Convert.ToInt32(TextBoxYearOfManufacture.Text);
                vehicle.LicencePlate = TextBoxLicencePlate.Text;

                var array = DropDownListOwner.SelectedItem.ToString().Split(' ');

                String name = array[0];
                String surname = array[1];

                vehicle.OwnerId = _ownerBusiness.getOwnerByNameAndSurname(name, surname).Id;

                if (valid)
                    resultInsertRepairOrder = _repairOrderBusiness.insertRepairOrder(repairOrder);

                if (valid)
                    resultInsertVehicle = _vehicleBusiness.insertVehicle(vehicle);

                if (resultInsertRepairOrder != 0 && resultInsertVehicle != 0)
                { 
                    ClientScript.RegisterStartupScript(this.GetType(), "Success", "alert('Successfully inserted data!');", true);
                    resetData();
                }

            }
            catch (Exception ex)
            {
                ClientScript.RegisterStartupScript(this.GetType(), "Warning", "alert('Make sure you filled up all the gaps correctly!');", true);
                Console.WriteLine(ex.StackTrace);
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