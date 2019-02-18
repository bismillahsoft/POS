namespace POS
{
    partial class ProductCategory
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
            this.lblPCategory = new System.Windows.Forms.Label();
            this.grBox = new System.Windows.Forms.GroupBox();
            this.grvPCategory = new System.Windows.Forms.DataGridView();
            this.Sln = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CategoryName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblMessageBox = new System.Windows.Forms.Label();
            this.lblPCategoryName = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.bntSave = new System.Windows.Forms.Button();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.txtCategoryName = new System.Windows.Forms.TextBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.grBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grvPCategory)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPCategory
            // 
            this.lblPCategory.AutoSize = true;
            this.lblPCategory.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPCategory.Location = new System.Drawing.Point(497, 284);
            this.lblPCategory.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPCategory.Name = "lblPCategory";
            this.lblPCategory.Size = new System.Drawing.Size(187, 22);
            this.lblPCategory.TabIndex = 10;
            this.lblPCategory.Text = "Product Category Entry";
            // 
            // grBox
            // 
            this.grBox.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.grBox.Controls.Add(this.lblPCategory);
            this.grBox.Controls.Add(this.btnBack);
            this.grBox.Controls.Add(this.grvPCategory);
            this.grBox.Controls.Add(this.lblMessageBox);
            this.grBox.Controls.Add(this.lblPCategoryName);
            this.grBox.Controls.Add(this.lblDescription);
            this.grBox.Controls.Add(this.bntSave);
            this.grBox.Controls.Add(this.txtDescription);
            this.grBox.Controls.Add(this.btnReset);
            this.grBox.Controls.Add(this.txtCategoryName);
            this.grBox.Location = new System.Drawing.Point(0, 0);
            this.grBox.Margin = new System.Windows.Forms.Padding(2);
            this.grBox.Name = "grBox";
            this.grBox.Padding = new System.Windows.Forms.Padding(2);
            this.grBox.Size = new System.Drawing.Size(1431, 839);
            this.grBox.TabIndex = 11;
            this.grBox.TabStop = false;
            // 
            // grvPCategory
            // 
            this.grvPCategory.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.grvPCategory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grvPCategory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Sln,
            this.CategoryName,
            this.Description});
            this.grvPCategory.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.grvPCategory.Location = new System.Drawing.Point(152, 324);
            this.grvPCategory.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grvPCategory.Name = "grvPCategory";
            this.grvPCategory.Size = new System.Drawing.Size(404, 209);
            this.grvPCategory.TabIndex = 5;
            // 
            // Sln
            // 
            this.Sln.DataPropertyName = "Sln";
            this.Sln.HeaderText = "Sln";
            this.Sln.Name = "Sln";
            // 
            // CategoryName
            // 
            this.CategoryName.DataPropertyName = "Name";
            this.CategoryName.HeaderText = "Category Name";
            this.CategoryName.Name = "CategoryName";
            // 
            // Description
            // 
            this.Description.DataPropertyName = "BatchDescription";
            this.Description.HeaderText = "Description";
            this.Description.Name = "Description";
            // 
            // lblMessageBox
            // 
            this.lblMessageBox.AutoSize = true;
            this.lblMessageBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMessageBox.Location = new System.Drawing.Point(229, 18);
            this.lblMessageBox.Name = "lblMessageBox";
            this.lblMessageBox.Size = new System.Drawing.Size(0, 13);
            this.lblMessageBox.TabIndex = 17;
            // 
            // lblPCategoryName
            // 
            this.lblPCategoryName.AutoSize = true;
            this.lblPCategoryName.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPCategoryName.Location = new System.Drawing.Point(195, 59);
            this.lblPCategoryName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPCategoryName.Name = "lblPCategoryName";
            this.lblPCategoryName.Size = new System.Drawing.Size(101, 13);
            this.lblPCategoryName.TabIndex = 1;
            this.lblPCategoryName.Text = "Category Name :";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.Location = new System.Drawing.Point(195, 112);
            this.lblDescription.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(79, 13);
            this.lblDescription.TabIndex = 2;
            this.lblDescription.Text = "Description :";
            // 
            // bntSave
            // 
            this.bntSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntSave.Location = new System.Drawing.Point(355, 219);
            this.bntSave.Margin = new System.Windows.Forms.Padding(2);
            this.bntSave.Name = "bntSave";
            this.bntSave.Size = new System.Drawing.Size(145, 50);
            this.bntSave.TabIndex = 3;
            this.bntSave.Text = "Save";
            this.bntSave.UseVisualStyleBackColor = true;
            this.bntSave.Click += new System.EventHandler(this.bntSave_Click);
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(339, 108);
            this.txtDescription.Margin = new System.Windows.Forms.Padding(2);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(160, 68);
            this.txtDescription.TabIndex = 2;
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(197, 219);
            this.btnReset.Margin = new System.Windows.Forms.Padding(2);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(145, 50);
            this.btnReset.TabIndex = 4;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            // 
            // txtCategoryName
            // 
            this.txtCategoryName.Location = new System.Drawing.Point(339, 54);
            this.txtCategoryName.Margin = new System.Windows.Forms.Padding(2);
            this.txtCategoryName.Name = "txtCategoryName";
            this.txtCategoryName.Size = new System.Drawing.Size(160, 22);
            this.txtCategoryName.TabIndex = 1;
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Monotype Corsiva", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(27, 240);
            this.btnBack.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(114, 66);
            this.btnBack.TabIndex = 12;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // ProductCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1433, 831);
            this.Controls.Add(this.grBox);
            this.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ProductCategory";
            this.Text = "ProductCategory";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ProductCategory_Load);
            this.grBox.ResumeLayout(false);
            this.grBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grvPCategory)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblPCategory;
        private System.Windows.Forms.GroupBox grBox;
        private System.Windows.Forms.Label lblPCategoryName;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Button bntSave;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.TextBox txtCategoryName;
        private System.Windows.Forms.Label lblMessageBox;
        private System.Windows.Forms.DataGridView grvPCategory;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sln;
        private System.Windows.Forms.DataGridViewTextBoxColumn CategoryName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.Button btnBack;
    }
}