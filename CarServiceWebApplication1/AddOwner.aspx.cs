﻿using Shared.Interfaces.Business;
using Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CarServiceWebApplication1
{
    public partial class AddOwner : System.Web.UI.Page
    {
        private readonly IOwnerBusiness _ownerBusiness;
        public AddOwner() { }
        public AddOwner(IOwnerBusiness ownerBusiness)
        {
            this._ownerBusiness = ownerBusiness;
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            ButtonAddClient.Click += new EventHandler(this.ButtonAddClient_Click);
            ButtonClose.Click += new EventHandler(this.ButtonClose_Click);
            DropDownListGender.SelectedIndex = 0;
        }
        private void ButtonAddClient_Click(Object sender, EventArgs e)
        {
            bool valid;
            int result = 0;

            Owner o = new Owner();

            o.Name = TextBoxName.Text;
            o.Surname = TextBoxSurname.Text;
            if (DropDownListGender.SelectedIndex != -1)
                o.Gender = DropDownListGender.SelectedItem.ToString();
            o.Address = TextBoxAddress.Text;
            o.PhoneNumber = TextBoxPhoneNumber.Text;
            o.Email = TextBoxEmail.Text;

            if (TextBoxName.Text != "" && TextBoxSurname.Text != "" && TextBoxPhoneNumber.Text != "" && TextBoxAddress.Text != "" && TextBoxEmail.Text != "")
                valid = true;
            else
                valid = false;

            if (valid)
                result = _ownerBusiness.insertOwner(o);

            if (result != 0)
            {
                ClientScript.RegisterStartupScript(this.GetType(), "Success", "alert('Successfully updated data!');", true); 
                
                resetData();
            }
            else
                ClientScript.RegisterStartupScript(this.GetType(), "Warning", "alert('Make sure you filled up all the gaps correctly!');", true);
        }
        private void resetData()
        {
            TextBoxName.Text = "";
            TextBoxSurname.Text = "";
            TextBoxAddress.Text = "";
            TextBoxEmail.Text = "";
            TextBoxPhoneNumber.Text = "";
            DropDownListGender.SelectedIndex = 0;
        }
        private void ButtonClose_Click(Object sender, EventArgs e)
        {
            Response.Redirect("~/NewRepairOrder.aspx");
        }
    }
}