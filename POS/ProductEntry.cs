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
        private IProduct _IProduct = null;
        private IProductPackSize _IProductPackSize = null;
        private IBrand _Ibrand = null;
        private IProductGeneric _IProductGeneric = null;
        private IProductCategory _IProductCategory = null;
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
            //COMMON.DDL.PopulateDropDownList(_IProductCategory.GetProductCategoryList().ToList(), ddlCategory,"","");
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
                BO.Product Objproducts = new BO.Product();

                Objproducts.ProductName = txtPro_Name.Text;
                Objproducts.ProdPackSize.ProductCode = txtProductCode.Text;
                Objproducts.ProdPackSize.PackSizeID = Convert.ToInt32(ddlPackSize.SelectedValue);
                Objproducts.Brand.BrandID = Convert.ToInt32(ddlBrand.SelectedValue);
                Objproducts.ProductGeneric.PGenericID = Convert.ToInt32(ddlGenericName.SelectedValue);
                Objproducts.ProductCategory.Id = Convert.ToInt32(ddlCategory.SelectedValue);
                Objproducts.ProductPrice.TradePrice = Convert.ToDecimal(txtTradePrice.Text);
                Objproducts.ProductPrice.PurchasePrice = Convert.ToDecimal(txtPurchesePrice.Text);
                Objproducts.ProductPrice.Vat = Convert.ToDecimal(txtVat.Text);
                Objproducts.ProductPrice.MRP = Convert.ToDecimal(txtMRP.Text);
                Objproducts.BatchNo = Convert.ToString(txtBatch.Text);
                Objproducts.Description = txtDescription.Text;


                if (txtPro_Name.Text != "" && txtProductCode.Text!="" && txtTradePrice.Text!="" && txtPurchesePrice.Text!="" && txtVat.Text!="" && txtMRP.Text!="" && txtBatch.Text!="")
                {
                    if (_IProduct.Insert(Objproducts) > 0)
                    {
                        MessageBox.Show("Successfully Saved");
                        //lblMessageBox.Text = "Successfully Saved";
                        //lblMessageBox.ForeColor = Color.Green;
                        GetProductList();
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
            GetProductList();
        }
        private void btnReset_Click(object sender, EventArgs e)
        {
            Reset();
        }
    }
}
