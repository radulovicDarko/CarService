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
    public partial class CarInspections : Form
    {
        public CarInspections()
        {
            InitializeComponent();
        }

        private void CarInspections_Load(object sender, EventArgs e)
        {

        }

        private void buttonNewInspection_Click(object sender, EventArgs e)
        {
            NewCarInspection newCarInspection = new NewCarInspection();
            newCarInspection.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }
    }
}
