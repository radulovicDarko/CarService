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
        public Owners()
        {
            InitializeComponent();
        }

        private void buttonNewClient_Click(object sender, EventArgs e)
        {
            AddOwner addOwner = new AddOwner();
            addOwner.Show();
        }
    }
}
