using Shared.Interfaces.Business;
using Shared.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarServiceApp
{
    public partial class AddOwner : Form
    {
        private readonly IOwnerBusiness _ownerBusiness;
        public AddOwner(IOwnerBusiness ownerBusiness)
        {
            this._ownerBusiness = ownerBusiness;
            InitializeComponent();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Are you sure to close this window?", "Cancel", MessageBoxButtons.YesNo);

            if (confirmResult == DialogResult.Yes)
                this.Dispose();
        }

        private void resetData()
        {
            textBoxClientName.Text = "";
            textBoxClientsSurname.Text = "";
            textBoxAddress.Text = "";
            textBoxEmail.Text = "";
            textBoxPhone.Text = "";
            comboBoxGender.SelectedIndex = 0;
        }

        private void buttonNewClient_Click(object sender, EventArgs e)
        {
            bool valid = true;
            int result = 0;

            Owner o = new Owner();

            o.Name = textBoxClientName.Text;
            o.Surname = textBoxClientsSurname.Text;
            if(comboBoxGender.SelectedIndex != -1)
                o.Gender = comboBoxGender.SelectedItem.ToString();
            o.Address = textBoxAddress.Text;
            o.PhoneNumber = textBoxPhone.Text;
            o.Email = textBoxEmail.Text;
               

            foreach (Control c in this.Controls)
            {
                if (c is TextBox)
                {
                    TextBox textBox = c as TextBox;
                    if (textBox.Text == string.Empty)
                    {
                        valid = false;
                        break;
                    }
                }
            }

            if (valid)
               result = _ownerBusiness.insertOwner(o);

            if (result != 0)
            {
                MessageBox.Show("Successfully inserted data!", "Success");
                resetData();
            }
            else
                MessageBox.Show("Make sure you filled up all the gaps correctly!", "Warning");


        }

        private void AddOwner_Load(object sender, EventArgs e)
        {
            comboBoxGender.SelectedIndex = 0;
        }
    }
}
