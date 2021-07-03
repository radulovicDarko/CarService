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
    public partial class ClientsVehicles : Form
    {
        private readonly IVehicleBusiness _vehicleBusiness;
        private readonly IOwnerBusiness _ownerBusiness;
        private static int id;
        public ClientsVehicles(IVehicleBusiness vehicleBusiness, IOwnerBusiness ownerBusiness)
        {
            this._ownerBusiness = ownerBusiness;
            this._vehicleBusiness = vehicleBusiness;
            InitializeComponent();
        }
        private void RefreshData()
        {
            listBoxClientsVehicles.Items.Clear();
            listBoxClientsVehicles.Items.Add("No data to show! Please fill the 'Client's ID' field and press 'GET VEHICLES' button");

            comboBoxClients.Items.Clear();

            List<Owner> owners = _ownerBusiness.getAllOwners();

            foreach (Owner owner in owners)
                comboBoxClients.Items.Add(owner);

            if (owners.Count == 0)
            {
                listBoxClientsVehicles.Items.Clear();

                listBoxClientsVehicles.Items.Add("No clients in database!");
            }
        }

        private void ClientsVehicles_Load(object sender, EventArgs e)
        {
            RefreshData();
        }

        private void buttonShowVehicles_Click(object sender, EventArgs e)
        {
            try
            {
                if (_ownerBusiness.getAllOwners().Count != 0 && comboBoxClients.SelectedItem == null)
                {
                        listBoxClientsVehicles.Items.Clear();

                        listBoxClientsVehicles.Items.Add("Please choose client!");
                }
                else if(_ownerBusiness.getAllOwners().Count != 0) 
                { 
                    var array = comboBoxClients.SelectedItem.ToString().Split(' ');

                    String name = array[0];
                    String surname = array[1];

                    id = _ownerBusiness.getOwnerByNameAndSurname(name, surname).Id;
                    List<Vehicle> vehicles = _vehicleBusiness.getVehiclesByOwnerID(id);

                    if (vehicles.Count() == 0)
                    {
                        listBoxClientsVehicles.Items.Clear();

                        listBoxClientsVehicles.Items.Add("Client doesn't have any vehicle yet.");
                    }
                    else
                    {
                        listBoxClientsVehicles.Items.Clear();

                        foreach (Vehicle vehicle in vehicles)
                            listBoxClientsVehicles.Items.Add("Chassis number => " + vehicle.ChassisNumber + " Brand => " + vehicle.Brand + " Type => " + vehicle.Type + " Year of manufacture => " + vehicle.YearOfManufacture + " Licence plate => " + vehicle.LicencePlate + ".");

                    }
                }
                else
                {
                    listBoxClientsVehicles.Items.Clear();

                    listBoxClientsVehicles.Items.Add("No clients in database!");
                }
                
            }

            catch
            {
                MessageBox.Show("Make sure you entered correct name and surname!", "Warning");
            }
        }
    }
}
