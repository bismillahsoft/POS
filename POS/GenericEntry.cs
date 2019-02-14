﻿using System;
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

        private void btnGene_Save_Click(object sender, EventArgs e)
        {
            try {
                BO.ProductGeneric ObjProductGeneric = new BO.ProductGeneric();

                ObjProductGeneric.GenericName = txtGenericName.Text;
                ObjProductGeneric.GenericDescription = txtGenericDescription.Text;


                if(_IProductGeneric.Insert(ObjProductGeneric)>0)
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
            txtGenericName.Text = "";
            txtGenericDescription.Text = "";
            GetGenericName();
        }
        private void btnGene_Reset_Click(object sender, EventArgs e)
        {
            try {

                Reset();
            } catch(Exception ex) { throw ex; }
        }
        private void GetGenericName()
        {
            List<BO.ProductGeneric> productGenerics = new List<BO.ProductGeneric>();

            productGenerics = _IProductGeneric.GetProductGenericList().ToList();
            grvGeneric.AutoGenerateColumns = false;
            grvGeneric.DataSource = productGenerics; 

        }
    }
}
