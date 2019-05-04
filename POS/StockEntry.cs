using POS.IDAL;
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
    public partial class StockEntry : Form
    {
        #region
        private IProduct _IProduct = null;
        private IProductPackSize _IProductPackSize = null;
       
        #endregion
        public StockEntry()
        {
            InitializeComponent();
            _IProduct = new BLL.BProduct();
            _IProductPackSize = new BLL.BProductPackSize();


            COMMON.DDL.PopulateDropDownList(_IProduct.GetProductList().ToList(), ddlProduct, "ProductID", "ProductName");
            COMMON.DDL.PopulateDropDownList(_IProductPackSize.GetProductPackSizeList().ToList(), ddlPackSize, "PackSizeID", "PackSize");
           
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            new Home().Show();
            this.Hide();
        }
    }
}
