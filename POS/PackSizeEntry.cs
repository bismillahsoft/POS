using System.Windows.Forms;
using System;
using POS.IDAL;
using System.Drawing;

namespace POS
{
    public partial class PackSizeEntry : Form
    {
        #region Global Declaration
        private IProductPackSize IProductPackSize = null;
        #endregion
        public PackSizeEntry()
        {
            InitializeComponent();
            IProductPackSize = new BLL.BProductPackSize();
        }
        private void bntSave_Click(object sender, EventArgs e)
        {
            try
            {
                BO.ProductPackSize ObjProductPackSize = new BO.ProductPackSize();

                ObjProductPackSize.PackSize = txtPackSize.Text;
                ObjProductPackSize.PackSizeDescription = txtDescription.Text;


                if (IProductPackSize.Insert(ObjProductPackSize) > 0)
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
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private void Reset()
        {
            txtPackSize.Text = "";
            txtDescription.Text = "";
        }
        private void btnReset_Click(object sender, EventArgs e)
        {
            try
            {
                Reset();
            }
            catch (Exception ex) { throw ex; }
        }
    }
}
