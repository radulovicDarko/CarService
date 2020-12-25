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
    public partial class NewCarInspection : Form
    {
        public NewCarInspection()
        {
            InitializeComponent();
        }

        private void NewCarInspection_Load(object sender, EventArgs e)
        {

        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Are you sure to cancel this action?", "Cancel", MessageBoxButtons.YesNo);
            
            if (confirmResult == DialogResult.Yes)
                this.Dispose();
        }

        private void buttonNewRepairOrder_Click(object sender, EventArgs e)
        {

        }

        private void buttonAddOwner_Click(object sender, EventArgs e)
        {
            AddOwner addOwner = new AddOwner();
            addOwner.Show();
        }

        private void buttonAddVehicle_Click(object sender, EventArgs e)
        {
            AddVehicle addVehicle = new AddVehicle();
            addVehicle.Show();
        }
    }
}
