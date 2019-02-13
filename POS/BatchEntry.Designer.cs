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
            this.grvBatchEntry = new System.Windows.Forms.DataGridView();
            this.txtBatchName = new System.Windows.Forms.TextBox();
            this.txtBatchNo = new System.Windows.Forms.TextBox();
            this.txtBrndDescription = new System.Windows.Forms.TextBox();
            this.lblMessageBox = new System.Windows.Forms.Label();
            this.Sln = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BatchNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BatchName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            btnReset = new System.Windows.Forms.Button();
            btnSave = new System.Windows.Forms.Button();
            lblBrndDescription = new System.Windows.Forms.Label();
            lbl_Batch = new System.Windows.Forms.Label();
            lblBatch = new System.Windows.Forms.Label();
            grBox = new System.Windows.Forms.GroupBox();
            lblBatchName = new System.Windows.Forms.Label();
            grBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grvBatchEntry)).BeginInit();
            this.SuspendLayout();
            // 
            // btnReset
            // 
            btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            btnReset.Location = new System.Drawing.Point(255, 260);
            btnReset.Margin = new System.Windows.Forms.Padding(2);
            btnReset.Name = "btnReset";
            btnReset.Size = new System.Drawing.Size(160, 50);
            btnReset.TabIndex = 5;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnSave
            // 
            btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            btnSave.Location = new System.Drawing.Point(431, 260);
            btnSave.Margin = new System.Windows.Forms.Padding(2);
            btnSave.Name = "btnSave";
            btnSave.Size = new System.Drawing.Size(160, 50);
            btnSave.TabIndex = 4;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblBrndDescription
            // 
            lblBrndDescription.AutoSize = true;
            lblBrndDescription.BackColor = System.Drawing.SystemColors.ActiveCaption;
            lblBrndDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblBrndDescription.Location = new System.Drawing.Point(245, 184);
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
            lbl_Batch.Location = new System.Drawing.Point(243, 97);
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
            lblBatch.Location = new System.Drawing.Point(95, 27);
            lblBatch.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            lblBatch.Name = "lblBatch";
            lblBatch.Size = new System.Drawing.Size(98, 22);
            lblBatch.TabIndex = 14;
            lblBatch.Text = "Batch Entry";
            // 
            // grBox
            // 
            grBox.BackColor = System.Drawing.SystemColors.ActiveCaption;
            grBox.Controls.Add(this.grvBatchEntry);
            grBox.Controls.Add(this.txtBatchName);
            grBox.Controls.Add(lblBatchName);
            grBox.Controls.Add(this.txtBatchNo);
            grBox.Controls.Add(this.txtBrndDescription);
            grBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            grBox.Location = new System.Drawing.Point(98, 51);
            grBox.Margin = new System.Windows.Forms.Padding(2);
            grBox.Name = "grBox";
            grBox.Padding = new System.Windows.Forms.Padding(2);
            grBox.Size = new System.Drawing.Size(604, 556);
            grBox.TabIndex = 19;
            grBox.TabStop = false;
            // 
            // grvBatchEntry
            // 
            this.grvBatchEntry.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grvBatchEntry.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Sln,
            this.BatchNo,
            this.BatchName,
            this.Description});
            this.grvBatchEntry.Location = new System.Drawing.Point(48, 290);
            this.grvBatchEntry.Name = "grvBatchEntry";
            this.grvBatchEntry.Size = new System.Drawing.Size(444, 150);
            this.grvBatchEntry.TabIndex = 18;
            // 
            // txtBatchName
            // 
            this.txtBatchName.Location = new System.Drawing.Point(265, 85);
            this.txtBatchName.Margin = new System.Windows.Forms.Padding(2);
            this.txtBatchName.Name = "txtBatchName";
            this.txtBatchName.Size = new System.Drawing.Size(227, 20);
            this.txtBatchName.TabIndex = 2;
            // 
            // lblBatchName
            // 
            lblBatchName.AutoSize = true;
            lblBatchName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblBatchName.ForeColor = System.Drawing.Color.Black;
            lblBatchName.Location = new System.Drawing.Point(144, 88);
            lblBatchName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            lblBatchName.Name = "lblBatchName";
            lblBatchName.Size = new System.Drawing.Size(100, 13);
            lblBatchName.TabIndex = 17;
            lblBatchName.Text = "Batch Name     :";
            // 
            // txtBatchNo
            // 
            this.txtBatchNo.Location = new System.Drawing.Point(265, 46);
            this.txtBatchNo.Margin = new System.Windows.Forms.Padding(2);
            this.txtBatchNo.Name = "txtBatchNo";
            this.txtBatchNo.Size = new System.Drawing.Size(227, 20);
            this.txtBatchNo.TabIndex = 1;
            this.txtBatchNo.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtBatchNo_KeyUp);
            // 
            // txtBrndDescription
            // 
            this.txtBrndDescription.Location = new System.Drawing.Point(265, 130);
            this.txtBrndDescription.Margin = new System.Windows.Forms.Padding(2);
            this.txtBrndDescription.Multiline = true;
            this.txtBrndDescription.Name = "txtBrndDescription";
            this.txtBrndDescription.Size = new System.Drawing.Size(227, 59);
            this.txtBrndDescription.TabIndex = 3;
            // 
            // lblMessageBox
            // 
            this.lblMessageBox.AutoSize = true;
            this.lblMessageBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMessageBox.Location = new System.Drawing.Point(300, 67);
            this.lblMessageBox.Name = "lblMessageBox";
            this.lblMessageBox.Size = new System.Drawing.Size(0, 13);
            this.lblMessageBox.TabIndex = 20;
            // 
            // Sln
            // 
            this.Sln.DataPropertyName = "Sln";
            this.Sln.HeaderText = "Sln";
            this.Sln.Name = "Sln";
            // 
            // BatchNo
            // 
            this.BatchNo.DataPropertyName = "BatchNo";
            this.BatchNo.HeaderText = "Batch No";
            this.BatchNo.Name = "BatchNo";
            // 
            // BatchName
            // 
            this.BatchName.DataPropertyName = "BatchName";
            this.BatchName.HeaderText = "Batch Name";
            this.BatchName.Name = "BatchName";
            // 
            // Description
            // 
            this.Description.DataPropertyName = "BatchDescription";
            this.Description.HeaderText = "Description";
            this.Description.Name = "Description";
            // 
            // BatchEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 651);
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
            ((System.ComponentModel.ISupportInitialize)(this.grvBatchEntry)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtBatchNo;
        private System.Windows.Forms.TextBox txtBrndDescription;
        private System.Windows.Forms.Label lblMessageBox;
        private System.Windows.Forms.TextBox txtBatchName;
        private System.Windows.Forms.DataGridView grvBatchEntry;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sln;
        private System.Windows.Forms.DataGridViewTextBoxColumn BatchNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn BatchName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
    }
}