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
    public partial class DeleteClientInfo : Form
    {
        private static int id;
        private readonly IOwnerBusiness _ownerBusiness;
        public DeleteClientInfo(IOwnerBusiness ownerBusiness)
        {
            this._ownerBusiness = ownerBusiness;
            InitializeComponent();
        }

        private void RefreshData()
        {
            List<Owner> owners = _ownerBusiness.getAllOwners();

            textBoxClientID.Text = "";

            listBoxClients.Items.Clear();

            foreach (Owner owner in owners)
                listBoxClients.Items.Add("ID: " + owner.Id + " Name => " + owner.Name + " Surname => " + owner.Surname + " Gender => " + owner.Gender + " Phone number => " + owner.PhoneNumber + " Address => " + owner.Address + " Email => " + owner.Email);
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            try
            {
                id = Convert.ToInt32(textBoxClientID.Text);

                if (_ownerBusiness.getOwnerByID(id) != null)
                {
                    var confirmResult = MessageBox.Show("Are you sure to delete info about this client?", "Cancel", MessageBoxButtons.YesNo);

                    if (confirmResult == DialogResult.Yes)
                        this._ownerBusiness.deleteOwner(_ownerBusiness.getOwnerByID(id));

                    RefreshData();
                }
            }

            catch
            {
                MessageBox.Show("Make sure you entered correct ID!", "Warning");
            }
        }

        private void DeleteClientInfo_Load(object sender, EventArgs e)
        {
            RefreshData();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Are you sure to close this window?", "Cancel", MessageBoxButtons.YesNo);

            if (confirmResult == DialogResult.Yes)
                this.Dispose();
        }
    }
}
