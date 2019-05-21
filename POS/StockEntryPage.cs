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
        int StpAndCnt;
        int TStock;
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
            //GetCurrentStock();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                BO.DMS_AreaStock ObjDMS_AreaStock = new BO.DMS_AreaStock();

                ObjDMS_AreaStock.AreaID = 1;
                ObjDMS_AreaStock.ProductID = Convert.ToInt32(ddlProduct.SelectedValue);
                ObjDMS_AreaStock.CtnOrPkt = Convert.ToInt32(txtCtnPkt.Text);
                ObjDMS_AreaStock.Pcs = Convert.ToInt32(txtPcs.Text);
                ObjDMS_AreaStock.Qty = Convert.ToInt32(txtQty.Text);
                ObjDMS_AreaStock.Strip = Convert.ToInt32(txtStrip.Text);
                ObjDMS_AreaStock.PcsPerStrip = Convert.ToInt32(txtPcsPerStrip.Text);
                ObjDMS_AreaStock.StockTransantionDate = Convert.ToDateTime(TransactionDate.Value.ToString());

                if (_IDMS_AreaStock.Insert(ObjDMS_AreaStock) > 0)
                {
                    MessageBox.Show("Succesfully Saved");
                    Reset();
                    GetCurrentStock();
                }
                else
                {
                    MessageBox.Show("Operation Failed");
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            try
            {
                new HomeStock().Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private void ddlProduct_SelectedIndexChanged(object sender, EventArgs e)
        {

            try
            {
                BO.ProductPackSize objProductPackSize = new BO.ProductPackSize();
                int productId = Convert.ToInt32(ddlProduct.SelectedValue);
                var product = _IProduct.GetProductList().FirstOrDefault(m => m.ProductId == productId);
                txtPackSizee.Text = product.PackSize;

                var productPackSize = _IProductPackSize.GETStripAndPcsPerStripByProductID(productId);
                txtStrip.Text = Convert.ToString(productPackSize.Strip);
                txtPcsPerStrip.Text = Convert.ToString(productPackSize.PcsPerStrip);
                GetCurrentStock();
                //Reset();
                //List<BO.ProductPackSize> objPackSizeList = new List<BO.ProductPackSize>();
                //foreach (var objProduct in productList)
                //{
                //    BO.ProductPackSize objPackSize = new BO.ProductPackSize();
                //    //objPackSize.PackSizeID = objProduct.ProdPackSize.PackSizeID;
                //    objPackSize.PackSizeID = objProduct.PackSizeID;
                //    objPackSize.PackSize = objProduct.PackSize;
                //    objPackSizeList.Add(objPackSize);
                //}
            }
            catch (Exception ex)
            {

            }
        }
        private void txtPackSizee_TextChanged(object sender, EventArgs e)
        {

        }
        private void ddlProduct_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                txtPackSizee.Focus();
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
                TransactionDate.Focus();
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
        private void TransactionDate_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnSave.Focus();
        }
        private void Reset()
        {
            txtCsCtn.Text = "";
            txtCsPcs.Text = "";
            TransactionDate.Text = "";

        }
        private void GetCurrentStock()
        {
            BO.DMS_AreaStock currentStock = new BO.DMS_AreaStock();
            int productID = Convert.ToInt32(ddlProduct.SelectedValue);
            currentStock = _IDMS_AreaStock.GetCurrentStockByProductID(productID);
            txtCsCtn.Text = Convert.ToString(currentStock.CtnOrPkt);
            txtCsPcs.Text = Convert.ToString(currentStock.Pcs);
            txtCsQty.Text = Convert.ToString(currentStock.Qty);
            txtTsCtnPkt.Text = txtCsCtn.Text;
            txtTsPcs.Text = txtCsPcs.Text;
            txtTsQty.Text = txtCsQty.Text;
        }
        private void btnReset_Click(object sender, EventArgs e)
        {
            Reset();
        }
        private void txtCtnPkt_TextChanged(object sender, EventArgs e)
        {
            int CtnOrPkt = 0;
            int NewStock = 0;
            int strip = Convert.ToInt32(txtStrip.Text);
            int PcsPerStrip = Convert.ToInt32(txtPcsPerStrip.Text);
            if (txtCtnPkt.Text == "")
            {
                CtnOrPkt = 0;
            }
            else
            {
                CtnOrPkt = Convert.ToInt32(txtCtnPkt.Text);
            }
            StpAndCnt = (strip * PcsPerStrip * CtnOrPkt);
            txtQty.Text = Convert.ToString(StpAndCnt);
            if (txtQty.Text == "")
            {
                NewStock = Convert.ToInt32(txtQty.Text);
            }
            else
            {
                NewStock = 0;
            }
            int CsStock = Convert.ToInt32(txtCsQty.Text);
            TStock = CsStock + NewStock;
            txtTsCtnPkt.Text = Convert.ToString((TStock / (strip * PcsPerStrip)));
            txtTsPcs.Text = Convert.ToString((TStock % (strip * PcsPerStrip)));
            txtTsQty.Text = Convert.ToString(TStock);
        }
        private void txtPcs_TextChanged(object sender, EventArgs e)
        {
            int Pcs = 0;
            int strip = Convert.ToInt32(txtStrip.Text);
            int PcsPerStrip = Convert.ToInt32(txtPcsPerStrip.Text);
            if (txtPcs.Text == "")
            {
                Pcs = 0;
            }
            else
            {
                Pcs = Convert.ToInt32(txtPcs.Text);
            }

            int totalsum = StpAndCnt + Pcs;
            txtQty.Text = Convert.ToString(totalsum);
            int TotalStock = TStock + Pcs;
            txtTsCtnPkt.Text = Convert.ToString((TotalStock / (strip * PcsPerStrip)));
            txtTsPcs.Text = Convert.ToString((TotalStock % (strip * PcsPerStrip)));
            txtTsQty.Text = Convert.ToString(TotalStock);
        }
    }
}
