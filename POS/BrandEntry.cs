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
                
                if(btnSave.Text=="Update" && txtBrand.Text!="")
                {

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

      
        private void grvBrand_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


            //if (e.ColumnIndex == 6)
            //{
            //    empid = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells["Id"].Value);
            //    Form_Insert fm2 = new Form_Insert();
            //    fm2.Show();
            //}
            //if (e.ColumnIndex == 7)
            //{
            //    empid = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells["Id"].Value);
            //    SqlDataAdapter da = new SqlDataAdapter("delete from employee where Id = '" + empid + "'", con);
            //    DataSet ds = new DataSet();
            //    da.Fill(ds);
            //    displayDataGridView();
            //    dataGridView1.Refresh();
        }

        private void BrandEntry_Load(object sender, EventArgs e)
        {
            displayDataGridView();
        }
        public void displayDataGridView()
        {
            List<BO.Brand> brands = new List<BO.Brand>();
            brands = _IBrand.GetBrandList().ToList();
            grvBrand.AutoGenerateColumns = false;
            grvBrand.DataSource = brands;
           
            //grvBrand.AllowUserToAddRows = false;
            //using SqlDataAdapter da = new SqlDataAdapter(cmd);
            //grvBrand.DataSource=

            //SqlCommand cmd;
            //cmd = new SqlCommand("select * from Employee", con);
            //cmd.CommandType = CommandType.Text;
            //SqlDataAdapter da = new SqlDataAdapter(cmd);
            //DataSet ds = new DataSet();
            //da.Fill(ds);
            //dataGridView1.DataSource = ds.Tables[0];
            //dataGridView1.AutoGenerateColumns = false;
            //dataGridView1.AllowUserToAddRows = false;
        }
        protected void Edit_Click(object sender, EventArgs e)
        {
           // using (StdRegBLL StdData = new StdRegBLL())
                BO.Brand Brands = new BO.Brand();
            txtBrand.Text = Brands.BrandName;
            txtBrndDescription.Text = Brands.BrandDescription;

            _IBrand.Update(Brands);

           
           

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

        }

        private void grvBrand_CellClick(object sender, DataGridViewCellEventArgs e)
        {
          
            // Ignore clicks that are not in our 
            if (e.ColumnIndex == grvBrand.Columns["Delete"].Index && e.RowIndex >= 0)
            {

                lblMessageBox.Text="Execute";
            }
            if (e.ColumnIndex == grvBrand.Columns["Edit"].Index && e.RowIndex >= 0)
            {
                int numberRow = Convert.ToInt32(e.RowIndex);
                //assign the value plus the desired column example 1
                var BrandName = grvBrand.Rows[numberRow].Cells[0].Value;
                lblMessageBox.Text = "" + BrandName;
                //var BrandDescription = grvBrand.Rows[numberRow].Cells[2].Value;
                txtBrand.Text = Convert.ToString(grvBrand.Rows[numberRow].Cells[1].Value);
                txtBrndDescription.Text = Convert.ToString(grvBrand.Rows[numberRow].Cells[2].Value);
                //txtBrand.Text = ""+ BrandName;
                //txtBrndDescription.Text = "" + BrandDescription;
                btnSave.Text = "Update";
            }
        }
    }
}
