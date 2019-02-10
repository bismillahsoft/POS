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
            this.lblPCategoryName = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.bntSave = new System.Windows.Forms.Button();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.txtCategoryName = new System.Windows.Forms.TextBox();
            this.grBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblPCategory
            // 
            this.lblPCategory.AutoSize = true;
            this.lblPCategory.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPCategory.Location = new System.Drawing.Point(76, 52);
            this.lblPCategory.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPCategory.Name = "lblPCategory";
            this.lblPCategory.Size = new System.Drawing.Size(187, 22);
            this.lblPCategory.TabIndex = 10;
            this.lblPCategory.Text = "Product Category Entry";
            // 
            // grBox
            // 
            this.grBox.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.grBox.Controls.Add(this.lblPCategoryName);
            this.grBox.Controls.Add(this.lblDescription);
            this.grBox.Controls.Add(this.bntSave);
            this.grBox.Controls.Add(this.txtDescription);
            this.grBox.Controls.Add(this.btnReset);
            this.grBox.Controls.Add(this.txtCategoryName);
            this.grBox.Location = new System.Drawing.Point(79, 76);
            this.grBox.Margin = new System.Windows.Forms.Padding(2);
            this.grBox.Name = "grBox";
            this.grBox.Padding = new System.Windows.Forms.Padding(2);
            this.grBox.Size = new System.Drawing.Size(314, 251);
            this.grBox.TabIndex = 11;
            this.grBox.TabStop = false;
            // 
            // lblPCategoryName
            // 
            this.lblPCategoryName.AutoSize = true;
            this.lblPCategoryName.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPCategoryName.Location = new System.Drawing.Point(20, 41);
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
            this.lblDescription.Location = new System.Drawing.Point(20, 84);
            this.lblDescription.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(79, 13);
            this.lblDescription.TabIndex = 2;
            this.lblDescription.Text = "Description :";
            // 
            // bntSave
            // 
            this.bntSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntSave.Location = new System.Drawing.Point(157, 171);
            this.bntSave.Margin = new System.Windows.Forms.Padding(2);
            this.bntSave.Name = "bntSave";
            this.bntSave.Size = new System.Drawing.Size(124, 41);
            this.bntSave.TabIndex = 3;
            this.bntSave.Text = "Save";
            this.bntSave.UseVisualStyleBackColor = true;
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(144, 81);
            this.txtDescription.Margin = new System.Windows.Forms.Padding(2);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(138, 56);
            this.txtDescription.TabIndex = 6;
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(22, 171);
            this.btnReset.Margin = new System.Windows.Forms.Padding(2);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(124, 41);
            this.btnReset.TabIndex = 4;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            // 
            // txtCategoryName
            // 
            this.txtCategoryName.Location = new System.Drawing.Point(144, 37);
            this.txtCategoryName.Margin = new System.Windows.Forms.Padding(2);
            this.txtCategoryName.Name = "txtCategoryName";
            this.txtCategoryName.Size = new System.Drawing.Size(138, 20);
            this.txtCategoryName.TabIndex = 5;
            // 
            // ProductCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 379);
            this.Controls.Add(this.lblPCategory);
            this.Controls.Add(this.grBox);
            this.Name = "ProductCategory";
            this.Text = "ProductCategory";
            this.grBox.ResumeLayout(false);
            this.grBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

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
    }
}