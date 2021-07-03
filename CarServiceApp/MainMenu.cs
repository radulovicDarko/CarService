using BusinessLayer;
using Shared.Models;
using Shared.Interfaces.Business;
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
    public partial class MainMenu : Form
    {
        private readonly IRepairOrderBusiness _repairOrderBusiness;
        private readonly IOwnerBusiness _ownerBusiness;
        private readonly IVehicleBusiness _vehicleBusiness;
        public MainMenu(IRepairOrderBusiness repairOrderBusiness, IOwnerBusiness ownerBusiness, IVehicleBusiness vehicleBusiness)
        {
            this._ownerBusiness = ownerBusiness;
            this._vehicleBusiness = vehicleBusiness;
            this._repairOrderBusiness = repairOrderBusiness;
            InitializeComponent();
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CarInspections carInspections = new CarInspections(_repairOrderBusiness,_ownerBusiness,_vehicleBusiness);
            
            carInspections.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Owners owners = new Owners(_ownerBusiness,_vehicleBusiness);
           
            owners.ShowDialog();
        }

        private void aboutUsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This application was made by Darko Radulović, Marko Radulović, Stefan Rakonjac and Nikola Milaković.","About us");
        }
    }
}
