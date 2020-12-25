﻿using System;
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
    public partial class AddOwner : Form
    {
        public AddOwner()
        {
            InitializeComponent();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Are you sure to cancel this action?", "Cancel", MessageBoxButtons.YesNo);

            if (confirmResult == DialogResult.Yes)
                this.Dispose();
        }
    }
}
