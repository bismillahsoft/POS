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
        int ID;
        public BatchEntry()
        {
            InitializeComponent();
            txtBatchName.Focus();
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

                if (btnSave.Text == "Update" && ObjProductBatch.BatchName != "")
                {
                    ObjProductBatch.BatchID = ID;
                    if (_IProductBatch.Update(ObjProductBatch) > 0)
                    {
                        MessageBox.Show("Successfully Update");
                        Reset();
                    }
                    else
                    {
                        MessageBox.Show("Update Failed");
                        Reset();
                    }
                }

                else if (ObjProductBatch.BatchNo != "" && ObjProductBatch.BatchName != "")
                {
                    if (_IProductBatch.Insert(ObjProductBatch) > 0)
                    {
                        MessageBox.Show("Operation Success");
                        // lblMessageBox.Text = "Operation Success";
                        // lblMessageBox.ForeColor = Color.Green;
                        // GetBrand();
                        Reset();
                    }
                    else
                    {
                        MessageBox.Show("Operation Failed");
                        // lblMessageBox.Text = "Operation Failed";
                        // lblMessageBox.ForeColor = System.Drawing.Color.Red;
                        // lblMessageBox.Font.Bold = true;
                    }
                }
                else
                {
                    MsgBox msgBox = new MsgBox();
                    msgBox.Show();
                    //lblMessageBox.Text = "Operation Failed";
                    //lblMessageBox.ForeColor = System.Drawing.Color.Red;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private void Reset()
        {
            txtBatchName.Text = "";
            txtBatchNo.Text = "";
            txtBatchDescription.Text = "";
            GetProductBatch();
            btnSave.Text = "Save";
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
                txtBatchNo.Focus();
            }
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
                btnSave.Focus();
            }
        }
        private void btnSave_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
              
            }
        }
        private void btnReset_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnBack.Focus();
        }

        private void grvBatchEntry_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex == grvBatchEntry.Columns["Delete"].Index && e.RowIndex >= 0)
                {
                    int numberRow = Convert.ToInt32(e.RowIndex);
                    ID = Convert.ToInt32(grvBatchEntry.Rows[numberRow].Cells[0].Value.ToString());
                    if (_IProductBatch.Delete(ID) > 0)
                    {
                        MessageBox.Show("Operation Sucess");
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
            try
            {
                if (e.ColumnIndex == grvBatchEntry.Columns["Edit"].Index && e.RowIndex >= 0)
                {
                    int numberRow = Convert.ToInt32(e.RowIndex);
                    ID = Convert.ToInt32(grvBatchEntry.Rows[numberRow].Cells[0].Value.ToString());
                    //lblMessageBox.Text = ID;
                    txtBatchName.Text = Convert.ToString(grvBatchEntry.Rows[numberRow].Cells[2].Value);
                    txtBatchNo.Text = Convert.ToString(grvBatchEntry.Rows[numberRow].Cells[3].Value);
                    txtBatchDescription.Text = Convert.ToString(grvBatchEntry.Rows[numberRow].Cells[4].Value);
                    btnSave.Text = "Update";
                }
            }
            catch (Exception ex)
            {
                lblMessageBox.Text = ex.ToString();
                lblMessageBox.Enabled = true;
                lblMessageBox.ForeColor = Color.Red;
            }
        }
        private void lblBrndDescription_Click(object sender, EventArgs e)
        {

        }

        private void lblBatchName_Click(object sender, EventArgs e)
        {

        }

        private void lbl_Batch_Click(object sender, EventArgs e)
        {

        }

        private void txtBatchName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtBatchDescription_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
