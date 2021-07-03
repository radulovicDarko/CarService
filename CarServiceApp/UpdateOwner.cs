using Shared.Interfaces.Business;
using Shared.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarServiceApp
{
    public partial class UpdateOwner : Form
    {
        private readonly IOwnerBusiness _ownerBusiness;
        public static int id = UpdateOwnerInfo.id;
        private bool valid;
        private string emailRegex = @"^[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+\.[a-zA-Z0-9-.]+$";
        public UpdateOwner(IOwnerBusiness ownerBusiness)
        {
            this._ownerBusiness = ownerBusiness;
            InitializeComponent();
        }

        private void UpdateOwner_Load(object sender, EventArgs e)
        {
            comboBoxGender.SelectedIndex = 0;
        }

        private void resetData()
        {
            textBoxClientName.Text = "";
            textBoxClientsSurname.Text = "";
            comboBoxGender.SelectedIndex = 0;
            textBoxPhone.Text = "";
            textBoxAddress.Text = "";
            textBoxEmail.Text = "";
        }

        private void buttonUpdateInfo_Click(object sender, EventArgs e)
        {
            int result = 0;
            try
            {
                Owner owner = new Owner();

                owner.Name = textBoxClientName.Text;
                owner.Surname = textBoxClientsSurname.Text;
                owner.Gender = comboBoxGender.SelectedItem.ToString();
                owner.PhoneNumber = textBoxPhone.Text;
                owner.Address = textBoxAddress.Text;
                owner.Email = textBoxEmail.Text;
                owner.Id = id;

                if (!Regex.Match(textBoxEmail.Text, emailRegex).Success)
                {
                    labelEmailRegex.Text = "Enter valid e-mail address!";
                    valid = false;
                }
                else 
                { 
                    labelEmailRegex.Text = "";
                    valid = true;
                }
                
                if (textBoxClientName.Text != "" && textBoxClientsSurname.Text != "" && textBoxPhone.Text != "" && textBoxAddress.Text != "" && textBoxEmail.Text != "" && valid)
                    result = _ownerBusiness.updateOwner(owner);
                else
                    MessageBox.Show("Make sure you filled up all the gaps correctly!", "Warning");

                if (result != 0)
                {
                    MessageBox.Show("Successfully inserted data!", "Success");
                    resetData();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Make sure you filled up all the gaps correctly!", "Warning");
                Console.WriteLine(ex.StackTrace);
            }
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Are you sure to close this window?", "Cancel", MessageBoxButtons.YesNo);

            if (confirmResult == DialogResult.Yes)
                this.Dispose();
        }
    }
}
