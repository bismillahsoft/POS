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
            System.Windows.Forms.Label lblBatchName;
            this.txtBatchName = new System.Windows.Forms.TextBox();
            this.txtBatchNo = new System.Windows.Forms.TextBox();
            this.txtBrndDescription = new System.Windows.Forms.TextBox();
            this.lblMessageBox = new System.Windows.Forms.Label();
            btnReset = new System.Windows.Forms.Button();
            btnSave = new System.Windows.Forms.Button();
            lblBrndDescription = new System.Windows.Forms.Label();
            lbl_Batch = new System.Windows.Forms.Label();
            lblBatch = new System.Windows.Forms.Label();
            grBox = new System.Windows.Forms.GroupBox();
            lblBatchName = new System.Windows.Forms.Label();
            grBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnReset
            // 
            btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            btnReset.Location = new System.Drawing.Point(263, 260);
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
            btnSave.Location = new System.Drawing.Point(395, 260);
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
            lblBrndDescription.BackColor = System.Drawing.SystemColors.ActiveCaption;
            lblBrndDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblBrndDescription.Location = new System.Drawing.Point(255, 184);
            lblBrndDescription.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            lblBrndDescription.Name = "lblBrndDescription";
            lblBrndDescription.Size = new System.Drawing.Size(79, 13);
            lblBrndDescription.TabIndex = 16;
            lblBrndDescription.Text = "Description :";
            // 
            // lbl_Batch
            // 
            lbl_Batch.AutoSize = true;
            lbl_Batch.BackColor = System.Drawing.SystemColors.ActiveCaption;
            lbl_Batch.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lbl_Batch.Location = new System.Drawing.Point(253, 97);
            lbl_Batch.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            lbl_Batch.Name = "lbl_Batch";
            lbl_Batch.Size = new System.Drawing.Size(96, 13);
            lbl_Batch.TabIndex = 15;
            lbl_Batch.Text = "Batch No        :";
            // 
            // lblBatch
            // 
            lblBatch.AutoSize = true;
            lblBatch.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblBatch.Location = new System.Drawing.Point(209, 27);
            lblBatch.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            lblBatch.Name = "lblBatch";
            lblBatch.Size = new System.Drawing.Size(98, 22);
            lblBatch.TabIndex = 14;
            lblBatch.Text = "Batch Entry";
            // 
            // grBox
            // 
            grBox.BackColor = System.Drawing.SystemColors.ActiveCaption;
            grBox.Controls.Add(this.txtBatchName);
            grBox.Controls.Add(lblBatchName);
            grBox.Controls.Add(this.txtBatchNo);
            grBox.Controls.Add(this.txtBrndDescription);
            grBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            grBox.Location = new System.Drawing.Point(212, 51);
            grBox.Margin = new System.Windows.Forms.Padding(2);
            grBox.Name = "grBox";
            grBox.Padding = new System.Windows.Forms.Padding(2);
            grBox.Size = new System.Drawing.Size(367, 281);
            grBox.TabIndex = 19;
            grBox.TabStop = false;
            // 
            // txtBatchName
            // 
            this.txtBatchName.Location = new System.Drawing.Point(162, 85);
            this.txtBatchName.Margin = new System.Windows.Forms.Padding(2);
            this.txtBatchName.Name = "txtBatchName";
            this.txtBatchName.Size = new System.Drawing.Size(138, 20);
            this.txtBatchName.TabIndex = 16;
            // 
            // lblBatchName
            // 
            lblBatchName.AutoSize = true;
            lblBatchName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblBatchName.ForeColor = System.Drawing.Color.Black;
            lblBatchName.Location = new System.Drawing.Point(41, 88);
            lblBatchName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            lblBatchName.Name = "lblBatchName";
            lblBatchName.Size = new System.Drawing.Size(100, 13);
            lblBatchName.TabIndex = 17;
            lblBatchName.Text = "Batch Name     :";
            // 
            // txtBatchNo
            // 
            this.txtBatchNo.Location = new System.Drawing.Point(162, 46);
            this.txtBatchNo.Margin = new System.Windows.Forms.Padding(2);
            this.txtBatchNo.Name = "txtBatchNo";
            this.txtBatchNo.Size = new System.Drawing.Size(138, 20);
            this.txtBatchNo.TabIndex = 3;
            // 
            // txtBrndDescription
            // 
            this.txtBrndDescription.Location = new System.Drawing.Point(162, 130);
            this.txtBrndDescription.Margin = new System.Windows.Forms.Padding(2);
            this.txtBrndDescription.Multiline = true;
            this.txtBrndDescription.Name = "txtBrndDescription";
            this.txtBrndDescription.Size = new System.Drawing.Size(138, 59);
            this.txtBrndDescription.TabIndex = 4;
            // 
            // lblMessageBox
            // 
            this.lblMessageBox.AutoSize = true;
            this.lblMessageBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMessageBox.Location = new System.Drawing.Point(307, 319);
            this.lblMessageBox.Name = "lblMessageBox";
            this.lblMessageBox.Size = new System.Drawing.Size(0, 13);
            this.lblMessageBox.TabIndex = 20;
            // 
            // BatchEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblMessageBox);
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
        private System.Windows.Forms.TextBox txtBatchNo;
        private System.Windows.Forms.TextBox txtBrndDescription;
        private System.Windows.Forms.Label lblMessageBox;
        private System.Windows.Forms.TextBox txtBatchName;
    }
}