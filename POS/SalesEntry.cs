using System;
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
    public partial class SalesEntry : Form
    {
        public SalesEntry()
        {
            InitializeComponent();
        }
        private void txtProductCode_Enter(object sender, EventArgs e)
        {
           if(txtProductCode.Text == "Product Code")
            {
                txtProductCode.Text = "";
                txtProductCode.ForeColor = Color.Black;
            }
        }
        private void txtProductName_Enter(object sender, EventArgs e)
        {
           if(txtProductName.Text == "Product Name")
            {
                txtProductName.Text = "";
                txtProductName.ForeColor = Color.Black;
            }
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            new HomeSales().Show();
            this.Hide();
        }

        private void txtProductCode_Leave(object sender, EventArgs e)
        {
            if (txtProductCode.Text == "")
            {
                txtProductCode.Text = "Product Code";
                txtProductCode.ForeColor = Color.Silver;
            }
        }

        private void txtProductName_Leave(object sender, EventArgs e)
        {
            if (txtProductName.Text == "")
            {
                txtProductName.Text = "Product Name";
                txtProductName.ForeColor = Color.Silver;
            }
        }
    }
}
