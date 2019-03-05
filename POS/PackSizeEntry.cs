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
                ObjProductPackSize.PackSizeDescription = txtDescription.Text;

                if (txtPackSize.Text != "")
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
            txtDescription.Text = "";
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
    }
}
