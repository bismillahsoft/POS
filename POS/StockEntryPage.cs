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
    public partial class StockEntryPage : Form
    {
        #region
        private IProduct _IProduct = null;
        private IProductPackSize _IProductPackSize = null;
        private IDMS_AreaStock _IDMS_AreaStock = null;

        #endregion
        public StockEntryPage()
        {
            InitializeComponent();
            _IProduct = new BLL.BProduct();
            _IProductPackSize = new BLL.BProductPackSize();
            _IDMS_AreaStock = new BLL.BDMS_AreaStock();



            COMMON.DDL.PopulateDropDownList(_IProduct.GetProductList().ToList(), ddlProduct, "ProductID", "ProductName");

        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                BO.DMS_AreaStock ObjDMS_AreaStock = new BO.DMS_AreaStock();

                //ObjDMS_AreaStock.ProductName = Convert.ToInt32(ddlProduct.SelectedValue);
                ObjDMS_AreaStock.AreaID = 1;
                ObjDMS_AreaStock.ProductID = Convert.ToInt32(ddlProduct.SelectedValue);
                ObjDMS_AreaStock.CtnOrPkt = Convert.ToInt32(txtCtnPkt.Text);
                ObjDMS_AreaStock.Pcs = Convert.ToInt32(txtPcs.Text);
                ObjDMS_AreaStock.Qty = Convert.ToInt32(txtQty.Text);
                //ObjDMS_AreaStock.StockTransantionDate = Convert.ToDateTime(TransactionDate.Value.ToString());
                //ObjDMS_AreaStock.Remarks = txtRemarks.Text;


                if (_IDMS_AreaStock.Insert(ObjDMS_AreaStock) > 0)
                {
                    MessageBox.Show("Succesfully Saved");
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            new HomeStock().Show();
            this.Hide();
        }

        private void ddlProduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            var objProductWisePackSize = _IProduct.GetProductList().FirstOrDefault(m => m.ProductId == Convert.ToInt32(ddlProduct.SelectedValue));
            txtPackSize.Text = objProductWisePackSize.PackSize;

            string packSize = Convert.ToString(txtPackSize.Text);
            int strips = Convert.ToInt32(packSize.Substring(0, packSize.IndexOf("x")));
        }

        private void ddlProduct_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                txtPackSize.Focus();
        }

        private void txtPcs_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                txtQty.Focus();
        }

        private void txtQty_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) ;
            //txtRemarks.Focus();
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
