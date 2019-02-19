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
        private IProductGeneric _IProductGeneric = null;
        private IProductPackSize _IProductPackSize = null;
        private IBrand _Ibrand = null;
        private IProductCategory _IProductCategory = null;
        public ProductEntry()
        {
            InitializeComponent();
            _IProduct = new BLL.BProduct();
            _IProductPackSize = new BLL.BProductPackSize();
            _IProductGeneric = new BLL.BProductGeneric();
            _Ibrand = new BLL.BBrand();
            _IProductCategory = new BLL.BProductCategory();

            COMMON.DDL.PopulateDropDownList(_IProductGeneric.GetProductGenericList().ToList(), ddlGenericName, "GenericID", "GenericName");
            COMMON.DDL.PopulateDropDownList(_IProductPackSize.GetProductPackSizeList().ToList(), ddlPackSize, "PackSizeID", "PackSize");
            COMMON.DDL.PopulateDropDownList(_Ibrand.GetBrandList().ToList(), ddlBrand, "BrandID", "BrandName");
            COMMON.DDL.PopulateDropDownList(_IProductCategory.GetProductCategoryList().ToList(), ddlCategory, "ProductCategoryID", "CategoryName");
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


                if (txtPro_Name.Text != "")
                {
                    if (_IProduct.Insert(Objproducts) > 0)
                    {
                        lblMessageBox.Text = "Successfully Saved";
                        lblMessageBox.ForeColor = Color.Green;
                    }
                    else
                    {
                        lblMessageBox.Text = "Operation Failed";
                        lblMessageBox.ForeColor = Color.Red;
                    }
                }
                else
                {
                    lblMessageBox.Text = "Operation Failed";
                    lblMessageBox.ForeColor = Color.Red;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
