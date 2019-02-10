namespace POS
{
    partial class BatchEntry
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
            System.Windows.Forms.Button btnReset;
            System.Windows.Forms.Button btnSave;
            System.Windows.Forms.Label lblBrndDescription;
            System.Windows.Forms.Label lbl_Batch;
            System.Windows.Forms.Label lblBatch;
            System.Windows.Forms.GroupBox grBox;
            this.txtBrand = new System.Windows.Forms.TextBox();
            this.txtBrndDescription = new System.Windows.Forms.TextBox();
            btnReset = new System.Windows.Forms.Button();
            btnSave = new System.Windows.Forms.Button();
            lblBrndDescription = new System.Windows.Forms.Label();
            lbl_Batch = new System.Windows.Forms.Label();
            lblBatch = new System.Windows.Forms.Label();
            grBox = new System.Windows.Forms.GroupBox();
            grBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnReset
            // 
            btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            btnReset.Location = new System.Drawing.Point(272, 299);
            btnReset.Margin = new System.Windows.Forms.Padding(2);
            btnReset.Name = "btnReset";
            btnReset.Size = new System.Drawing.Size(124, 41);
            btnReset.TabIndex = 18;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnSave
            // 
            btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            btnSave.Location = new System.Drawing.Point(404, 299);
            btnSave.Margin = new System.Windows.Forms.Padding(2);
            btnSave.Name = "btnSave";
            btnSave.Size = new System.Drawing.Size(124, 41);
            btnSave.TabIndex = 17;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblBrndDescription
            // 
            lblBrndDescription.AutoSize = true;
            lblBrndDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblBrndDescription.Location = new System.Drawing.Point(272, 206);
            lblBrndDescription.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            lblBrndDescription.Name = "lblBrndDescription";
            lblBrndDescription.Size = new System.Drawing.Size(79, 13);
            lblBrndDescription.TabIndex = 16;
            lblBrndDescription.Text = "Description :";
            lblBrndDescription.Click += new System.EventHandler(this.lblBrndDescription_Click);
            // 
            // lbl_Batch
            // 
            lbl_Batch.AutoSize = true;
            lbl_Batch.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lbl_Batch.Location = new System.Drawing.Point(270, 151);
            lbl_Batch.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            lbl_Batch.Name = "lbl_Batch";
            lbl_Batch.Size = new System.Drawing.Size(96, 13);
            lbl_Batch.TabIndex = 15;
            lbl_Batch.Text = "Batch No        :";
            lbl_Batch.Click += new System.EventHandler(this.lbl_Brand_Click);
            // 
            // lblBatch
            // 
            lblBatch.AutoSize = true;
            lblBatch.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblBatch.Location = new System.Drawing.Point(248, 86);
            lblBatch.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            lblBatch.Name = "lblBatch";
            lblBatch.Size = new System.Drawing.Size(98, 22);
            lblBatch.TabIndex = 14;
            lblBatch.Text = "Batch Entry";
            // 
            // grBox
            // 
            grBox.BackColor = System.Drawing.SystemColors.ActiveCaption;
            grBox.Controls.Add(this.txtBrand);
            grBox.Controls.Add(this.txtBrndDescription);
            grBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            grBox.Location = new System.Drawing.Point(251, 110);
            grBox.Margin = new System.Windows.Forms.Padding(2);
            grBox.Name = "grBox";
            grBox.Padding = new System.Windows.Forms.Padding(2);
            grBox.Size = new System.Drawing.Size(301, 254);
            grBox.TabIndex = 19;
            grBox.TabStop = false;
            grBox.Enter += new System.EventHandler(this.grBox_Enter);
            // 
            // txtBrand
            // 
            this.txtBrand.Location = new System.Drawing.Point(140, 41);
            this.txtBrand.Margin = new System.Windows.Forms.Padding(2);
            this.txtBrand.Name = "txtBrand";
            this.txtBrand.Size = new System.Drawing.Size(138, 20);
            this.txtBrand.TabIndex = 3;
            // 
            // txtBrndDescription
            // 
            this.txtBrndDescription.Location = new System.Drawing.Point(140, 93);
            this.txtBrndDescription.Margin = new System.Windows.Forms.Padding(2);
            this.txtBrndDescription.Multiline = true;
            this.txtBrndDescription.Name = "txtBrndDescription";
            this.txtBrndDescription.Size = new System.Drawing.Size(138, 59);
            this.txtBrndDescription.TabIndex = 4;
            // 
            // BatchEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(btnReset);
            this.Controls.Add(btnSave);
            this.Controls.Add(lblBrndDescription);
            this.Controls.Add(lbl_Batch);
            this.Controls.Add(lblBatch);
            this.Controls.Add(grBox);
            this.Name = "BatchEntry";
            this.Text = "BatchEntry";
            grBox.ResumeLayout(false);
            grBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtBrand;
        private System.Windows.Forms.TextBox txtBrndDescription;
    }
}