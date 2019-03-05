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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblMessageBox = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.grvBrand = new System.Windows.Forms.DataGridView();
            this.Sln = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Brand = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Edit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.txtBrand = new System.Windows.Forms.TextBox();
            this.lblBrndDescription = new System.Windows.Forms.Label();
            this.txtBrndDescription = new System.Windows.Forms.TextBox();
            this.lbl_Brand = new System.Windows.Forms.Label();
            this.lblBrand = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grvBrand)).BeginInit();
            this.SuspendLayout();
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
            this.btnBack.TabIndex = 26;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("Palatino Linotype", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.ForeColor = System.Drawing.Color.Black;
            this.btnReset.Location = new System.Drawing.Point(491, 331);
            this.btnReset.Margin = new System.Windows.Forms.Padding(2);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(180, 65);
            this.btnReset.TabIndex = 25;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            this.btnReset.KeyUp += new System.Windows.Forms.KeyEventHandler(this.btnReset_KeyUp);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Palatino Linotype", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.Black;
            this.btnSave.Location = new System.Drawing.Point(718, 331);
            this.btnSave.Margin = new System.Windows.Forms.Padding(2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(180, 65);
            this.btnSave.TabIndex = 24;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            this.btnSave.KeyUp += new System.Windows.Forms.KeyEventHandler(this.btnSave_KeyUp);
            // 
            // grvBrand
            // 
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grvBrand.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.grvBrand.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.grvBrand.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.grvBrand.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.grvBrand.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grvBrand.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.grvBrand.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grvBrand.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Sln,
            this.Brand,
            this.Description,
            this.Edit,
            this.Delete});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grvBrand.DefaultCellStyle = dataGridViewCellStyle3;
            this.grvBrand.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.grvBrand.Location = new System.Drawing.Point(429, 484);
            this.grvBrand.Name = "grvBrand";
            this.grvBrand.Size = new System.Drawing.Size(496, 236);
            this.grvBrand.TabIndex = 20;
            this.grvBrand.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grvBrand_CellClick);
            // 
            // Sln
            // 
            this.Sln.DataPropertyName = "Sln";
            this.Sln.HeaderText = "Sln";
            this.Sln.Name = "Sln";
            this.Sln.Width = 60;
            // 
            // Brand
            // 
            this.Brand.DataPropertyName = "BrandName";
            this.Brand.HeaderText = "Brand";
            this.Brand.Name = "Brand";
            this.Brand.Width = 81;
            // 
            // Description
            // 
            this.Description.DataPropertyName = "BrandDescription";
            this.Description.HeaderText = "Description";
            this.Description.Name = "Description";
            this.Description.Width = 122;
            // 
            // Edit
            // 
            this.Edit.DataPropertyName = "Edit";
            this.Edit.HeaderText = "Edit";
            this.Edit.Name = "Edit";
            this.Edit.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Edit.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Edit.Text = "Edit";
            this.Edit.UseColumnTextForButtonValue = true;
            this.Edit.Width = 66;
            // 
            // Delete
            // 
            this.Delete.DataPropertyName = "Delete";
            this.Delete.HeaderText = "Delete";
            this.Delete.Name = "Delete";
            this.Delete.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Delete.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Delete.Text = "Delete";
            this.Delete.UseColumnTextForButtonValue = true;
            this.Delete.Width = 83;
            // 
            // txtBrand
            // 
            this.txtBrand.Font = new System.Drawing.Font("Palatino Linotype", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBrand.ForeColor = System.Drawing.Color.Black;
            this.txtBrand.Location = new System.Drawing.Point(632, 136);
            this.txtBrand.Margin = new System.Windows.Forms.Padding(2);
            this.txtBrand.Name = "txtBrand";
            this.txtBrand.Size = new System.Drawing.Size(266, 47);
            this.txtBrand.TabIndex = 18;
            this.txtBrand.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtBrand_KeyUp);
            // 
            // lblBrndDescription
            // 
            this.lblBrndDescription.AutoSize = true;
            this.lblBrndDescription.Font = new System.Drawing.Font("Palatino Linotype", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBrndDescription.ForeColor = System.Drawing.Color.Black;
            this.lblBrndDescription.Location = new System.Drawing.Point(440, 208);
            this.lblBrndDescription.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBrndDescription.Name = "lblBrndDescription";
            this.lblBrndDescription.Size = new System.Drawing.Size(170, 39);
            this.lblBrndDescription.TabIndex = 23;
            this.lblBrndDescription.Text = "Description :";
            // 
            // txtBrndDescription
            // 
            this.txtBrndDescription.Font = new System.Drawing.Font("Palatino Linotype", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBrndDescription.ForeColor = System.Drawing.Color.Black;
            this.txtBrndDescription.Location = new System.Drawing.Point(632, 205);
            this.txtBrndDescription.Margin = new System.Windows.Forms.Padding(2);
            this.txtBrndDescription.Multiline = true;
            this.txtBrndDescription.Name = "txtBrndDescription";
            this.txtBrndDescription.Size = new System.Drawing.Size(266, 65);
            this.txtBrndDescription.TabIndex = 19;
            this.txtBrndDescription.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtBrndDescription_KeyUp);
            // 
            // lbl_Brand
            // 
            this.lbl_Brand.AutoSize = true;
            this.lbl_Brand.Font = new System.Drawing.Font("Palatino Linotype", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Brand.ForeColor = System.Drawing.Color.Black;
            this.lbl_Brand.Location = new System.Drawing.Point(440, 139);
            this.lbl_Brand.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Brand.Name = "lbl_Brand";
            this.lbl_Brand.Size = new System.Drawing.Size(167, 39);
            this.lbl_Brand.TabIndex = 22;
            this.lbl_Brand.Text = "Brand          :";
            // 
            // lblBrand
            // 
            this.lblBrand.AutoSize = true;
            this.lblBrand.Font = new System.Drawing.Font("Palatino Linotype", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBrand.Location = new System.Drawing.Point(363, 67);
            this.lblBrand.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBrand.Name = "lblBrand";
            this.lblBrand.Size = new System.Drawing.Size(213, 47);
            this.lblBrand.TabIndex = 21;
            this.lblBrand.Text = "Brand Entry";
            // 
            // BrandEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1433, 831);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.grvBrand);
            this.Controls.Add(this.txtBrand);
            this.Controls.Add(this.lblBrndDescription);
            this.Controls.Add(this.txtBrndDescription);
            this.Controls.Add(this.lbl_Brand);
            this.Controls.Add(this.lblBrand);
            this.Controls.Add(this.lblMessageBox);
            this.Name = "BrandEntry";
            this.Text = "BrandEntry";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.grvBrand)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblMessageBox;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.DataGridView grvBrand;
        private System.Windows.Forms.TextBox txtBrand;
        private System.Windows.Forms.Label lblBrndDescription;
        private System.Windows.Forms.TextBox txtBrndDescription;
        private System.Windows.Forms.Label lbl_Brand;
        private System.Windows.Forms.Label lblBrand;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sln;
        private System.Windows.Forms.DataGridViewTextBoxColumn Brand;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewButtonColumn Edit;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
    }
}