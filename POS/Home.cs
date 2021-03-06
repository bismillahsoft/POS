﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void btnlogout_Click(object sender, EventArgs e)
        {
            new Login().Show();
            this.Hide();
        }

        private void btnProduct_Click(object sender, EventArgs e)
        {
            new Homeproduct().Show();
            this.Hide(); 
        }

        private void btnInventory_Click(object sender, EventArgs e)
        {
            new HomeStock().Show();
            this.Hide();
        }

        private void btnSales_Click(object sender, EventArgs e)
        {
            new HomeSales().Show();
            this.Hide();
        }
    }
}
