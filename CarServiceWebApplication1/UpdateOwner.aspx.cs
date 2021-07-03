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
    public partial class UpdateOwner : System.Web.UI.Page
    {
        private readonly IRepairOrderBusiness _repairOrderBusiness;
        private readonly IVehicleBusiness _vehicleBusiness;
        private readonly IOwnerBusiness _ownerBusiness;
        public static int id;
        public UpdateOwner() { }
        public UpdateOwner(IRepairOrderBusiness repairOrderBusiness, IVehicleBusiness vehicleBusiness, IOwnerBusiness ownerBusiness)
        {
            this._ownerBusiness = ownerBusiness;
            this._vehicleBusiness = vehicleBusiness;
            this._repairOrderBusiness = repairOrderBusiness;
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            RefreshData();
            ButtonUpdateInfo.Click += new EventHandler(this.ButtonUpdateInfo_Click);
            ButtonClose.Click += new EventHandler(this.ButtonClose_Click);
        }
        private void RefreshData()
        {
            List<Owner> owners = _ownerBusiness.getAllOwners();

            ListBoxClients.Items.Clear();

            foreach (Owner owner in owners)
                ListBoxClients.Items.Add("ID: " + owner.Id + " Name => " + owner.Name + " Surname => " + owner.Surname + " Gender => " + owner.Gender + " Phone number => " + owner.PhoneNumber + " Address => " + owner.Address + " Email => " + owner.Email);
            
            if (owners.Count == 0)
            {
                ListBoxClients.Items.Clear();

                ListBoxClients.Items.Add("No clients in database!");
            }
        }
        private void ButtonUpdateInfo_Click(object sender, EventArgs e)
        {
            try
            {
                id = Convert.ToInt32(TextBoxClientID.Text);

                if (_ownerBusiness.getOwnerByID(id) != null)
                {
                    Response.Redirect("~/UpdateOwnerInfo.aspx");
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
        }
        private void ButtonClose_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Clients.aspx");
        }
    }
}