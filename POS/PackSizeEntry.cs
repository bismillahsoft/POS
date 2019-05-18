using System.Windows.Forms;
using System;
using System.Linq;
using System.Collections.Generic;
using POS.IDAL;
using System.Drawing;

namespace POS
{
    public partial class PackSizeEntry : Form
    {
        int ID;
        #region Global Declaration
        private IProductPackSize _IProductPackSize = null;
        #endregion
        public PackSizeEntry()
        {
            InitializeComponent();
            _IProductPackSize = new BLL.BProductPackSize();
            Reset();
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                BO.ProductPackSize ObjProductPackSize = new BO.ProductPackSize();

                ObjProductPackSize.PackSize = txtPackSize.Text;
                ObjProductPackSize.Strip = Convert.ToInt32(txtStrip.Text);
                ObjProductPackSize.PcsPerStrip = Convert.ToInt32(txtPcsPerStrip.Text);
                ObjProductPackSize.PackSizeDescription = txtDescription.Text;

                if(btnSave.Text=="Update"&& txtPackSize.Text != "")
                {
                    ObjProductPackSize.PackSizeID = ID;
                    if (_IProductPackSize.Update(ObjProductPackSize) > 0)
                    {
                        MessageBox.Show("Successfully Update");
                        Reset();
                    }
                }

                else if (txtPackSize.Text != "")
                {

                    if (_IProductPackSize.Insert(ObjProductPackSize) > 0)
                    {
                        //MessageBox.Show("Operation Success");
                        MsgBox msgbox = new MsgBox();
                        msgbox.Show();
                        //lblMessageBox.Text = "Operation Success";
                        //lblMessageBox.ForeColor = Color.Green;
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
                    //  MessageBox.Show("Please Fill Up Require Fill..!");
                    txtPackSize.Focus();
                    //lblMessageBox.Text = "Please Fill Up Require Fill..!";
                    //lblMessageBox.ForeColor = Color.Blue;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private void Reset()
        {
            txtPackSize.Text = "";
            txtStrip.Text = "";
            txtPcsPerStrip.Text = "";
            txtDescription.Text = "";
            btnSave.Text = "Save";
            GetPackSizeList();
        }
        private void btnReset_Click(object sender, EventArgs e)
        {
            try
            {
                Reset();
            }
            catch (Exception ex) { throw ex; }
        }
        private void GetPackSizeList()
        {
            List<BO.ProductPackSize> productPackSize = new List<BO.ProductPackSize>();
            productPackSize = _IProductPackSize.GetProductPackSizeList().ToList();
            grvPackSize.AutoGenerateColumns = false;
            grvPackSize.DataSource = productPackSize;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            new Homeproduct().Show();
            this.Hide();
        }

        private void txtPackSize_KeyUp(object sender, KeyEventArgs e)
        {
           if( e.KeyCode == Keys.Enter)
            txtStrip.Focus();
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

        private void grvPackSize_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                BO.ProductPackSize ObjProductPackSize = new BO.ProductPackSize();
                if (e.ColumnIndex == grvPackSize.Columns["Edit"].Index && e.RowIndex >= 0)
                {
                    int numberRow = Convert.ToInt32(e.RowIndex);
                    ID =Convert.ToInt32(grvPackSize.Rows[numberRow].Cells[0].Value.ToString());
                  
                    ObjProductPackSize = _IProductPackSize.GetProductPackSizeList().FirstOrDefault(m => m.PackSizeID == ID);
                    
                    txtPackSize.Text = Convert.ToString(ObjProductPackSize.PackSize);
                    txtStrip.Text = Convert.ToString(ObjProductPackSize.Strip);
                    txtDescription.Text = Convert.ToString(ObjProductPackSize.PackSizeDescription);
                    txtPcsPerStrip.Text = Convert.ToString(ObjProductPackSize.PcsPerStrip);
                    //txtPackSize.Text = Convert.ToString(grvPackSize.Rows[numberRow].Cells[2].Value);
                    //txtStrip.Text = Convert.ToString(grvPackSize.Rows[numberRow].Cells[3].Value);
                    //txtPcsPerStrip.Text = Convert.ToString(grvPackSize.Rows[numberRow].Cells[4]);
                    //txtDescription.Text = Convert.ToString(grvPackSize.Rows[numberRow].Cells[5].Value);
                    btnSave.Text = "Update";
                }
                if (e.ColumnIndex == grvPackSize.Columns["Delete"].Index && e.RowIndex >= 0)
                {
                    int numberRow = Convert.ToInt32(e.RowIndex);
                    ID = Convert.ToInt32(grvPackSize.Rows[numberRow].Cells[0].Value.ToString());
                    if (_IProductPackSize.Delete(ID) > 0)
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

        private void txtStrip_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                txtPcsPerStrip.Focus();
        }

        private void txtPcsPerStrip_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                txtDescription.Focus();
        }
    }
}
