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
    public partial class Sales : Form
    {
        private IProduct _IProduct = null;
        private IProductPackSize _IProductPackSize = null;
        private IDMS_AreaStock _IDMS_AreaStock = null;
        public Sales()
        {
            InitializeComponent();
            _IProduct = new BLL.BProduct();
            _IProductPackSize = new BLL.BProductPackSize();
            _IDMS_AreaStock = new BLL.BDMS_AreaStock();
            COMMON.DDL.PopulateDropDownList(_IProduct.GetProductListByName().ToList(), ddlProductName, "ProductID", "ProductName");
            COMMON.DDL.PopulateDropDownList(_IProduct.GetProductListByCode().ToList(), ddlProductCode, "ProductID", "ProductCode");
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            new HomeSales().Show();
            this.Hide();
        }

        List<BO.Product> objProductList = new List<BO.Product>();
        private void ddlProductName_KeyDown(object sender, KeyEventArgs e)
        {
            long productID = 0;
            if (e.KeyCode == Keys.Enter)
            {
                productID = Convert.ToInt64(ddlProductName.SelectedValue);
                if (productID == 0)
                {
                    productID = Convert.ToInt64(ddlProductCode.SelectedValue);
                }
                BO.Product objProductInfo = _IProduct.GetProductList().FirstOrDefault(m => m.ProductId == productID);

                if (objProductList == null)
                {
                    objProductInfo.Sln = 1;
                }
                else
                {
                    objProductInfo.Sln = objProductList.Count + 1;
                }

                objProductList.Add(objProductInfo);

                grvProduct.AutoGenerateColumns = false;
                if (objProductList.Count > 0)
                {
                    if (grvProduct.RowCount > 0)
                    {
                        grvProduct.DataSource = null;
                    }
                    grvProduct.DataSource = objProductList;
                }
            }
        }

        private void grvProduct_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewCell dgvcell = (DataGridViewCell)grvProduct[e.ColumnIndex, e.RowIndex];
        }

        private void grvProduct_KeyDown(object sender, KeyEventArgs e)
        {
            foreach (var row in grvProduct.Rows)
            {
                //DataGridViewCell dgvcell = (DataGridViewCell)grvProduct[e.ColumnIndex, e.RowIndex];
                //decimal price = Convert.ToDecimal(grvProduct.Rows[e.RowIndex].Cells["MRP"].Value);
                //decimal quantity = Convert.ToDecimal(grvProduct.Rows[e.RowIndex].Cells["Quantity"].Value);
                //grvProduct.Rows[e.RowIndex].Cells["TotalPrice"].Value = price * quantity;
            }
        }
        private void grvProduct_CellLeave(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewCell dgvcell = (DataGridViewCell)grvProduct[e.ColumnIndex, e.RowIndex];
        }

        private void ddlProductCode_KeyDown(object sender, KeyEventArgs e)
        {
            long productID = 0;
            if (e.KeyCode == Keys.Enter)
            {
                productID = Convert.ToInt64(ddlProductCode.SelectedValue);
                if (productID == 0)
                {
                    productID = Convert.ToInt64(ddlProductName.SelectedValue);
                }
                BO.Product objProductInfo = _IProduct.GetProductList().FirstOrDefault(m => m.ProductId == productID);

                if (objProductList == null)
                {
                    objProductInfo.Sln = 1;
                }
                else
                {
                    objProductInfo.Sln = objProductList.Count + 1;
                }

                objProductList.Add(objProductInfo);

                grvProduct.AutoGenerateColumns = false;
                if (objProductList.Count > 0)
                {
                    if (grvProduct.RowCount > 0)
                    {
                        grvProduct.DataSource = null;
                    }
                    grvProduct.DataSource = objProductList;
                }
            }
        }

        private void txtInvoice_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                dateTimePicker1.Focus();
        }

        private void dateTimePicker1_KeyUp(object sender, KeyEventArgs e)
        {
                txtCustomer.Focus();
        }

        private void txtCustomer_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                ddlProductName.Focus();
        }

        private void ddlProductCode_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnSave.Focus();
        }
    }
}
