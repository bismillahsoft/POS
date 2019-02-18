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
    public partial class BatchEntry : Form
    {
        #region Global Declaration
        private IProductBatch _IProductBatch = null;
        #endregion
        public BatchEntry()
        {
            InitializeComponent();
            txtBatchNo.Focus();
            _IProductBatch = new BLL.BProductBatch();
            Reset();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                BO.ProductBatch ObjProductBatch = new BO.ProductBatch();

                ObjProductBatch.BatchNo = txtBatchNo.Text;
                ObjProductBatch.BatchName = txtBatchName.Text;
                ObjProductBatch.BatchDescription = txtBatchDescription.Text;
                if (ObjProductBatch.BatchNo != "" && ObjProductBatch.BatchName != "")
                {
                    if (_IProductBatch.Insert(ObjProductBatch) > 0)
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
        private void Reset()
        {
            txtBatchNo.Text = "";
            txtBatchName.Text = "";
            txtBatchDescription.Text = "";
            GetProductBatch();
        }
        private void btnReset_Click(object sender, EventArgs e)
        {
            try
            {
                Reset();
            }
            catch (Exception ex) { throw ex; }
        }
        private void GetProductBatch()
        {
            List<BO.ProductBatch> productBatches = new List<BO.ProductBatch>();
            productBatches = _IProductBatch.GetProductBatchList().ToList();
            grvBatchEntry.AutoGenerateColumns = false;
            grvBatchEntry.DataSource = productBatches;
        }
        private void grvBatchEntry_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            new Homeproduct().Show();
            this.Hide();
        }
        private void txtBatchNo_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtBatchName.Focus();
            }
        }
        private void txtBatchName_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }
        private void txtBatchName_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtBatchDescription.Focus();
            }
        }
        private void txtBatchDescription_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtBatchDescription.Focus();
            }
        }
        private void btnSave_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnBack.Focus();
            }
        }
    }
}
