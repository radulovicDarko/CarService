using Shared.Interfaces.Business;
using Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CarServiceWebApplication
{
    public partial class Clients : System.Web.UI.Page 
    {
       private readonly IOwnerBusiness _ownerBusiness;
        public Clients() { }
        public Clients(IOwnerBusiness ownerBusiness)
        {
            this._ownerBusiness = ownerBusiness;
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            ButtonNewClient.Click += new EventHandler(this.ButtonNewClient_Click);
            ButtonUpdateClientsInfo.Click += new EventHandler(this.ButtonUpdateClientsInfo_Click);
            ButtonDeleteClient.Click += new EventHandler(this.ButtonDeleteClient_Click);
            ButtonClientsVehicles.Click += new EventHandler(this.ButtonClientsVehicles_Click);
            RefreshData();
        }

        private void RefreshData()
        {
            List<Owner> owners = this._ownerBusiness.getAllOwners();

            ListBoxClients.Items.Clear();

            foreach (Owner owner in owners)
                ListBoxClients.Items.Add("ID: " + owner.Id + " Name => " + owner.Name + " Surname => " + owner.Surname + " Gender => " + owner.Gender + " Phone number => " + owner.PhoneNumber + " Address => " + owner.Address + " Email => " + owner.Email);
           
            if (owners.Count == 0)
            {
                ListBoxClients.Items.Clear();

                ListBoxClients.Items.Add("No clients in database!");
            }
        }
        private void ButtonNewClient_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/AddClient.aspx");
        }
        private void ButtonUpdateClientsInfo_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/UpdateOwner.aspx");
        }
        private void ButtonDeleteClient_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/DeleteOwner.aspx");
        }
        private void ButtonClientsVehicles_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/ClientsVehicles.aspx");
        }
    }
}