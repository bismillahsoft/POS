﻿namespace POS
{
    partial class ProductEntry
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblP_Entry = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Sln = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PackSize = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Brand = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Vat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtVat = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.ddlGenericName = new System.Windows.Forms.ComboBox();
            this.lblVat = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.txtTradePrice = new System.Windows.Forms.TextBox();
            this.ddlBrand = new System.Windows.Forms.ComboBox();
            this.lblTradePrice = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtPurchesePrice = new System.Windows.Forms.TextBox();
            this.ddlPackSize = new System.Windows.Forms.ComboBox();
            this.lblPurchesePrice = new System.Windows.Forms.Label();
            this.lblPro_Code = new System.Windows.Forms.Label();
            this.txtProductCode = new System.Windows.Forms.TextBox();
            this.lblPro_Name = new System.Windows.Forms.Label();
            this.lblGenericName = new System.Windows.Forms.Label();
            this.txtPro_Name = new System.Windows.Forms.TextBox();
            this.lblPackSize = new System.Windows.Forms.Label();
            this.lblBrand = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(97, 280);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 13);
            this.label7.TabIndex = 30;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(97, 159);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 29;
            // 
            // lblP_Entry
            // 
            this.lblP_Entry.AutoSize = true;
            this.lblP_Entry.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblP_Entry.Location = new System.Drawing.Point(42, 17);
            this.lblP_Entry.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblP_Entry.Name = "lblP_Entry";
            this.lblP_Entry.Size = new System.Drawing.Size(115, 22);
            this.lblP_Entry.TabIndex = 28;
            this.lblP_Entry.Text = "Product Entry";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Controls.Add(this.txtVat);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtDescription);
            this.groupBox1.Controls.Add(this.ddlGenericName);
            this.groupBox1.Controls.Add(this.lblVat);
            this.groupBox1.Controls.Add(this.btnReset);
            this.groupBox1.Controls.Add(this.txtTradePrice);
            this.groupBox1.Controls.Add(this.ddlBrand);
            this.groupBox1.Controls.Add(this.lblTradePrice);
            this.groupBox1.Controls.Add(this.btnSave);
            this.groupBox1.Controls.Add(this.txtPurchesePrice);
            this.groupBox1.Controls.Add(this.ddlPackSize);
            this.groupBox1.Controls.Add(this.lblPurchesePrice);
            this.groupBox1.Controls.Add(this.lblPro_Code);
            this.groupBox1.Controls.Add(this.txtProductCode);
            this.groupBox1.Controls.Add(this.lblPro_Name);
            this.groupBox1.Controls.Add(this.lblGenericName);
            this.groupBox1.Controls.Add(this.txtPro_Name);
            this.groupBox1.Controls.Add(this.lblPackSize);
            this.groupBox1.Controls.Add(this.lblBrand);
            this.groupBox1.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(40, 46);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(773, 496);
            this.groupBox1.TabIndex = 31;
            this.groupBox1.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Sln,
            this.ProductName,
            this.ProductCode,
            this.PackSize,
            this.Brand,
            this.GName,
            this.PPrice,
            this.TPrice,
            this.Vat});
            this.dataGridView1.Location = new System.Drawing.Point(31, 327);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(708, 122);
            this.dataGridView1.TabIndex = 23;
            // 
            // Sln
            // 
            this.Sln.HeaderText = "Sln";
            this.Sln.Name = "Sln";
            // 
            // ProductName
            // 
            this.ProductName.HeaderText = "Product Name";
            this.ProductName.Name = "ProductName";
            // 
            // ProductCode
            // 
            this.ProductCode.HeaderText = "Product Code";
            this.ProductCode.Name = "ProductCode";
            // 
            // PackSize
            // 
            this.PackSize.HeaderText = "Pack Size";
            this.PackSize.Name = "PackSize";
            // 
            // Brand
            // 
            this.Brand.HeaderText = "Brand";
            this.Brand.Name = "Brand";
            // 
            // GName
            // 
            this.GName.HeaderText = "G.Name";
            this.GName.Name = "GName";
            // 
            // PPrice
            // 
            this.PPrice.HeaderText = "P.Price";
            this.PPrice.Name = "PPrice";
            // 
            // TPrice
            // 
            this.TPrice.HeaderText = "T.Price";
            this.TPrice.Name = "TPrice";
            // 
            // Vat
            // 
            this.Vat.HeaderText = "Vat";
            this.Vat.Name = "Vat";
            // 
            // txtVat
            // 
            this.txtVat.Location = new System.Drawing.Point(525, 168);
            this.txtVat.Margin = new System.Windows.Forms.Padding(2);
            this.txtVat.Name = "txtVat";
            this.txtVat.Size = new System.Drawing.Size(157, 29);
            this.txtVat.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(83, 220);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Description :";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(188, 220);
            this.txtDescription.Margin = new System.Windows.Forms.Padding(2);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(157, 47);
            this.txtDescription.TabIndex = 8;
            // 
            // ddlGenericName
            // 
            this.ddlGenericName.FormattingEnabled = true;
            this.ddlGenericName.Location = new System.Drawing.Point(188, 119);
            this.ddlGenericName.Margin = new System.Windows.Forms.Padding(2);
            this.ddlGenericName.Name = "ddlGenericName";
            this.ddlGenericName.Size = new System.Drawing.Size(157, 30);
            this.ddlGenericName.TabIndex = 4;
            // 
            // lblVat
            // 
            this.lblVat.AutoSize = true;
            this.lblVat.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVat.Location = new System.Drawing.Point(420, 168);
            this.lblVat.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblVat.Name = "lblVat";
            this.lblVat.Size = new System.Drawing.Size(34, 13);
            this.lblVat.TabIndex = 22;
            this.lblVat.Text = "Vat :";
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(422, 225);
            this.btnReset.Margin = new System.Windows.Forms.Padding(2);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(125, 41);
            this.btnReset.TabIndex = 10;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            // 
            // txtTradePrice
            // 
            this.txtTradePrice.Location = new System.Drawing.Point(188, 168);
            this.txtTradePrice.Margin = new System.Windows.Forms.Padding(2);
            this.txtTradePrice.Name = "txtTradePrice";
            this.txtTradePrice.Size = new System.Drawing.Size(157, 29);
            this.txtTradePrice.TabIndex = 6;
            // 
            // ddlBrand
            // 
            this.ddlBrand.FormattingEnabled = true;
            this.ddlBrand.Location = new System.Drawing.Point(525, 74);
            this.ddlBrand.Margin = new System.Windows.Forms.Padding(2);
            this.ddlBrand.Name = "ddlBrand";
            this.ddlBrand.Size = new System.Drawing.Size(157, 30);
            this.ddlBrand.TabIndex = 3;
            // 
            // lblTradePrice
            // 
            this.lblTradePrice.AutoSize = true;
            this.lblTradePrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTradePrice.Location = new System.Drawing.Point(83, 168);
            this.lblTradePrice.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTradePrice.Name = "lblTradePrice";
            this.lblTradePrice.Size = new System.Drawing.Size(81, 13);
            this.lblTradePrice.TabIndex = 19;
            this.lblTradePrice.Text = "Trade Price :";
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(555, 225);
            this.btnSave.Margin = new System.Windows.Forms.Padding(2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(125, 41);
            this.btnSave.TabIndex = 9;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // txtPurchesePrice
            // 
            this.txtPurchesePrice.Location = new System.Drawing.Point(525, 121);
            this.txtPurchesePrice.Margin = new System.Windows.Forms.Padding(2);
            this.txtPurchesePrice.Name = "txtPurchesePrice";
            this.txtPurchesePrice.Size = new System.Drawing.Size(157, 29);
            this.txtPurchesePrice.TabIndex = 5;
            // 
            // ddlPackSize
            // 
            this.ddlPackSize.FormattingEnabled = true;
            this.ddlPackSize.Location = new System.Drawing.Point(188, 76);
            this.ddlPackSize.Margin = new System.Windows.Forms.Padding(2);
            this.ddlPackSize.Name = "ddlPackSize";
            this.ddlPackSize.Size = new System.Drawing.Size(157, 30);
            this.ddlPackSize.TabIndex = 2;
            // 
            // lblPurchesePrice
            // 
            this.lblPurchesePrice.AutoSize = true;
            this.lblPurchesePrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPurchesePrice.Location = new System.Drawing.Point(420, 121);
            this.lblPurchesePrice.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPurchesePrice.Name = "lblPurchesePrice";
            this.lblPurchesePrice.Size = new System.Drawing.Size(101, 13);
            this.lblPurchesePrice.TabIndex = 17;
            this.lblPurchesePrice.Text = "Purchese Price :";
            // 
            // lblPro_Code
            // 
            this.lblPro_Code.AutoSize = true;
            this.lblPro_Code.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPro_Code.Location = new System.Drawing.Point(420, 33);
            this.lblPro_Code.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPro_Code.Name = "lblPro_Code";
            this.lblPro_Code.Size = new System.Drawing.Size(92, 13);
            this.lblPro_Code.TabIndex = 8;
            this.lblPro_Code.Text = "Product Code :";
            // 
            // txtProductCode
            // 
            this.txtProductCode.Location = new System.Drawing.Point(525, 33);
            this.txtProductCode.Margin = new System.Windows.Forms.Padding(2);
            this.txtProductCode.Name = "txtProductCode";
            this.txtProductCode.Size = new System.Drawing.Size(157, 29);
            this.txtProductCode.TabIndex = 11;
            // 
            // lblPro_Name
            // 
            this.lblPro_Name.AutoSize = true;
            this.lblPro_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPro_Name.Location = new System.Drawing.Point(83, 33);
            this.lblPro_Name.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPro_Name.Name = "lblPro_Name";
            this.lblPro_Name.Size = new System.Drawing.Size(91, 13);
            this.lblPro_Name.TabIndex = 1;
            this.lblPro_Name.Text = "Product Name:";
            // 
            // lblGenericName
            // 
            this.lblGenericName.AutoSize = true;
            this.lblGenericName.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGenericName.Location = new System.Drawing.Point(83, 121);
            this.lblGenericName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblGenericName.Name = "lblGenericName";
            this.lblGenericName.Size = new System.Drawing.Size(95, 13);
            this.lblGenericName.TabIndex = 15;
            this.lblGenericName.Text = "Generic Name :";
            // 
            // txtPro_Name
            // 
            this.txtPro_Name.Location = new System.Drawing.Point(188, 33);
            this.txtPro_Name.Margin = new System.Windows.Forms.Padding(2);
            this.txtPro_Name.Name = "txtPro_Name";
            this.txtPro_Name.Size = new System.Drawing.Size(157, 29);
            this.txtPro_Name.TabIndex = 1;
            // 
            // lblPackSize
            // 
            this.lblPackSize.AutoSize = true;
            this.lblPackSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPackSize.Location = new System.Drawing.Point(83, 79);
            this.lblPackSize.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPackSize.Name = "lblPackSize";
            this.lblPackSize.Size = new System.Drawing.Size(72, 13);
            this.lblPackSize.TabIndex = 10;
            this.lblPackSize.Text = "Pack Size :";
            // 
            // lblBrand
            // 
            this.lblBrand.AutoSize = true;
            this.lblBrand.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBrand.Location = new System.Drawing.Point(420, 76);
            this.lblBrand.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBrand.Name = "lblBrand";
            this.lblBrand.Size = new System.Drawing.Size(48, 13);
            this.lblBrand.TabIndex = 12;
            this.lblBrand.Text = "Brand :";
            // 
            // ProductEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 644);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblP_Entry);
            this.Controls.Add(this.groupBox1);
            this.Name = "ProductEntry";
            this.Text = "ProductEntry";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblP_Entry;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sln;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn PackSize;
        private System.Windows.Forms.DataGridViewTextBoxColumn Brand;
        private System.Windows.Forms.DataGridViewTextBoxColumn GName;
        private System.Windows.Forms.DataGridViewTextBoxColumn PPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn TPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn Vat;
        private System.Windows.Forms.TextBox txtVat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.ComboBox ddlGenericName;
        private System.Windows.Forms.Label lblVat;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.TextBox txtTradePrice;
        private System.Windows.Forms.ComboBox ddlBrand;
        private System.Windows.Forms.Label lblTradePrice;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtPurchesePrice;
        private System.Windows.Forms.ComboBox ddlPackSize;
        private System.Windows.Forms.Label lblPurchesePrice;
        private System.Windows.Forms.Label lblPro_Code;
        private System.Windows.Forms.TextBox txtProductCode;
        private System.Windows.Forms.Label lblPro_Name;
        private System.Windows.Forms.Label lblGenericName;
        private System.Windows.Forms.TextBox txtPro_Name;
        private System.Windows.Forms.Label lblPackSize;
        private System.Windows.Forms.Label lblBrand;
    }
}