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
    public partial class UpdateOwnerInfo : Form
    {
        private readonly IOwnerBusiness _ownerBusiness;
        public static int id;
        public UpdateOwnerInfo(IOwnerBusiness ownerBusiness)
        {
            this._ownerBusiness = ownerBusiness;
            InitializeComponent();
        }

        private void UpdateOwnerInfo_Load(object sender, EventArgs e)
        {
            RefreshData();
        }
        private void RefreshData()
        {
            List<Owner> owners = this._ownerBusiness.getAllOwners();

            textBoxClientID.Text = "";

            listBoxClients.Items.Clear();

            foreach (Owner owner in owners)
                listBoxClients.Items.Add("ID: "+ owner.Id +" Name => " + owner.Name + " Surname => " + owner.Surname + " Gender => " + owner.Gender + " Phone number => " + owner.PhoneNumber + " Address => " + owner.Address +" Email => "+ owner.Email);
            
            if (owners.Count == 0)
            {
                listBoxClients.Items.Clear();

                listBoxClients.Items.Add("No clients in database!");
            }
        }

        private void buttonUpdateClientInfo_Click(object sender, EventArgs e)
        {
            try { 
                id = Convert.ToInt32(textBoxClientID.Text);

                if (_ownerBusiness.getOwnerByID(id) != null)
                {
                    UpdateOwner updateOwner= new UpdateOwner(_ownerBusiness);
                    updateOwner.ShowDialog();

                    RefreshData();
                }
                else
                {
                    MessageBox.Show("Make sure you entered correct ID!", "Warning");
                }
            }
            catch
            {
                MessageBox.Show("Make sure you entered correct ID!", "Warning");
            }
        }
    }
}
