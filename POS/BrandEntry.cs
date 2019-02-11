using POS.IDAL;
using System;
using System.Windows.Forms;

namespace POS
{
    public partial class BrandEntry : Form
    {
        #region Global Declaration
        private IBrand IBrand = null;


        #endregion
        public BrandEntry()
        {
            InitializeComponent();
            
           IBrand = new BLL.BBrand();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                BO.Brand ObjBrand = new BO.Brand();

                ObjBrand.BrandName = txtBrand.Text;
                ObjBrand.BrandDescription = txtBrndDescription.Text;

               


                if (IBrand.Insert(ObjBrand) > 0)
                {
                    lblMessageBox.Text = "Operation Success";
                    lblMessageBox.ForeColor = System.Drawing.Color.Green;
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
            txtBrand.Text = "";
            txtBrndDescription.Text = "";
        }

        protected void btnReset_Click_(object sender, EventArgs e)
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
    }
}
