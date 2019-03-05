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
                        MessageBox.Show("Operation Success");
                        //MsgBox msgbox = new MsgBox();
                        //msgbox.Show();
                      //  lblMessageBox.Text = "Operation Success";
                      //  lblMessageBox.ForeColor = Color.Green;
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
                    MsgBox msgbox = new MsgBox();
                    msgbox.Show();
                    txtCategoryName.Focus();
                   // lblMessageBox.Text = "Operation Failed";
                  //  lblMessageBox.ForeColor = System.Drawing.Color.Red;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void ProductCategory_Load(object sender, EventArgs e)
        {
            txtCategoryName.Focus();
        }

        private void GetProductCategory()
        {
            List<BO.ProductCategory> productCategories = new List<BO.ProductCategory>();
            productCategories = _IProductCategory.GetProductCategoryList().ToList();
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = productCategories;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            new Homeproduct().Show();
            this.Hide();
        }
        private void txtCategoryName_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtDescription.Focus();
            }
        }

        private void txtDescription_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                bntSave.Focus();
            }
        }

        private void bntSave_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnReset.Focus();
            }
        }

        private void btnReset_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnBack.Focus();
            }
        }
    }
}
