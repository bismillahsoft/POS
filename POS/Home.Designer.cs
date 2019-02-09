namespace POS
{
    partial class Home
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
            this.Logout = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnReport = new System.Windows.Forms.Button();
            this.btnInventory = new System.Windows.Forms.Button();
            this.btnSales = new System.Windows.Forms.Button();
            this.btnProduct = new System.Windows.Forms.Button();
            this.lblPosSystem = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Logout
            // 
            this.Logout.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Logout.Location = new System.Drawing.Point(899, -113);
            this.Logout.Margin = new System.Windows.Forms.Padding(2);
            this.Logout.Name = "Logout";
            this.Logout.Size = new System.Drawing.Size(56, 28);
            this.Logout.TabIndex = 2;
            this.Logout.Text = "Log Out";
            this.Logout.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.btnReport);
            this.panel1.Controls.Add(this.btnInventory);
            this.panel1.Controls.Add(this.btnSales);
            this.panel1.Controls.Add(this.btnProduct);
            this.panel1.Location = new System.Drawing.Point(-336, -73);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1597, 1060);
            this.panel1.TabIndex = 3;
            // 
            // btnReport
            // 
            this.btnReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReport.Image = global::POS.Properties.Resources.Report;
            this.btnReport.Location = new System.Drawing.Point(696, 415);
            this.btnReport.Margin = new System.Windows.Forms.Padding(2);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(208, 215);
            this.btnReport.TabIndex = 4;
            this.btnReport.Text = "Report";
            this.btnReport.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnReport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnReport.UseVisualStyleBackColor = true;
            // 
            // btnInventory
            // 
            this.btnInventory.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInventory.Image = global::POS.Properties.Resources.Inventory;
            this.btnInventory.Location = new System.Drawing.Point(908, 415);
            this.btnInventory.Margin = new System.Windows.Forms.Padding(2);
            this.btnInventory.Name = "btnInventory";
            this.btnInventory.Size = new System.Drawing.Size(208, 215);
            this.btnInventory.TabIndex = 3;
            this.btnInventory.Text = "Inventory";
            this.btnInventory.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnInventory.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnInventory.UseVisualStyleBackColor = true;
            // 
            // btnSales
            // 
            this.btnSales.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSales.Image = global::POS.Properties.Resources.Sales;
            this.btnSales.Location = new System.Drawing.Point(696, 192);
            this.btnSales.Margin = new System.Windows.Forms.Padding(2);
            this.btnSales.Name = "btnSales";
            this.btnSales.Size = new System.Drawing.Size(208, 215);
            this.btnSales.TabIndex = 2;
            this.btnSales.Text = "Sales";
            this.btnSales.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSales.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnSales.UseVisualStyleBackColor = true;
            // 
            // btnProduct
            // 
            this.btnProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProduct.Image = global::POS.Properties.Resources.Product;
            this.btnProduct.Location = new System.Drawing.Point(908, 192);
            this.btnProduct.Margin = new System.Windows.Forms.Padding(2);
            this.btnProduct.Name = "btnProduct";
            this.btnProduct.Size = new System.Drawing.Size(208, 215);
            this.btnProduct.TabIndex = 0;
            this.btnProduct.Text = "Product";
            this.btnProduct.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnProduct.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnProduct.UseVisualStyleBackColor = true;
            // 
            // lblPosSystem
            // 
            this.lblPosSystem.AutoSize = true;
            this.lblPosSystem.Font = new System.Drawing.Font("Palatino Linotype", 16.2F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPosSystem.Location = new System.Drawing.Point(323, -111);
            this.lblPosSystem.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPosSystem.Name = "lblPosSystem";
            this.lblPosSystem.Size = new System.Drawing.Size(127, 29);
            this.lblPosSystem.TabIndex = 4;
            this.lblPosSystem.Text = "Pos System";
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1262, 882);
            this.Controls.Add(this.Logout);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblPosSystem);
            this.Name = "Home";
            this.Text = "Home";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Logout;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnReport;
        private System.Windows.Forms.Button btnInventory;
        private System.Windows.Forms.Button btnSales;
        private System.Windows.Forms.Button btnProduct;
        private System.Windows.Forms.Label lblPosSystem;
    }
}