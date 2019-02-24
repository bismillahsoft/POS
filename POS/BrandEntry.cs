using POS.IDAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace POS
{
    public partial class BrandEntry : Form
    {
        #region Global Declaration
        private IBrand _IBrand = null;


        #endregion
        public BrandEntry()
        {
            InitializeComponent();
            
           _IBrand = new BLL.BBrand();
            Reset();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                BO.Brand ObjBrand = new BO.Brand();

                ObjBrand.BrandName = txtBrand.Text;
                ObjBrand.BrandDescription = txtBrndDescription.Text;
                if (txtBrand.Text!="")
                {
                    if (_IBrand.Insert(ObjBrand) > 0)
                    {
                        MessageBox.Show("Operation Success");
                        

                       // lblMessageBox.Text = "Operation Success";
                      //  lblMessageBox.ForeColor = System.Drawing.Color.Green;
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
                    MessageBox.Show("Please Fill Up Required Fill..!");
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
            GetBrand();
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
        private void GetBrand()
        {

            List<BO.Brand> brands = new List<BO.Brand>();
            brands = _IBrand.GetBrandList().ToList();
            grvBrand.AutoGenerateColumns = false;
            grvBrand.DataSource = brands;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            new Homeproduct().Show();
            this.Hide();
        }

        private void grvBrand_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
