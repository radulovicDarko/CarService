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
        public static int id;
        public DeleteOwner() { }
        public DeleteOwner(IOwnerBusiness ownerBusiness)
        {
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
                id = Convert.ToInt32(TextBoxClientID.Text);

                if (_ownerBusiness.getOwnerByID(id) != null)
                {
                    this._ownerBusiness.deleteOwner(_ownerBusiness.getOwnerByID(id));
                    ClientScript.RegisterStartupScript(this.GetType(), "Success", "alert('Owner has been deleted from database!');", true);

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
        }
        private void ButtonClose_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Clients.aspx");
        }
    }
}