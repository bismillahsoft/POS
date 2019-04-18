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
        #region
        private IProduct _IProduct = null;
        private IProductPackSize _IProductPackSize = null;
        private IBrand _Ibrand = null;
        private IProductGeneric _IProductGeneric = null;
        private IProductCategory _IProductCategory = null;
        #endregion
        int ID;
        long pPID;
        long pPSID;
        public ProductEntry()
        {
            InitializeComponent();
            _IProduct = new BLL.BProduct();
            _IProductPackSize = new BLL.BProductPackSize();
            _Ibrand = new BLL.BBrand();
            _IProductGeneric = new BLL.BProductGeneric();
            _IProductCategory = new BLL.BProductCategory();

            COMMON.DDL.PopulateDropDownList(_IProductPackSize.GetProductPackSizeList().ToList(), ddlPackSize, "PackSizeID", "PackSize");
            COMMON.DDL.PopulateDropDownList(_Ibrand.GetBrandList().ToList(), ddlBrand, "BrandID", "BrandName");
            COMMON.DDL.PopulateDropDownList(_IProductGeneric.GetProductGenericList().ToList(), ddlGenericName, "PGenericID", "GenericName");
            //COMMON.DDL.PopulateDropDownList(_IProductCategory.GetProductCategoryList().ToList(), ddlCategorygory,"","");
            COMMON.DDL.PopulateDropDownList(_IProductCategory.GetProductCategoryList().ToList(), ddlCategory, "Id", "Name");
            Reset();
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            new Homeproduct().Show();
            this.Hide();
        }
        private void ddlPackSize_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                BO.Product objProducts = new BO.Product();

                objProducts.ProductName = txtPro_Name.Text;
                objProducts.ProdPackSize.ProductCode = txtProductCode.Text;
                objProducts.ProdPackSize.PackSizeID = Convert.ToInt32(ddlPackSize.SelectedValue);
                objProducts.Brand.BrandID = Convert.ToInt32(ddlBrand.SelectedValue);
                objProducts.ProductGeneric.PGenericID = Convert.ToInt32(ddlGenericName.SelectedValue);
                objProducts.ProductCategory.Id = Convert.ToInt32(ddlCategory.SelectedValue);
                objProducts.ProductPrice.TradePrice = Convert.ToDecimal(txtTradePrice.Text);
                objProducts.ProductPrice.PurchasePrice = Convert.ToDecimal(txtPurchesePrice.Text);
                objProducts.ProductPrice.Vat = Convert.ToDecimal(txtVat.Text);
                objProducts.ProductPrice.MRP = Convert.ToDecimal(txtMRP.Text);
                objProducts.BatchNo = Convert.ToString(txtBatch.Text);
                objProducts.Description = txtDescription.Text;
                objProducts.ProdPackSize.PPSID = pPSID;
                objProducts.ProductPrice.PPID = pPID;

                if (btnSave.Text == "Update" && txtPro_Name.Text != "")
                {
                    if (_IProduct.Update(objProducts, ID) > 0)
                    {
                        MessageBox.Show("Successfully Update");
                        Reset();
                        GetProductList();
                    }
                }
                else if (btnSave.Text == "Save")
                {
                    if (_IProduct.Insert(objProducts) > 0)
                    {
                        MessageBox.Show("Successfully Saved");
                        //lblMessageBox.Text = "Successfully Saved";
                        //lblMessageBox.ForeColor = Color.Green;
                        GetProductList();
                        Reset();
                    }
                    else
                    {
                        MessageBox.Show("Operation Failed");
                        //lblMessageBox.Text = "Operation Failed";
                        //lblMessageBox.ForeColor = Color.Red;
                    }
                }
                else
                {
                    MsgBox msgBox = new MsgBox();
                    msgBox.Show();
                    //lblMessageBox.Text = "Operation Failed";
                    //lblMessageBox.ForeColor = Color.Red;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private void GetProductList()
        {
            List<BO.Product> getProduct = new List<BO.Product>();
            getProduct = _IProduct.GetProductList().ToList();
            grvProductEntry.AutoGenerateColumns = false;
            grvProductEntry.DataSource = getProduct;
        }
        private void txtPro_Name_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                txtProductCode.Focus();
        }
        private void txtProductCode_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                ddlPackSize.Focus();
        }
        private void ddlPackSize_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                ddlBrand.Focus();
        }
        private void ddlBrand_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                ddlGenericName.Focus();
        }
        private void ddlGenericName_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                ddlCategory.Focus();
        }
        private void ddlCategory_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                txtTradePrice.Focus();
        }
        private void txtTradePrice_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                txtPurchesePrice.Focus();
        }
        private void txtPurchesePrice_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                txtVat.Focus();
        }
        private void txtVat_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                txtMRP.Focus();
        }
        private void txtMRP_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                txtBatch.Focus();
        }
        private void txtBatch_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                txtDescription.Focus();
        }
        private void txtDescription_KeyUp(object sender, KeyEventArgs e)
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
        private void btnBack_KeyUp(object sender, KeyEventArgs e)
        {

        }
        private void Reset()
        {
            txtPro_Name.Text = "";
            txtProductCode.Text = "";
            ddlBrand.SelectedText = "";
            ddlPackSize.SelectedText = "";
            ddlGenericName.SelectedText = "";
            ddlCategory.SelectedText = "";
            txtTradePrice.Text = "";
            txtPurchesePrice.Text = "";
            txtVat.Text = "";
            txtMRP.Text = "";
            txtBatch.Text = "";
            txtDescription.Text = "";
            btnSave.Text = "Save";
            GetProductList();
        }
        private void btnReset_Click(object sender, EventArgs e)
        {
            Reset();
        }
        private void grvProductEntry_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                BO.Product objProduct = new BO.Product();
                if (e.ColumnIndex == grvProductEntry.Columns["Edit"].Index && e.RowIndex >= 0)
                {
                    int numberRow = Convert.ToInt32(e.RowIndex);
                    ID = Convert.ToInt32(grvProductEntry.Rows[numberRow].Cells[0].Value.ToString());
                    objProduct = _IProduct.GetProductList().FirstOrDefault(m => m.ProductId == ID);
                    txtPro_Name.Text = objProduct.ProductName;
                    txtProductCode.Text = objProduct.ProductCode;
                    ddlPackSize.SelectedValue = objProduct.ProdPackSize.PackSizeID;
                    ddlBrand.SelectedValue = objProduct.Brand.BrandID;
                    ddlGenericName.SelectedValue = objProduct.ProductGeneric.PGenericID;
                    ddlCategory.SelectedValue = objProduct.ProductCategory.Id;
                    txtTradePrice.Text = objProduct.TradePrice.ToString();
                    txtPurchesePrice.Text = objProduct.PurchesePrice.ToString();
                    txtVat.Text = objProduct.Vat.ToString();
                    txtMRP.Text = objProduct.MRP.ToString();
                    txtBatch.Text = objProduct.BatchNo.ToString();
                    txtDescription.Text = objProduct.Description.ToString();
                    pPID = objProduct.ProductPrice.PPID;
                    pPSID = objProduct.ProdPackSize.PPSID;
                    btnSave.Text = "Update";
                }
                else if (e.ColumnIndex == grvProductEntry.Columns["Delete"].Index && e.RowIndex >= 0)
                {
                    int numberRow = Convert.ToInt32(e.RowIndex);
                    //assign the value plus the desired column example 1
                    ID = Convert.ToInt32(grvProductEntry.Rows[numberRow].Cells[0].Value.ToString());
                    objProduct = _IProduct.GetProductList().FirstOrDefault(m => m.ProductId == ID);
                    pPID = objProduct.ProductPrice.PPID;
                    pPSID = objProduct.ProdPackSize.PPSID;
                    if (_IProduct.DELETE(objProduct) > 0)
                    {
                        MessageBox.Show("Operation Success");
                        Reset();
                    }
                }
            }
            catch (Exception ex)
            {
                lblMessageBox.Text = ex.ToString();
                lblMessageBox.Enabled = true;
                lblMessageBox.ForeColor = Color.Red;
            }
        }
    }
}
