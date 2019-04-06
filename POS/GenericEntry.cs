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
    public partial class GenericEntry : Form
    {
        #region Global Declaration
        private IProductGeneric _IProductGeneric = null;
        #endregion
        public GenericEntry()
        {
            InitializeComponent();
            _IProductGeneric = new BLL.BProductGeneric();
            Reset();
        }
        int GenericID;
        private void btnGene_Save_Click(object sender, EventArgs e)
        {
            try
            {
                BO.ProductGeneric ObjProductGeneric = new BO.ProductGeneric();

                ObjProductGeneric.GenericName = txtGenericName.Text;
                ObjProductGeneric.GenericDescription = txtGenericDescription.Text;

                if (btnGene_Save.Text == "Update" && ObjProductGeneric.GenericName != "")
                {
                    ObjProductGeneric.PGenericID = GenericID;
                    if (_IProductGeneric.Update(ObjProductGeneric) > 0)
                    {
                        MessageBox.Show("Successfully Update");
                        Reset();
                    }
                }
                else if (ObjProductGeneric.GenericName != "")
                {
                    if (_IProductGeneric.Insert(ObjProductGeneric) > 0)
                    {
                        MessageBox.Show("Operation Success");
                        Reset();
                    }
                    else
                    {
                        MessageBox.Show("Operation Failed");
                    }
                }
                else
                {
                    MsgBox msgBox = new MsgBox();
                    msgBox.Show();
                }
            }
            catch (Exception ex)
            {
                lblMessageBox.Text = ex.ToString();
                lblMessageBox.Enabled = true;
                lblMessageBox.ForeColor = Color.Red;
            }
        }
        private void Reset()
        {
            txtGenericName.Text = "";
            txtGenericDescription.Text = "";
            btnGene_Save.Text = "Save";
            GetGenericName();
        }
        private void btnGene_Reset_Click(object sender, EventArgs e)
        {
            try
            {
                Reset();
            }
            catch (Exception ex)
            {
                lblMessageBox.Text = ex.ToString();
                lblMessageBox.Enabled = true;
                lblMessageBox.ForeColor = Color.Red;
            }
        }
        private void GetGenericName()
        {
            List<BO.ProductGeneric> productGenerics = new List<BO.ProductGeneric>();

            productGenerics = _IProductGeneric.GetProductGenericList().ToList();
            grvGeneric.AutoGenerateColumns = false;
            grvGeneric.DataSource = productGenerics;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            try
            {
                new Homeproduct().Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                lblMessageBox.Text = ex.ToString();
                lblMessageBox.Enabled = true;
                lblMessageBox.ForeColor = Color.Red;
            }
        }
        private void txtGenericName_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtGenericDescription.Focus();
            }
        }
        private void txtGenericDescription_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnGene_Save.Focus();
            }
        }
        private void btnGene_Save_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnGene_Reset.Focus();
        }
        private void btnGene_Reset_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnBack.Focus();
        }
        private void grvGeneric_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex == grvGeneric.Columns["Edit"].Index && e.RowIndex >= 0)
                {
                    int numberRow = Convert.ToInt32(e.RowIndex);
                    GenericID = Convert.ToInt32(grvGeneric.Rows[numberRow].Cells[0].Value.ToString());
                    //lblMessageBox.Text = GenericID.ToString();
                    txtGenericName.Text = Convert.ToString(grvGeneric.Rows[numberRow].Cells[2].Value);
                    txtGenericDescription.Text = Convert.ToString(grvGeneric.Rows[numberRow].Cells[3].Value);
                    btnGene_Save.Text = "Update";
                }
                if (e.ColumnIndex == grvGeneric.Columns["Delete"].Index && e.RowIndex >= 0)
                {
                    int numberRow = Convert.ToInt32(e.RowIndex);
                    GenericID = Convert.ToInt32(grvGeneric.Rows[numberRow].Cells[0].Value.ToString());

                    if (_IProductGeneric.Delete(GenericID) > 0)
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
    }
}
