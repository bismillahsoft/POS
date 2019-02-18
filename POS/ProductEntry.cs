using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Web;
using POS.IDAL;

namespace POS
{
    public partial class ProductEntry : Form
    {
        private IProductGeneric _IProductGeneric = null;
        public ProductEntry()
        {
            InitializeComponent();
            _IProductGeneric = new BLL.BProductGeneric();
            COMMON.DDL.PopulateDropDownList(_IProductGeneric.GetProductGenericList().ToList(), ddlGenericName, "GenericID", "GenericName");
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            new Homeproduct().Show();
            this.Hide();
        }
    }
}
