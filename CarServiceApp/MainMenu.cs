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
        public MainMenu()
        {
            InitializeComponent();
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CarInspections carInspections = new CarInspections();
            carInspections.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Owners owners = new Owners();
            owners.Show();
        }

        private void aboutUsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This application was made by Darko Radulović, Marko Radulović, Stefan Rakonjac and Nikola Milaković.","About us");
        }
    }
}
