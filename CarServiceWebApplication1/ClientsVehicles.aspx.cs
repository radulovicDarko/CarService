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
    public partial class ClientsVehicles : System.Web.UI.Page
    {
        private readonly IVehicleBusiness _vehicleBusiness;
        private readonly IOwnerBusiness _ownerBusiness;
        private static int id;
        public ClientsVehicles() { }
        public ClientsVehicles(IVehicleBusiness vehicleBusiness, IOwnerBusiness ownerBusiness)
        {
            this._ownerBusiness = ownerBusiness;
            this._vehicleBusiness = vehicleBusiness;
        }
        private void RefreshData()
        {
            ListBoxClientsVehicles.Items.Clear();
            ListBoxClientsVehicles.Items.Add("No data to show! Please fill the 'Client's ID' field and press 'GET VEHICLES' button");

            DropDownListClients.Items.Clear();

            List<Owner> owners = _ownerBusiness.getAllOwners();

            foreach (Owner owner in owners)
                DropDownListClients.Items.Add(owner.ToString());
            
            if (owners.Count == 0)
            {
                ListBoxClientsVehicles.Items.Clear();

                ListBoxClientsVehicles.Items.Add("No clients in database!");
            }

        }

        protected void Page_Load(object sender, EventArgs e)
        {
            RefreshData();
            ButtonShowVehicles.Click += new EventHandler(this.ButtonShowVehicles_Click);
            ButtonClose.Click += new EventHandler(this.ButtonClose_Click);
        }

        private void ButtonShowVehicles_Click(object sender, EventArgs e)
        {
            try
            {
                var array = DropDownListClients.SelectedItem.ToString().Split(' ');

                String name = array[0];
                String surname = array[1];

                id = _ownerBusiness.getOwnerByNameAndSurname(name, surname).Id;
                List<Vehicle> vehicles = _vehicleBusiness.getVehiclesByOwnerID(id);

                if (vehicles.Count() == 0)
                {
                    ListBoxClientsVehicles.Items.Clear();

                    ListBoxClientsVehicles.Items.Add("Client doesn't have any vehicle yet.");
                }
                else
                {
                    ListBoxClientsVehicles.Items.Clear();

                    foreach (Vehicle vehicle in vehicles)
                        ListBoxClientsVehicles.Items.Add("Chassis number => " + vehicle.ChassisNumber + " Brand => " + vehicle.Brand + " Type => " + vehicle.Type + " Year of manufacture => " + vehicle.YearOfManufacture + " Licence plate => " + vehicle.LicencePlate + ".");

                }
            }

            catch
            {
                ClientScript.RegisterStartupScript(this.GetType(), "Warning", "alert('Make sure you choose valid name and surname!');", true);
            }
        }
        private void ButtonClose_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Clients.aspx");
        }
    }
}