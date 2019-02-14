namespace POS
{
    partial class BrandEntry
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
            this.btnReset = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblBrndDescription = new System.Windows.Forms.Label();
            this.lbl_Brand = new System.Windows.Forms.Label();
            this.lblBrand = new System.Windows.Forms.Label();
            this.grBox = new System.Windows.Forms.GroupBox();
            this.grvBrand = new System.Windows.Forms.DataGridView();
            this.Sln = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Brand = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtBrand = new System.Windows.Forms.TextBox();
            this.txtBrndDescription = new System.Windows.Forms.TextBox();
            this.lblMessageBox = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.grBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grvBrand)).BeginInit();
            this.SuspendLayout();
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(260, 253);
            this.btnReset.Margin = new System.Windows.Forms.Padding(2);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(124, 41);
            this.btnReset.TabIndex = 12;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click_);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(392, 253);
            this.btnSave.Margin = new System.Windows.Forms.Padding(2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(124, 41);
            this.btnSave.TabIndex = 11;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblBrndDescription
            // 
            this.lblBrndDescription.AutoSize = true;
            this.lblBrndDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBrndDescription.Location = new System.Drawing.Point(164, 176);
            this.lblBrndDescription.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBrndDescription.Name = "lblBrndDescription";
            this.lblBrndDescription.Size = new System.Drawing.Size(79, 13);
            this.lblBrndDescription.TabIndex = 10;
            this.lblBrndDescription.Text = "Description :";
            // 
            // lbl_Brand
            // 
            this.lbl_Brand.AutoSize = true;
            this.lbl_Brand.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Brand.Location = new System.Drawing.Point(162, 121);
            this.lbl_Brand.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Brand.Name = "lbl_Brand";
            this.lbl_Brand.Size = new System.Drawing.Size(84, 13);
            this.lbl_Brand.TabIndex = 9;
            this.lbl_Brand.Text = "Brand          :";
            // 
            // lblBrand
            // 
            this.lblBrand.AutoSize = true;
            this.lblBrand.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBrand.Location = new System.Drawing.Point(124, 56);
            this.lblBrand.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBrand.Name = "lblBrand";
            this.lblBrand.Size = new System.Drawing.Size(102, 22);
            this.lblBrand.TabIndex = 8;
            this.lblBrand.Text = "Brand Entry";
            // 
            // grBox
            // 
            this.grBox.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.grBox.Controls.Add(this.grvBrand);
            this.grBox.Controls.Add(this.txtBrand);
            this.grBox.Controls.Add(this.txtBrndDescription);
            this.grBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.grBox.Location = new System.Drawing.Point(128, 80);
            this.grBox.Margin = new System.Windows.Forms.Padding(2);
            this.grBox.Name = "grBox";
            this.grBox.Padding = new System.Windows.Forms.Padding(2);
            this.grBox.Size = new System.Drawing.Size(487, 463);
            this.grBox.TabIndex = 13;
            this.grBox.TabStop = false;
            // 
            // grvBrand
            // 
            this.grvBrand.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grvBrand.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Sln,
            this.Brand,
            this.Description});
            this.grvBrand.Location = new System.Drawing.Point(62, 272);
            this.grvBrand.Name = "grvBrand";
            this.grvBrand.Size = new System.Drawing.Size(350, 150);
            this.grvBrand.TabIndex = 5;
            // 
            // Sln
            // 
            this.Sln.DataPropertyName = "Sln";
            this.Sln.HeaderText = "Sln";
            this.Sln.Name = "Sln";
            // 
            // Brand
            // 
            this.Brand.DataPropertyName = "BrandName";
            this.Brand.HeaderText = "Brand";
            this.Brand.Name = "Brand";
            // 
            // Description
            // 
            this.Description.DataPropertyName = "BrandDescription";
            this.Description.HeaderText = "Description";
            this.Description.Name = "Description";
            // 
            // txtBrand
            // 
            this.txtBrand.Location = new System.Drawing.Point(181, 37);
            this.txtBrand.Margin = new System.Windows.Forms.Padding(2);
            this.txtBrand.Name = "txtBrand";
            this.txtBrand.Size = new System.Drawing.Size(231, 20);
            this.txtBrand.TabIndex = 3;
            // 
            // txtBrndDescription
            // 
            this.txtBrndDescription.Location = new System.Drawing.Point(181, 89);
            this.txtBrndDescription.Margin = new System.Windows.Forms.Padding(2);
            this.txtBrndDescription.Multiline = true;
            this.txtBrndDescription.Name = "txtBrndDescription";
            this.txtBrndDescription.Size = new System.Drawing.Size(231, 59);
            this.txtBrndDescription.TabIndex = 4;
            // 
            // lblMessageBox
            // 
            this.lblMessageBox.AutoSize = true;
            this.lblMessageBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMessageBox.Location = new System.Drawing.Point(267, 93);
            this.lblMessageBox.Name = "lblMessageBox";
            this.lblMessageBox.Size = new System.Drawing.Size(0, 13);
            this.lblMessageBox.TabIndex = 14;
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Monotype Corsiva", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(12, 12);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(98, 54);
            this.btnBack.TabIndex = 17;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // BrandEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(716, 604);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lblMessageBox);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblBrndDescription);
            this.Controls.Add(this.lbl_Brand);
            this.Controls.Add(this.lblBrand);
            this.Controls.Add(this.grBox);
            this.Name = "BrandEntry";
            this.Text = "BrandEntry";
            this.grBox.ResumeLayout(false);
            this.grBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grvBrand)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblBrndDescription;
        private System.Windows.Forms.Label lbl_Brand;
        private System.Windows.Forms.Label lblBrand;
        private System.Windows.Forms.GroupBox grBox;
        private System.Windows.Forms.TextBox txtBrand;
        private System.Windows.Forms.TextBox txtBrndDescription;
        private System.Windows.Forms.Label lblMessageBox;
        private System.Windows.Forms.DataGridView grvBrand;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sln;
        private System.Windows.Forms.DataGridViewTextBoxColumn Brand;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.Button btnBack;
    }
}