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
        int ID;
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
            bntSave.Text = "Save";
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

                if(bntSave.Text=="Update" && txtCategoryName.Text != "")
                {
                    ObjProductCategory.Id = Convert.ToInt32(lblMessageBox.Text);
                    if (_IProductCategory.Update(ObjProductCategory) > 0)
                    {
                        MessageBox.Show("Successfully Update");
                        Reset();
                    }
                }
                else if (ObjProductCategory.Name != "")
                {
                    if (_IProductCategory.Insert(ObjProductCategory) > 0)
                    {
                        MessageBox.Show("Operation Success");
                        Reset();
                    }
                    else
                    {
                        lblMessageBox.Text = "Operation Failed";
                        lblMessageBox.ForeColor = System.Drawing.Color.Red;
                    }
                }
                else
                {
                    MsgBox msgbox = new MsgBox();
                    msgbox.Show();
                    txtCategoryName.Focus();
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
            txtCategoryName.Focus();
        }
        private void GetProductCategory()
        {
            List<BO.ProductCategory> productCategories = new List<BO.ProductCategory>();
            productCategories = _IProductCategory.GetProductCategoryList().ToList();
            grvCategory.AutoGenerateColumns = false;
            grvCategory.DataSource = productCategories;
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
        private void grvCategory_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex == grvCategory.Columns["Edit"].Index && e.RowIndex >= 0)
                {
                    int numberRow = Convert.ToInt32(e.RowIndex);
                    int ID =Convert.ToInt32(grvCategory.Rows[numberRow].Cells[0].Value.ToString());
                    //lblMessageBox.Text = ID;
                    txtCategoryName.Text = Convert.ToString(grvCategory.Rows[numberRow].Cells[2].Value);
                    txtDescription.Text = Convert.ToString(grvCategory.Rows[numberRow].Cells[3].Value);
                    bntSave.Text = "Update";
                }
            }
            catch (Exception ex)
            {
                lblMessageBox.Text = ex.ToString();
                lblMessageBox.Enabled = true;
                lblMessageBox.ForeColor = Color.Red;
            }
            try
            {
                if (e.ColumnIndex == grvCategory.Columns["Delete"].Index && e.RowIndex >= 0)
                {
                    int numberRow = Convert.ToInt32(e.RowIndex);
                    int ID = Convert.ToInt32(grvCategory.Rows[numberRow].Cells[0].Value.ToString());
                    if (_IProductCategory.Delete(ID) > 0)
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
