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
           
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            new HomeStock().Show();
            this.Hide();
        }

        private void ddlProduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            int productId = Convert.ToInt32(ddlProduct.SelectedValue);
            var productList = _IProduct.GetProductList().Where(m=>m.ProductId==productId).ToList();
            List<BO.ProductPackSize> objPackSizeList = new List<BO.ProductPackSize>();
            foreach (var objProduct in productList)
            {
                BO.ProductPackSize objPackSize = new BO.ProductPackSize();
                //objPackSize.PackSizeID = objProduct.ProdPackSize.PackSizeID;
                objPackSize.PackSizeID = objProduct.PackSizeID;
                objPackSize.PackSize = objProduct.PackSize;
                //objPackSize.PackSize = objProduct.ProdPackSize.PackSize;
                objPackSizeList.Add(objPackSize);
            }

            COMMON.DDL.PopulateDropDownList(objPackSizeList, ddlPackSize, "PackSizeID", "PackSize");

        }

        private void ddlProduct_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                ddlPackSize.Focus();
        }

        private void ddlPackSize_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                txtCtnPkt.Focus();
        }

      

        private void txtPcs_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                txtQty.Focus();
        }

        private void txtQty_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                txtRemarks.Focus();
        }

        private void txtRemarks_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnSave.Focus();
        }

        private void btnSave_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnReset.Focus();
        }

        private void btnReset_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnBack.Focus();
        }

        private void txtCtnPkt_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                txtPcs.Focus();
        }
    }
}
