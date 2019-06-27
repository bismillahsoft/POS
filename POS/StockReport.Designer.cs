namespace POS
{
    partial class StockReport
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
            this.grvStockReport = new System.Windows.Forms.DataGridView();
            this.Sln = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PackSize = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ctn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pcs = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StockDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblP_Entry = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grvStockReport)).BeginInit();
            this.SuspendLayout();
            // 
            // grvStockReport
            // 
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grvStockReport.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.grvStockReport.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.grvStockReport.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.grvStockReport.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grvStockReport.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.grvStockReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grvStockReport.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Sln,
            this.ID,
            this.ProductName,
            this.ProductCode,
            this.PackSize,
            this.Price,
            this.Ctn,
            this.Pcs,
            this.TotalQty,
            this.StockDate});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grvStockReport.DefaultCellStyle = dataGridViewCellStyle3;
            this.grvStockReport.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.grvStockReport.Location = new System.Drawing.Point(173, 183);
            this.grvStockReport.Name = "grvStockReport";
            this.grvStockReport.Size = new System.Drawing.Size(975, 326);
            this.grvStockReport.TabIndex = 5;
            this.grvStockReport.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grvStockReport_CellContentClick);
            // 
            // Sln
            // 
            this.Sln.DataPropertyName = "Sln";
            this.Sln.HeaderText = "Sln";
            this.Sln.Name = "Sln";
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.Visible = false;
            // 
            // ProductName
            // 
            this.ProductName.DataPropertyName = "ProductName";
            this.ProductName.HeaderText = "Product Name";
            this.ProductName.Name = "ProductName";
            // 
            // ProductCode
            // 
            this.ProductCode.DataPropertyName = "ProductCode";
            this.ProductCode.HeaderText = "Product Code";
            this.ProductCode.Name = "ProductCode";
            // 
            // PackSize
            // 
            this.PackSize.DataPropertyName = "PackSize";
            this.PackSize.HeaderText = "PackSize";
            this.PackSize.Name = "PackSize";
            // 
            // Price
            // 
            this.Price.DataPropertyName = "PP";
            this.Price.HeaderText = "Price";
            this.Price.Name = "Price";
            // 
            // Ctn
            // 
            this.Ctn.DataPropertyName = "CtnOrPkt";
            this.Ctn.HeaderText = "Ctn";
            this.Ctn.Name = "Ctn";
            // 
            // Pcs
            // 
            this.Pcs.DataPropertyName = "Pcs";
            this.Pcs.HeaderText = "Pcs";
            this.Pcs.Name = "Pcs";
            // 
            // TotalQty
            // 
            this.TotalQty.DataPropertyName = "Qty";
            this.TotalQty.HeaderText = "Total Qty";
            this.TotalQty.Name = "TotalQty";
            // 
            // StockDate
            // 
            this.StockDate.DataPropertyName = "StockDate";
            this.StockDate.HeaderText = "Stock Date";
            this.StockDate.Name = "StockDate";
            // 
            // lblP_Entry
            // 
            this.lblP_Entry.AutoSize = true;
            this.lblP_Entry.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblP_Entry.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblP_Entry.Location = new System.Drawing.Point(204, 72);
            this.lblP_Entry.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblP_Entry.Name = "lblP_Entry";
            this.lblP_Entry.Size = new System.Drawing.Size(138, 28);
            this.lblP_Entry.TabIndex = 67;
            this.lblP_Entry.Text = "Stock Report";
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Monotype Corsiva", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnBack.Location = new System.Drawing.Point(12, 12);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(98, 54);
            this.btnBack.TabIndex = 66;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // StockReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1347, 749);
            this.Controls.Add(this.lblP_Entry);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.grvStockReport);
            this.Name = "StockReport";
            this.Text = "StockReport";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.grvStockReport)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView grvStockReport;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sln;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn PackSize;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ctn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pcs;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn StockDate;
        private System.Windows.Forms.Label lblP_Entry;
        private System.Windows.Forms.Button btnBack;
    }
}