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
    public partial class Homeproduct : Form
    {
        public Homeproduct()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            new Home().Show();
            this.Hide();
        }

        private void btnSubBrand_Click(object sender, EventArgs e)
        {
            new BrandEntry().Show();
            this.Hide();
        }

        private void btnSubProductEntry_Click(object sender, EventArgs e)
        {
            new ProductEntry().Show();
            this.Hide();
        }

        private void btnSubBatch_Click(object sender, EventArgs e)
        {
            new BatchEntry().Show();
            this.Hide();
        }

        private void btnSubCategory_Click(object sender, EventArgs e)
        {
            new ProductCategory().Show();
            this.Hide();
        }

        private void btnSubGeneric_Click(object sender, EventArgs e)
        {
            new GenericEntry().Show();
            this.Hide();
        }

        private void btnSubPackSize_Click(object sender, EventArgs e)
        {
            new PackSizeEntry().Show();
            this.Hide();
        }
    }
}
