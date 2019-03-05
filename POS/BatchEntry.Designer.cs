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
            System.Windows.Forms.Label lblBatchName;
            System.Windows.Forms.Label lbl_Batch;
            System.Windows.Forms.Label lblBatch;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblMessageBox = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.grvBatchEntry = new System.Windows.Forms.DataGridView();
            this.Sln = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BatchNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BatchName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtBatchName = new System.Windows.Forms.TextBox();
            this.txtBatchNo = new System.Windows.Forms.TextBox();
            this.txtBatchDescription = new System.Windows.Forms.TextBox();
            btnReset = new System.Windows.Forms.Button();
            btnSave = new System.Windows.Forms.Button();
            lblBrndDescription = new System.Windows.Forms.Label();
            lblBatchName = new System.Windows.Forms.Label();
            lbl_Batch = new System.Windows.Forms.Label();
            lblBatch = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grvBatchEntry)).BeginInit();
            this.SuspendLayout();
            // 
            // btnReset
            // 
            btnReset.Font = new System.Drawing.Font("Palatino Linotype", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            btnReset.Location = new System.Drawing.Point(458, 361);
            btnReset.Margin = new System.Windows.Forms.Padding(2);
            btnReset.Name = "btnReset";
            btnReset.Size = new System.Drawing.Size(180, 65);
            btnReset.TabIndex = 25;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += new System.EventHandler(this.btnReset_Click);
            btnReset.KeyUp += new System.Windows.Forms.KeyEventHandler(this.btnReset_KeyUp);
            // 
            // btnSave
            // 
            btnSave.Font = new System.Drawing.Font("Palatino Linotype", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            btnSave.Location = new System.Drawing.Point(677, 361);
            btnSave.Margin = new System.Windows.Forms.Padding(2);
            btnSave.Name = "btnSave";
            btnSave.Size = new System.Drawing.Size(180, 65);
            btnSave.TabIndex = 24;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += new System.EventHandler(this.btnSave_Click);
            btnSave.KeyUp += new System.Windows.Forms.KeyEventHandler(this.btnSave_KeyUp);
            // 
            // lblBrndDescription
            // 
            lblBrndDescription.AutoSize = true;
            lblBrndDescription.BackColor = System.Drawing.SystemColors.ActiveCaption;
            lblBrndDescription.Font = new System.Drawing.Font("Palatino Linotype", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblBrndDescription.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            lblBrndDescription.Location = new System.Drawing.Point(430, 222);
            lblBrndDescription.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            lblBrndDescription.Name = "lblBrndDescription";
            lblBrndDescription.Size = new System.Drawing.Size(191, 39);
            lblBrndDescription.TabIndex = 30;
            lblBrndDescription.Text = "Description    :";
            // 
            // lblBatchName
            // 
            lblBatchName.AutoSize = true;
            lblBatchName.Font = new System.Drawing.Font("Palatino Linotype", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblBatchName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            lblBatchName.Location = new System.Drawing.Point(430, 150);
            lblBatchName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            lblBatchName.Name = "lblBatchName";
            lblBatchName.Size = new System.Drawing.Size(190, 39);
            lblBatchName.TabIndex = 31;
            lblBatchName.Text = "Batch Name   :";
            // 
            // lbl_Batch
            // 
            lbl_Batch.AutoSize = true;
            lbl_Batch.BackColor = System.Drawing.SystemColors.ActiveCaption;
            lbl_Batch.Font = new System.Drawing.Font("Palatino Linotype", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lbl_Batch.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            lbl_Batch.Location = new System.Drawing.Point(430, 87);
            lbl_Batch.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            lbl_Batch.Name = "lbl_Batch";
            lbl_Batch.Size = new System.Drawing.Size(191, 39);
            lbl_Batch.TabIndex = 29;
            lbl_Batch.Text = "Batch No        :";
            // 
            // lblBatch
            // 
            lblBatch.AutoSize = true;
            lblBatch.Font = new System.Drawing.Font("Palatino Linotype", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblBatch.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            lblBatch.Location = new System.Drawing.Point(327, 28);
            lblBatch.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            lblBatch.Name = "lblBatch";
            lblBatch.Size = new System.Drawing.Size(190, 44);
            lblBatch.TabIndex = 28;
            lblBatch.Text = "Batch Entry";
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
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Monotype Corsiva", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(12, 12);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(98, 54);
            this.btnBack.TabIndex = 27;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // grvBatchEntry
            // 
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.grvBatchEntry.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.grvBatchEntry.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.grvBatchEntry.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.grvBatchEntry.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grvBatchEntry.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.grvBatchEntry.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grvBatchEntry.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Sln,
            this.BatchNo,
            this.BatchName,
            this.Description});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grvBatchEntry.DefaultCellStyle = dataGridViewCellStyle3;
            this.grvBatchEntry.GridColor = System.Drawing.Color.CornflowerBlue;
            this.grvBatchEntry.Location = new System.Drawing.Point(414, 497);
            this.grvBatchEntry.Name = "grvBatchEntry";
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            this.grvBatchEntry.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.grvBatchEntry.Size = new System.Drawing.Size(479, 247);
            this.grvBatchEntry.TabIndex = 26;
            // 
            // Sln
            // 
            this.Sln.DataPropertyName = "Sln";
            this.Sln.HeaderText = "Sln";
            this.Sln.Name = "Sln";
            this.Sln.Width = 60;
            // 
            // BatchNo
            // 
            this.BatchNo.DataPropertyName = "BatchNo";
            this.BatchNo.HeaderText = "Batch No";
            this.BatchNo.Name = "BatchNo";
            this.BatchNo.Width = 103;
            // 
            // BatchName
            // 
            this.BatchName.DataPropertyName = "BatchName";
            this.BatchName.HeaderText = "Batch Name";
            this.BatchName.Name = "BatchName";
            this.BatchName.Width = 125;
            // 
            // Description
            // 
            this.Description.DataPropertyName = "BatchDescription";
            this.Description.HeaderText = "Description";
            this.Description.Name = "Description";
            this.Description.Width = 122;
            // 
            // txtBatchName
            // 
            this.txtBatchName.Font = new System.Drawing.Font("Palatino Linotype", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBatchName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtBatchName.Location = new System.Drawing.Point(630, 84);
            this.txtBatchName.Margin = new System.Windows.Forms.Padding(2);
            this.txtBatchName.Name = "txtBatchName";
            this.txtBatchName.Size = new System.Drawing.Size(227, 47);
            this.txtBatchName.TabIndex = 21;
            this.txtBatchName.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtBatchDescription_KeyUp);
            // 
            // txtBatchNo
            // 
            this.txtBatchNo.Font = new System.Drawing.Font("Palatino Linotype", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBatchNo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtBatchNo.Location = new System.Drawing.Point(630, 147);
            this.txtBatchNo.Margin = new System.Windows.Forms.Padding(2);
            this.txtBatchNo.Name = "txtBatchNo";
            this.txtBatchNo.Size = new System.Drawing.Size(227, 47);
            this.txtBatchNo.TabIndex = 22;
            this.txtBatchNo.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtBatchNo_KeyUp);
            // 
            // txtBatchDescription
            // 
            this.txtBatchDescription.Font = new System.Drawing.Font("Palatino Linotype", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBatchDescription.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtBatchDescription.Location = new System.Drawing.Point(630, 218);
            this.txtBatchDescription.Margin = new System.Windows.Forms.Padding(2);
            this.txtBatchDescription.Multiline = true;
            this.txtBatchDescription.Name = "txtBatchDescription";
            this.txtBatchDescription.Size = new System.Drawing.Size(227, 72);
            this.txtBatchDescription.TabIndex = 23;
            this.txtBatchDescription.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtBatchDescription_KeyUp);
            // 
            // BatchEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1433, 831);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(btnReset);
            this.Controls.Add(this.grvBatchEntry);
            this.Controls.Add(btnSave);
            this.Controls.Add(this.txtBatchName);
            this.Controls.Add(lblBrndDescription);
            this.Controls.Add(lblBatchName);
            this.Controls.Add(lbl_Batch);
            this.Controls.Add(this.txtBatchNo);
            this.Controls.Add(lblBatch);
            this.Controls.Add(this.txtBatchDescription);
            this.Controls.Add(this.lblMessageBox);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "BatchEntry";
            this.Text = "BatchEntry";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.grvBatchEntry)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblMessageBox;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.DataGridView grvBatchEntry;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sln;
        private System.Windows.Forms.DataGridViewTextBoxColumn BatchNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn BatchName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.TextBox txtBatchName;
        private System.Windows.Forms.TextBox txtBatchNo;
        private System.Windows.Forms.TextBox txtBatchDescription;
    }
}