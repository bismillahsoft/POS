using POS.IDAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace POS
{
    public partial class BrandEntry : Form
    {
        int ID;
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
                //ObjBrand.BrandID = Convert.ToInt16(lblMessageBox.Text);

                ObjBrand.BrandName = txtBrand.Text;
                ObjBrand.BrandDescription = txtBrndDescription.Text;
                
                if(btnSave.Text=="Update" && txtBrand.Text!="")
                {
                    ObjBrand.BrandID = Convert.ToInt16(lblMessageBox.Text);
                    if (_IBrand.Update(ObjBrand) > 0)
                    {
                        MessageBox.Show("Successfully Update");
                        Reset();
                    }
                    else
                    {
                        MessageBox.Show("Update Failed !");
                    }
                }
                else if (txtBrand.Text!="")
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
                        MessageBox.Show("Operation Failed");
                        //lblMessageBox.Text = "Operation Failed";
                        //lblMessageBox.ForeColor = System.Drawing.Color.Red;
                        // lblMessageBox.Font.Bold = true;
                    }
                }
                else
                {
                    MsgBox msgBox = new MsgBox();
                    msgBox.Show();
                   // MessageBox.Show("Please Fill Up Required Fill..!");
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
            btnSave.Text = "Save";
            GetBrand();
        }
        private void GetBrand()
        {

            List<BO.Brand> brands = new List<BO.Brand>();
            brands = _IBrand.GetBrandList().ToList();
            grvBrand.AutoGenerateColumns = false;
            grvBrand.DataSource = brands;
        }
        private void BrandEntry_Load(object sender, EventArgs e)

        {
           
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            new Homeproduct().Show();
            this.Hide();
        }
        private void txtBrand_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                txtBrndDescription.Focus();
        }
        private void txtBrndDescription_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnSave.Focus();
        }
        private void btnReset_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnBack.Focus();
        }
        private void btnSave_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnReset.Focus();
        }
        private void btnReset_Click(object sender, EventArgs e)
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
        private void grvBrand_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Ignore clicks that are not in our 
            try
            {
                if (e.ColumnIndex == grvBrand.Columns["Delete"].Index && e.RowIndex >= 0)
                {
                    int numberRow = Convert.ToInt32(e.RowIndex);
                    //assign the value plus the desired column example 1
                    int ID = Convert.ToInt32(grvBrand.Rows[numberRow].Cells[0].Value.ToString());
                    if (_IBrand.Delete(ID) > 0)
                    {
                        MessageBox.Show("Operation Success");
                        Reset();
                    }
                }
                if (e.ColumnIndex == grvBrand.Columns["Edit"].Index && e.RowIndex >= 0)
                {
                    int numberRow = Convert.ToInt32(e.RowIndex);
                    //assign the value plus the desired column example 1
                    int ID = Convert.ToInt32(grvBrand.Rows[numberRow].Cells[0].Value.ToString());
                    txtBrand.Text = Convert.ToString(grvBrand.Rows[numberRow].Cells[2].Value);
                    txtBrndDescription.Text = Convert.ToString(grvBrand.Rows[numberRow].Cells[3].Value);
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
    }
}