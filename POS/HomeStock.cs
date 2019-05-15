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
    public partial class HomeStock : Form
    {
        public HomeStock()
        {
            InitializeComponent();
        }

        private void btnStockEntry_Click(object sender, EventArgs e)
        {
            new StockEntryPage().Show();
            this.Hide();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            new Home().Show();
            this.Hide();
        }
    }
}
