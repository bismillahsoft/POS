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
    public partial class HomeSales : Form
    {
        public HomeSales()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            new Home().Show();
            this.Hide();
        }

        private void btnStockEntry_Click(object sender, EventArgs e)
        {
            new Sales().Show();
            this.Hide();
        }
    }
}
