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
        private readonly IVehicleBusiness _vehicleBusiness;
        public DeleteClientInfo(IOwnerBusiness ownerBusiness, IVehicleBusiness vehicleBusiness)
        {
            this._vehicleBusiness = vehicleBusiness;
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

            if (owners.Count == 0)
            {
                listBoxClients.Items.Clear();

                listBoxClients.Items.Add("No clients in database!");
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            try
            {
                List<Vehicle> vehicles = new List<Vehicle>();
                id = Convert.ToInt32(textBoxClientID.Text);

                vehicles = this._vehicleBusiness.getVehiclesByOwnerID(id);
            
                if (_ownerBusiness.getOwnerByID(id) != null)
                {
                    var confirmResult = MessageBox.Show("Are you sure to delete info about this client? If you delete this client, you will also delete all his vehicles!", "Cancel", MessageBoxButtons.YesNo);

                    if (confirmResult == DialogResult.Yes) { 
                        this._ownerBusiness.deleteOwner(_ownerBusiness.getOwnerByID(id));

                        foreach (Vehicle vehicle in vehicles)
                            if (vehicle.OwnerId == id)
                                _vehicleBusiness.deleteVehicle(vehicle);
                    }

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
