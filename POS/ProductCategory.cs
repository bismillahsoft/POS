using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using POS.IDAL;
namespace POS
{
    public partial class ProductCategory : Form
    {
        private IProductCategory _IProductCategory = null;
        public ProductCategory()
        {
            InitializeComponent();
            _IProductCategory = new BLL.BProductCategory();
            Reset();
        }
        private void Reset()
        {
            txtCategoryName.Text = "";
            txtDescription.Text = "";
            GetProductCategory();
        }
        private void btnReset_Click(object sender, EventArgs e)
        {
            try
            {
                Reset();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void bntSave_Click(object sender, EventArgs e)
        {
            try
            {
                BO.ProductCategory ObjProductCategory = new BO.ProductCategory();
                ObjProductCategory.Name = txtCategoryName.Text;
                ObjProductCategory.Description = txtDescription.Text;

                if (ObjProductCategory.Name != "")
                {
                    if (_IProductCategory.Insert(ObjProductCategory) > 0)
                    {
                        lblMessageBox.Text = "Operation Success";
                        lblMessageBox.ForeColor = Color.Green;
                        // GetBrand();
                        Reset();
                    }
                    else
                    {
                        lblMessageBox.Text = "Operation Failed";
                        lblMessageBox.ForeColor = System.Drawing.Color.Red;
                        // lblMessageBox.Font.Bold = true;
                    }
                }
                else
                {
                    lblMessageBox.Text = "Operation Failed";
                    lblMessageBox.ForeColor = System.Drawing.Color.Red;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void ProductCategory_Load(object sender, EventArgs e)
        {

        }

        private void GetProductCategory()
        {
            List<BO.ProductCategory> productCategories = new List<BO.ProductCategory>();
            productCategories = _IProductCategory.GetProductCategoryList().ToList();
            grvPCategory.AutoGenerateColumns = false;
            grvPCategory.DataSource = productCategories;
        }

    }
}
