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
    public partial class Owners : Form
    {
        private readonly IOwnerBusiness _ownerBusiness;
        private readonly IVehicleBusiness _vehicleBusiness;
        public Owners(IOwnerBusiness ownerBusiness, IVehicleBusiness vehicleBusiness)
        {
            this._vehicleBusiness = vehicleBusiness;
            this._ownerBusiness = ownerBusiness;
            InitializeComponent();
        }

        private void buttonNewClient_Click(object sender, EventArgs e)
        {
            AddClient addOwner = new AddClient(_ownerBusiness);
            addOwner.ShowDialog();

            RefreshData();
        }

        private void Owners_Load(object sender, EventArgs e)
        {
            RefreshData();
        }
        private void RefreshData()
        {
            List<Owner> owners = this._ownerBusiness.getAllOwners();

            listBoxClients.Items.Clear();

            foreach (Owner owner in owners)
                listBoxClients.Items.Add("ID: " + owner.Id + " Name => " + owner.Name + " Surname => " + owner.Surname + " Gender => " + owner.Gender + " Phone number => " + owner.PhoneNumber + " Address => " + owner.Address + " Email => " + owner.Email);
           
            if (owners.Count == 0)
            {
                listBoxClients.Items.Clear();

                listBoxClients.Items.Add("No clients in database!");
            }
        }

        private void buttonUpdateClient_Click(object sender, EventArgs e)
        {
            UpdateOwnerInfo updateOwnerInfo = new UpdateOwnerInfo(_ownerBusiness);
            updateOwnerInfo.ShowDialog();

            RefreshData();

        }

        private void buttonDeleteClient_Click(object sender, EventArgs e)
        {
            DeleteClientInfo deleteClientInfo = new DeleteClientInfo(_ownerBusiness,_vehicleBusiness);
            deleteClientInfo.ShowDialog();

            RefreshData();
        }

        private void buttonClientsVehicles_Click(object sender, EventArgs e)
        {
            ClientsVehicles clientsVehicles = new ClientsVehicles(_vehicleBusiness,_ownerBusiness);
            clientsVehicles.ShowDialog();

            RefreshData();
        }
    }
}
