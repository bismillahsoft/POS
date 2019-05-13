namespace POS
{
    partial class StockEntry
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
            this.lblStockEntry = new System.Windows.Forms.Label();
            this.lblProductName = new System.Windows.Forms.Label();
            this.lblPackSIze = new System.Windows.Forms.Label();
            this.lblCStock = new System.Windows.Forms.Label();
            this.lbl = new System.Windows.Forms.Label();
            this.ddlProduct = new System.Windows.Forms.ComboBox();
            this.ddlPackSize = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtCsCtn = new System.Windows.Forms.TextBox();
            this.txtCsPcs = new System.Windows.Forms.TextBox();
            this.txtCsQty = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTsCtnPkt = new System.Windows.Forms.TextBox();
            this.txtTsPcs = new System.Windows.Forms.TextBox();
            this.txtTsQty = new System.Windows.Forms.TextBox();
            this.txtCtnPkt = new System.Windows.Forms.TextBox();
            this.txtPcs = new System.Windows.Forms.TextBox();
            this.txtQty = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.TransactionDate = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // lblStockEntry
            // 
            this.lblStockEntry.AutoSize = true;
            this.lblStockEntry.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStockEntry.Location = new System.Drawing.Point(189, 91);
            this.lblStockEntry.Name = "lblStockEntry";
            this.lblStockEntry.Size = new System.Drawing.Size(126, 28);
            this.lblStockEntry.TabIndex = 0;
            this.lblStockEntry.Text = "Stock Entry";
            // 
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.lblProductName.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductName.Location = new System.Drawing.Point(202, 156);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(104, 23);
            this.lblProductName.TabIndex = 1;
            this.lblProductName.Text = "Product Name";
            // 
            // lblPackSIze
            // 
            this.lblPackSIze.AutoSize = true;
            this.lblPackSIze.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPackSIze.Location = new System.Drawing.Point(581, 156);
            this.lblPackSIze.Name = "lblPackSIze";
            this.lblPackSIze.Size = new System.Drawing.Size(71, 23);
            this.lblPackSIze.TabIndex = 1;
            this.lblPackSIze.Text = "Pack Size";
            // 
            // lblCStock
            // 
            this.lblCStock.AutoSize = true;
            this.lblCStock.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCStock.Location = new System.Drawing.Point(205, 240);
            this.lblCStock.Name = "lblCStock";
            this.lblCStock.Size = new System.Drawing.Size(103, 23);
            this.lblCStock.TabIndex = 1;
            this.lblCStock.Text = "Current Stock";
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl.Location = new System.Drawing.Point(400, 211);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(65, 23);
            this.lbl.TabIndex = 1;
            this.lbl.Text = "Ctn/Pkt";
            // 
            // ddlProduct
            // 
            this.ddlProduct.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ddlProduct.FormattingEnabled = true;
            this.ddlProduct.Location = new System.Drawing.Point(349, 156);
            this.ddlProduct.Name = "ddlProduct";
            this.ddlProduct.Size = new System.Drawing.Size(188, 31);
            this.ddlProduct.TabIndex = 1;
            this.ddlProduct.SelectedIndexChanged += new System.EventHandler(this.ddlProduct_SelectedIndexChanged);
            this.ddlProduct.KeyUp += new System.Windows.Forms.KeyEventHandler(this.ddlProduct_KeyUp);
            // 
            // ddlPackSize
            // 
            this.ddlPackSize.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ddlPackSize.FormattingEnabled = true;
            this.ddlPackSize.Location = new System.Drawing.Point(677, 153);
            this.ddlPackSize.Name = "ddlPackSize";
            this.ddlPackSize.Size = new System.Drawing.Size(188, 31);
            this.ddlPackSize.TabIndex = 2;
            this.ddlPackSize.SelectedIndexChanged += new System.EventHandler(this.ddlPackSize_SelectedIndexChanged);
            this.ddlPackSize.KeyUp += new System.Windows.Forms.KeyEventHandler(this.ddlPackSize_KeyUp);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(673, 211);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 23);
            this.label3.TabIndex = 1;
            this.label3.Text = "Pcs";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(892, 211);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(36, 23);
            this.label9.TabIndex = 1;
            this.label9.Text = "Qty";
            // 
            // txtCsCtn
            // 
            this.txtCsCtn.Enabled = false;
            this.txtCsCtn.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCsCtn.Location = new System.Drawing.Point(349, 237);
            this.txtCsCtn.Name = "txtCsCtn";
            this.txtCsCtn.Size = new System.Drawing.Size(188, 29);
            this.txtCsCtn.TabIndex = 15;
            // 
            // txtCsPcs
            // 
            this.txtCsPcs.Enabled = false;
            this.txtCsPcs.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCsPcs.Location = new System.Drawing.Point(598, 237);
            this.txtCsPcs.Name = "txtCsPcs";
            this.txtCsPcs.Size = new System.Drawing.Size(188, 29);
            this.txtCsPcs.TabIndex = 16;
            // 
            // txtCsQty
            // 
            this.txtCsQty.Enabled = false;
            this.txtCsQty.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCsQty.Location = new System.Drawing.Point(825, 237);
            this.txtCsQty.Name = "txtCsQty";
            this.txtCsQty.Size = new System.Drawing.Size(188, 29);
            this.txtCsQty.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(205, 329);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Total Stock";
            // 
            // txtTsCtnPkt
            // 
            this.txtTsCtnPkt.Enabled = false;
            this.txtTsCtnPkt.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTsCtnPkt.Location = new System.Drawing.Point(349, 326);
            this.txtTsCtnPkt.Name = "txtTsCtnPkt";
            this.txtTsCtnPkt.Size = new System.Drawing.Size(188, 29);
            this.txtTsCtnPkt.TabIndex = 18;
            // 
            // txtTsPcs
            // 
            this.txtTsPcs.Enabled = false;
            this.txtTsPcs.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTsPcs.Location = new System.Drawing.Point(598, 326);
            this.txtTsPcs.Name = "txtTsPcs";
            this.txtTsPcs.Size = new System.Drawing.Size(188, 29);
            this.txtTsPcs.TabIndex = 19;
            // 
            // txtTsQty
            // 
            this.txtTsQty.Enabled = false;
            this.txtTsQty.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTsQty.Location = new System.Drawing.Point(825, 326);
            this.txtTsQty.Name = "txtTsQty";
            this.txtTsQty.Size = new System.Drawing.Size(188, 29);
            this.txtTsQty.TabIndex = 20;
            // 
            // txtCtnPkt
            // 
            this.txtCtnPkt.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCtnPkt.Location = new System.Drawing.Point(349, 282);
            this.txtCtnPkt.Name = "txtCtnPkt";
            this.txtCtnPkt.Size = new System.Drawing.Size(188, 29);
            this.txtCtnPkt.TabIndex = 3;
            this.txtCtnPkt.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtCtnPkt_KeyUp);
            // 
            // txtPcs
            // 
            this.txtPcs.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPcs.Location = new System.Drawing.Point(598, 282);
            this.txtPcs.Name = "txtPcs";
            this.txtPcs.Size = new System.Drawing.Size(188, 29);
            this.txtPcs.TabIndex = 4;
            this.txtPcs.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtPcs_KeyUp);
            // 
            // txtQty
            // 
            this.txtQty.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQty.Location = new System.Drawing.Point(825, 282);
            this.txtQty.Name = "txtQty";
            this.txtQty.ReadOnly = true;
            this.txtQty.Size = new System.Drawing.Size(188, 29);
            this.txtQty.TabIndex = 5;
            this.txtQty.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtQty_KeyUp);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(205, 382);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(131, 23);
            this.label10.TabIndex = 1;
            this.label10.Text = "Transaction Date :";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(205, 285);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(83, 23);
            this.label11.TabIndex = 1;
            this.label11.Text = "New Entry";
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Monotype Corsiva", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnBack.Location = new System.Drawing.Point(12, 12);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(98, 54);
            this.btnBack.TabIndex = 9;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnReset.Location = new System.Drawing.Point(731, 475);
            this.btnReset.Margin = new System.Windows.Forms.Padding(2);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(90, 35);
            this.btnReset.TabIndex = 8;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.KeyUp += new System.Windows.Forms.KeyEventHandler(this.btnReset_KeyUp);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSave.Location = new System.Drawing.Point(842, 475);
            this.btnSave.Margin = new System.Windows.Forms.Padding(2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(90, 35);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            this.btnSave.KeyUp += new System.Windows.Forms.KeyEventHandler(this.btnSave_KeyUp);
            // 
            // TransactionDate
            // 
            this.TransactionDate.Location = new System.Drawing.Point(349, 384);
            this.TransactionDate.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.TransactionDate.Name = "TransactionDate";
            this.TransactionDate.Size = new System.Drawing.Size(188, 20);
            this.TransactionDate.TabIndex = 6;
            this.TransactionDate.Value = new System.DateTime(2019, 5, 5, 17, 50, 19, 0);
            this.TransactionDate.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TransactionDate_KeyUp);
            // 
            // StockEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1161, 576);
            this.Controls.Add(this.TransactionDate);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.txtTsQty);
            this.Controls.Add(this.lbl);
            this.Controls.Add(this.txtTsPcs);
            this.Controls.Add(this.txtTsCtnPkt);
            this.Controls.Add(this.txtCsCtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtQty);
            this.Controls.Add(this.ddlPackSize);
            this.Controls.Add(this.txtPcs);
            this.Controls.Add(this.txtCtnPkt);
            this.Controls.Add(this.ddlProduct);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.lblCStock);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtCsPcs);
            this.Controls.Add(this.txtCsQty);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lblPackSIze);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.lblProductName);
            this.Controls.Add(this.lblStockEntry);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "StockEntry";
            this.Text = "StockEntry";
            this.TopMost = true;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblStockEntry;
        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.Label lblPackSIze;
        private System.Windows.Forms.Label lblCStock;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.ComboBox ddlProduct;
        private System.Windows.Forms.ComboBox ddlPackSize;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtCsCtn;
        private System.Windows.Forms.TextBox txtCsPcs;
        private System.Windows.Forms.TextBox txtCsQty;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTsCtnPkt;
        private System.Windows.Forms.TextBox txtTsPcs;
        private System.Windows.Forms.TextBox txtTsQty;
        private System.Windows.Forms.TextBox txtCtnPkt;
        private System.Windows.Forms.TextBox txtPcs;
        private System.Windows.Forms.TextBox txtQty;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.DateTimePicker TransactionDate;
    }
}