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
    public partial class DeleteOwner : System.Web.UI.Page
    {
        private readonly IOwnerBusiness _ownerBusiness;
        private readonly IVehicleBusiness _vehicleBusiness;
        public static int id;
        public DeleteOwner() { }
        public DeleteOwner(IOwnerBusiness ownerBusiness, IVehicleBusiness vehicleBusiness)
        {
            this._vehicleBusiness = vehicleBusiness;
            this._ownerBusiness= ownerBusiness;
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
                List<Vehicle> vehicles = new List<Vehicle>();
                id = Convert.ToInt32(TextBoxClientID.Text);

                vehicles = this._vehicleBusiness.getVehiclesByOwnerID(id);

                if (_ownerBusiness.getOwnerByID(id) != null)
                {
                    this._ownerBusiness.deleteOwner(_ownerBusiness.getOwnerByID(id));
                 
                    foreach (Vehicle vehicle in vehicles)
                        if (vehicle.OwnerId == id)
                            _vehicleBusiness.deleteVehicle(vehicle);
                
                ClientScript.RegisterStartupScript(this.GetType(), "Success", "alert('Owner has been deleted from database together with all his vehicles!');", true);

                    RefreshData();
                }
                else
                {
                    ClientScript.RegisterStartupScript(this.GetType(), "Warning", "alert('Make sure you entered correct ID!');", true);
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
            List<Owner> owners= _ownerBusiness.getAllOwners();

            ListBoxClientsInfo.Items.Clear();

            foreach (Owner owner in owners)
                ListBoxClientsInfo.Items.Add("ID: " + owner.Id + " Name => " + owner.Name + " Surname => " + owner.Surname + " Gender => " + owner.Gender + " Phone number => " + owner.PhoneNumber + " Address => " + owner.Address + " Email => " + owner.Email);
           
            if (owners.Count == 0)
            {
                ListBoxClientsInfo.Items.Clear();

                ListBoxClientsInfo.Items.Add("No clients in database!");
            }
        }
        private void ButtonClose_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Clients.aspx");
        }
    }
}