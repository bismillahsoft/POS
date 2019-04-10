namespace POS
{
    partial class Homeproduct
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
            this.btnSubBrand = new System.Windows.Forms.Button();
            this.lblEntry = new System.Windows.Forms.Label();
            this.btnSubBatch = new System.Windows.Forms.Button();
            this.btnSubGeneric = new System.Windows.Forms.Button();
            this.btnSubPackSize = new System.Windows.Forms.Button();
            this.btnSubCategory = new System.Windows.Forms.Button();
            this.btnSubProductEntry = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSubBrand
            // 
            this.btnSubBrand.Font = new System.Drawing.Font("Palatino Linotype", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubBrand.Location = new System.Drawing.Point(292, 144);
            this.btnSubBrand.Name = "btnSubBrand";
            this.btnSubBrand.Size = new System.Drawing.Size(380, 140);
            this.btnSubBrand.TabIndex = 1;
            this.btnSubBrand.Text = "Brand Entry";
            this.btnSubBrand.UseVisualStyleBackColor = true;
            this.btnSubBrand.Click += new System.EventHandler(this.btnSubBrand_Click);
            // 
            // lblEntry
            // 
            this.lblEntry.AutoSize = true;
            this.lblEntry.Font = new System.Drawing.Font("Palatino Linotype", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEntry.Location = new System.Drawing.Point(234, 57);
            this.lblEntry.Name = "lblEntry";
            this.lblEntry.Size = new System.Drawing.Size(198, 65);
            this.lblEntry.TabIndex = 1;
            this.lblEntry.Text = "Product";
            // 
            // btnSubBatch
            // 
            this.btnSubBatch.Font = new System.Drawing.Font("Palatino Linotype", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubBatch.Location = new System.Drawing.Point(292, 313);
            this.btnSubBatch.Name = "btnSubBatch";
            this.btnSubBatch.Size = new System.Drawing.Size(380, 140);
            this.btnSubBatch.TabIndex = 3;
            this.btnSubBatch.Text = "Batch Entry";
            this.btnSubBatch.UseVisualStyleBackColor = true;
            this.btnSubBatch.Click += new System.EventHandler(this.btnSubBatch_Click);
            // 
            // btnSubGeneric
            // 
            this.btnSubGeneric.Font = new System.Drawing.Font("Palatino Linotype", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubGeneric.Location = new System.Drawing.Point(292, 482);
            this.btnSubGeneric.Name = "btnSubGeneric";
            this.btnSubGeneric.Size = new System.Drawing.Size(380, 140);
            this.btnSubGeneric.TabIndex = 5;
            this.btnSubGeneric.Text = "Generic Name Entry";
            this.btnSubGeneric.UseVisualStyleBackColor = true;
            this.btnSubGeneric.Click += new System.EventHandler(this.btnSubGeneric_Click);
            // 
            // btnSubPackSize
            // 
            this.btnSubPackSize.Font = new System.Drawing.Font("Palatino Linotype", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubPackSize.Location = new System.Drawing.Point(700, 482);
            this.btnSubPackSize.Name = "btnSubPackSize";
            this.btnSubPackSize.Size = new System.Drawing.Size(380, 140);
            this.btnSubPackSize.TabIndex = 6;
            this.btnSubPackSize.Text = "Pack Size Entry";
            this.btnSubPackSize.UseVisualStyleBackColor = true;
            this.btnSubPackSize.Click += new System.EventHandler(this.btnSubPackSize_Click);
            // 
            // btnSubCategory
            // 
            this.btnSubCategory.Font = new System.Drawing.Font("Palatino Linotype", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubCategory.Location = new System.Drawing.Point(700, 313);
            this.btnSubCategory.Name = "btnSubCategory";
            this.btnSubCategory.Size = new System.Drawing.Size(380, 140);
            this.btnSubCategory.TabIndex = 4;
            this.btnSubCategory.Text = "Product Category Entry";
            this.btnSubCategory.UseVisualStyleBackColor = true;
            this.btnSubCategory.Click += new System.EventHandler(this.btnSubCategory_Click);
            // 
            // btnSubProductEntry
            // 
            this.btnSubProductEntry.Font = new System.Drawing.Font("Palatino Linotype", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubProductEntry.Location = new System.Drawing.Point(700, 144);
            this.btnSubProductEntry.Name = "btnSubProductEntry";
            this.btnSubProductEntry.Size = new System.Drawing.Size(380, 140);
            this.btnSubProductEntry.TabIndex = 2;
            this.btnSubProductEntry.Text = "Product Entry";
            this.btnSubProductEntry.UseVisualStyleBackColor = true;
            this.btnSubProductEntry.Click += new System.EventHandler(this.btnSubProductEntry_Click);
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Monotype Corsiva", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(12, 12);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(98, 54);
            this.btnBack.TabIndex = 7;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // Homeproduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnSubPackSize);
            this.Controls.Add(this.btnSubCategory);
            this.Controls.Add(this.btnSubProductEntry);
            this.Controls.Add(this.btnSubGeneric);
            this.Controls.Add(this.btnSubBatch);
            this.Controls.Add(this.lblEntry);
            this.Controls.Add(this.btnSubBrand);
            this.Name = "Homeproduct";
            this.Text = "Homeproduct";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSubBrand;
        private System.Windows.Forms.Label lblEntry;
        private System.Windows.Forms.Button btnSubBatch;
        private System.Windows.Forms.Button btnSubGeneric;
        private System.Windows.Forms.Button btnSubPackSize;
        private System.Windows.Forms.Button btnSubCategory;
        private System.Windows.Forms.Button btnSubProductEntry;
        private System.Windows.Forms.Button btnBack;
    }
}