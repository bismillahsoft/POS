namespace POS
{
    partial class StockEntryPage
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
            this.TransactionDate = new System.Windows.Forms.DateTimePicker();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.txtTsQty = new System.Windows.Forms.TextBox();
            this.lbl = new System.Windows.Forms.Label();
            this.txtTsPcs = new System.Windows.Forms.TextBox();
            this.txtTsCtnPkt = new System.Windows.Forms.TextBox();
            this.txtCsCtn = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtQty = new System.Windows.Forms.TextBox();
            this.txtPcs = new System.Windows.Forms.TextBox();
            this.txtCtnPkt = new System.Windows.Forms.TextBox();
            this.ddlProduct = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.lblCStock = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCsPcs = new System.Windows.Forms.TextBox();
            this.txtCsQty = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.lblPackSIze = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblProductName = new System.Windows.Forms.Label();
            this.lblStockEntry = new System.Windows.Forms.Label();
            this.txtPackSizee = new System.Windows.Forms.TextBox();
            this.txtStrip = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPcsPerStrip = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TransactionDate
            // 
            this.TransactionDate.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TransactionDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.TransactionDate.Location = new System.Drawing.Point(900, 196);
            this.TransactionDate.MinDate = new System.DateTime(2010, 1, 1, 0, 0, 0, 0);
            this.TransactionDate.Name = "TransactionDate";
            this.TransactionDate.Size = new System.Drawing.Size(108, 29);
            this.TransactionDate.TabIndex = 36;
            this.TransactionDate.Value = new System.DateTime(2019, 5, 5, 17, 50, 19, 0);
            this.TransactionDate.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TransactionDate_KeyUp);
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnReset.Location = new System.Drawing.Point(726, 506);
            this.btnReset.Margin = new System.Windows.Forms.Padding(2);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(90, 35);
            this.btnReset.TabIndex = 38;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            this.btnReset.KeyUp += new System.Windows.Forms.KeyEventHandler(this.btnReset_KeyUp);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSave.Location = new System.Drawing.Point(837, 506);
            this.btnSave.Margin = new System.Windows.Forms.Padding(2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(90, 35);
            this.btnSave.TabIndex = 37;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            this.btnSave.KeyUp += new System.Windows.Forms.KeyEventHandler(this.btnSave_KeyUp);
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Monotype Corsiva", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnBack.Location = new System.Drawing.Point(12, 12);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(98, 54);
            this.btnBack.TabIndex = 39;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // txtTsQty
            // 
            this.txtTsQty.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTsQty.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtTsQty.Location = new System.Drawing.Point(820, 357);
            this.txtTsQty.Name = "txtTsQty";
            this.txtTsQty.ReadOnly = true;
            this.txtTsQty.Size = new System.Drawing.Size(188, 29);
            this.txtTsQty.TabIndex = 45;
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl.Location = new System.Drawing.Point(395, 235);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(65, 23);
            this.lbl.TabIndex = 26;
            this.lbl.Text = "Ctn/Pkt";
            // 
            // txtTsPcs
            // 
            this.txtTsPcs.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTsPcs.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtTsPcs.Location = new System.Drawing.Point(593, 357);
            this.txtTsPcs.Name = "txtTsPcs";
            this.txtTsPcs.ReadOnly = true;
            this.txtTsPcs.Size = new System.Drawing.Size(188, 29);
            this.txtTsPcs.TabIndex = 44;
            // 
            // txtTsCtnPkt
            // 
            this.txtTsCtnPkt.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTsCtnPkt.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtTsCtnPkt.Location = new System.Drawing.Point(344, 357);
            this.txtTsCtnPkt.Name = "txtTsCtnPkt";
            this.txtTsCtnPkt.ReadOnly = true;
            this.txtTsCtnPkt.Size = new System.Drawing.Size(188, 29);
            this.txtTsCtnPkt.TabIndex = 43;
            // 
            // txtCsCtn
            // 
            this.txtCsCtn.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCsCtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtCsCtn.Location = new System.Drawing.Point(344, 268);
            this.txtCsCtn.Name = "txtCsCtn";
            this.txtCsCtn.ReadOnly = true;
            this.txtCsCtn.Size = new System.Drawing.Size(188, 29);
            this.txtCsCtn.TabIndex = 40;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(241, 360);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 23);
            this.label1.TabIndex = 30;
            this.label1.Text = "Total Stock";
            // 
            // txtQty
            // 
            this.txtQty.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQty.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtQty.Location = new System.Drawing.Point(820, 313);
            this.txtQty.Name = "txtQty";
            this.txtQty.ReadOnly = true;
            this.txtQty.Size = new System.Drawing.Size(188, 29);
            this.txtQty.TabIndex = 35;
            this.txtQty.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtQty_KeyUp);
            // 
            // txtPcs
            // 
            this.txtPcs.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPcs.Location = new System.Drawing.Point(593, 313);
            this.txtPcs.Name = "txtPcs";
            this.txtPcs.Size = new System.Drawing.Size(188, 29);
            this.txtPcs.TabIndex = 34;
            this.txtPcs.TextChanged += new System.EventHandler(this.txtPcs_TextChanged);
            this.txtPcs.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtPcs_KeyUp);
            // 
            // txtCtnPkt
            // 
            this.txtCtnPkt.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCtnPkt.Location = new System.Drawing.Point(344, 313);
            this.txtCtnPkt.Name = "txtCtnPkt";
            this.txtCtnPkt.Size = new System.Drawing.Size(188, 29);
            this.txtCtnPkt.TabIndex = 33;
            this.txtCtnPkt.TextChanged += new System.EventHandler(this.txtCtnPkt_TextChanged);
            this.txtCtnPkt.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtCtnPkt_KeyUp);
            // 
            // ddlProduct
            // 
            this.ddlProduct.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ddlProduct.FormattingEnabled = true;
            this.ddlProduct.Location = new System.Drawing.Point(344, 135);
            this.ddlProduct.Name = "ddlProduct";
            this.ddlProduct.Size = new System.Drawing.Size(188, 31);
            this.ddlProduct.TabIndex = 29;
            this.ddlProduct.SelectedIndexChanged += new System.EventHandler(this.ddlProduct_SelectedIndexChanged);
            this.ddlProduct.KeyUp += new System.Windows.Forms.KeyEventHandler(this.ddlProduct_KeyUp);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(241, 316);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(83, 23);
            this.label11.TabIndex = 28;
            this.label11.Text = "New Entry";
            // 
            // lblCStock
            // 
            this.lblCStock.AutoSize = true;
            this.lblCStock.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCStock.Location = new System.Drawing.Point(241, 271);
            this.lblCStock.Name = "lblCStock";
            this.lblCStock.Size = new System.Drawing.Size(103, 23);
            this.lblCStock.TabIndex = 27;
            this.lblCStock.Text = "Current Stock";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(668, 235);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 23);
            this.label3.TabIndex = 25;
            this.label3.Text = "Pcs";
            // 
            // txtCsPcs
            // 
            this.txtCsPcs.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCsPcs.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtCsPcs.Location = new System.Drawing.Point(593, 268);
            this.txtCsPcs.Name = "txtCsPcs";
            this.txtCsPcs.ReadOnly = true;
            this.txtCsPcs.Size = new System.Drawing.Size(188, 29);
            this.txtCsPcs.TabIndex = 41;
            // 
            // txtCsQty
            // 
            this.txtCsQty.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCsQty.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtCsQty.Location = new System.Drawing.Point(820, 268);
            this.txtCsQty.Name = "txtCsQty";
            this.txtCsQty.ReadOnly = true;
            this.txtCsQty.Size = new System.Drawing.Size(188, 29);
            this.txtCsQty.TabIndex = 42;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(887, 235);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(36, 23);
            this.label9.TabIndex = 24;
            this.label9.Text = "Qty";
            // 
            // lblPackSIze
            // 
            this.lblPackSIze.AutoSize = true;
            this.lblPackSIze.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPackSIze.Location = new System.Drawing.Point(589, 135);
            this.lblPackSIze.Name = "lblPackSIze";
            this.lblPackSIze.Size = new System.Drawing.Size(71, 23);
            this.lblPackSIze.TabIndex = 23;
            this.lblPackSIze.Text = "Pack Size";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(751, 196);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(131, 23);
            this.label10.TabIndex = 22;
            this.label10.Text = "Transaction Date :";
            // 
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.lblProductName.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductName.Location = new System.Drawing.Point(238, 139);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(104, 23);
            this.lblProductName.TabIndex = 31;
            this.lblProductName.Text = "Product Name";
            // 
            // lblStockEntry
            // 
            this.lblStockEntry.AutoSize = true;
            this.lblStockEntry.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStockEntry.Location = new System.Drawing.Point(184, 70);
            this.lblStockEntry.Name = "lblStockEntry";
            this.lblStockEntry.Size = new System.Drawing.Size(126, 28);
            this.lblStockEntry.TabIndex = 21;
            this.lblStockEntry.Text = "Stock Entry";
            // 
            // txtPackSizee
            // 
            this.txtPackSizee.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPackSizee.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtPackSizee.Location = new System.Drawing.Point(685, 135);
            this.txtPackSizee.Name = "txtPackSizee";
            this.txtPackSizee.ReadOnly = true;
            this.txtPackSizee.Size = new System.Drawing.Size(188, 29);
            this.txtPackSizee.TabIndex = 46;
            // 
            // txtStrip
            // 
            this.txtStrip.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStrip.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtStrip.Location = new System.Drawing.Point(344, 195);
            this.txtStrip.Name = "txtStrip";
            this.txtStrip.ReadOnly = true;
            this.txtStrip.Size = new System.Drawing.Size(108, 29);
            this.txtStrip.TabIndex = 48;
            this.txtStrip.UseWaitCursor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(241, 196);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 23);
            this.label2.TabIndex = 47;
            this.label2.Text = "Strip";
            // 
            // txtPcsPerStrip
            // 
            this.txtPcsPerStrip.BackColor = System.Drawing.SystemColors.Window;
            this.txtPcsPerStrip.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPcsPerStrip.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtPcsPerStrip.Location = new System.Drawing.Point(593, 196);
            this.txtPcsPerStrip.Name = "txtPcsPerStrip";
            this.txtPcsPerStrip.ReadOnly = true;
            this.txtPcsPerStrip.Size = new System.Drawing.Size(108, 29);
            this.txtPcsPerStrip.TabIndex = 50;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(482, 196);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 23);
            this.label4.TabIndex = 49;
            this.label4.Text = "Pcs Per Strip";
            // 
            // StockEntryPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1182, 597);
            this.Controls.Add(this.txtPcsPerStrip);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtStrip);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPackSizee);
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
            this.Name = "StockEntryPage";
            this.Text = "StockEntryPage";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker TransactionDate;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.TextBox txtTsQty;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.TextBox txtTsPcs;
        private System.Windows.Forms.TextBox txtTsCtnPkt;
        private System.Windows.Forms.TextBox txtCsCtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtQty;
        private System.Windows.Forms.TextBox txtPcs;
        private System.Windows.Forms.TextBox txtCtnPkt;
        private System.Windows.Forms.ComboBox ddlProduct;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblCStock;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCsPcs;
        private System.Windows.Forms.TextBox txtCsQty;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblPackSIze;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.Label lblStockEntry;
        private System.Windows.Forms.TextBox txtPackSizee;
        private System.Windows.Forms.TextBox txtStrip;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPcsPerStrip;
        private System.Windows.Forms.Label label4;
    }
}