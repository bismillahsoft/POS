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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.Label lblBatchName;
            this.btnBack = new System.Windows.Forms.Button();
            this.grvBatchEntry = new System.Windows.Forms.DataGridView();
            this.Sln = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BatchNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BatchName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtBatchName = new System.Windows.Forms.TextBox();
            this.txtBatchNo = new System.Windows.Forms.TextBox();
            this.txtBatchDescription = new System.Windows.Forms.TextBox();
            this.lblMessageBox = new System.Windows.Forms.Label();
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
            btnReset.Font = new System.Drawing.Font("Palatino Linotype", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            btnReset.Location = new System.Drawing.Point(473, 394);
            btnReset.Margin = new System.Windows.Forms.Padding(2);
            btnReset.Name = "btnReset";
            btnReset.Size = new System.Drawing.Size(180, 65);
            btnReset.TabIndex = 5;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += new System.EventHandler(this.btnReset_Click);
            btnReset.KeyUp += new System.Windows.Forms.KeyEventHandler(this.btnReset_KeyUp);
            // 
            // btnSave
            // 
            btnSave.Font = new System.Drawing.Font("Palatino Linotype", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            btnSave.Location = new System.Drawing.Point(692, 394);
            btnSave.Margin = new System.Windows.Forms.Padding(2);
            btnSave.Name = "btnSave";
            btnSave.Size = new System.Drawing.Size(180, 65);
            btnSave.TabIndex = 4;
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
            lblBrndDescription.Location = new System.Drawing.Point(445, 255);
            lblBrndDescription.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            lblBrndDescription.Name = "lblBrndDescription";
            lblBrndDescription.Size = new System.Drawing.Size(191, 39);
            lblBrndDescription.TabIndex = 16;
            lblBrndDescription.Text = "Description    :";
            // 
            // lbl_Batch
            // 
            lbl_Batch.AutoSize = true;
            lbl_Batch.BackColor = System.Drawing.SystemColors.ActiveCaption;
            lbl_Batch.Font = new System.Drawing.Font("Palatino Linotype", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lbl_Batch.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            lbl_Batch.Location = new System.Drawing.Point(445, 120);
            lbl_Batch.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            lbl_Batch.Name = "lbl_Batch";
            lbl_Batch.Size = new System.Drawing.Size(191, 39);
            lbl_Batch.TabIndex = 15;
            lbl_Batch.Text = "Batch No        :";
            // 
            // lblBatch
            // 
            lblBatch.AutoSize = true;
            lblBatch.Font = new System.Drawing.Font("Palatino Linotype", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblBatch.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            lblBatch.Location = new System.Drawing.Point(342, 61);
            lblBatch.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            lblBatch.Name = "lblBatch";
            lblBatch.Size = new System.Drawing.Size(190, 44);
            lblBatch.TabIndex = 14;
            lblBatch.Text = "Batch Entry";
            // 
            // grBox
            // 
            grBox.BackColor = System.Drawing.SystemColors.ActiveCaption;
            grBox.Controls.Add(this.btnBack);
            grBox.Controls.Add(btnReset);
            grBox.Controls.Add(this.grvBatchEntry);
            grBox.Controls.Add(btnSave);
            grBox.Controls.Add(this.txtBatchName);
            grBox.Controls.Add(lblBrndDescription);
            grBox.Controls.Add(lblBatchName);
            grBox.Controls.Add(lbl_Batch);
            grBox.Controls.Add(this.txtBatchNo);
            grBox.Controls.Add(lblBatch);
            grBox.Controls.Add(this.txtBatchDescription);
            grBox.Font = new System.Drawing.Font("Palatino Linotype", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            grBox.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            grBox.Location = new System.Drawing.Point(0, -24);
            grBox.Margin = new System.Windows.Forms.Padding(2);
            grBox.Name = "grBox";
            grBox.Padding = new System.Windows.Forms.Padding(2);
            grBox.Size = new System.Drawing.Size(1436, 863);
            grBox.TabIndex = 19;
            grBox.TabStop = false;
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Monotype Corsiva", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(27, 45);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(98, 54);
            this.btnBack.TabIndex = 7;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // grvBatchEntry
            // 
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grvBatchEntry.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.grvBatchEntry.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.grvBatchEntry.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.grvBatchEntry.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grvBatchEntry.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.grvBatchEntry.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grvBatchEntry.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Sln,
            this.BatchNo,
            this.BatchName,
            this.Description});
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grvBatchEntry.DefaultCellStyle = dataGridViewCellStyle7;
            this.grvBatchEntry.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.grvBatchEntry.Location = new System.Drawing.Point(373, 541);
            this.grvBatchEntry.Name = "grvBatchEntry";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grvBatchEntry.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.grvBatchEntry.Size = new System.Drawing.Size(665, 247);
            this.grvBatchEntry.TabIndex = 6;
            this.grvBatchEntry.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grvBatchEntry_CellContentClick);
            // 
            // Sln
            // 
            this.Sln.DataPropertyName = "Sln";
            this.Sln.HeaderText = "Sln";
            this.Sln.Name = "Sln";
            this.Sln.Width = 68;
            // 
            // BatchNo
            // 
            this.BatchNo.DataPropertyName = "BatchNo";
            this.BatchNo.HeaderText = "Batch No";
            this.BatchNo.Name = "BatchNo";
            this.BatchNo.Width = 125;
            // 
            // BatchName
            // 
            this.BatchName.DataPropertyName = "BatchName";
            this.BatchName.HeaderText = "Batch Name";
            this.BatchName.Name = "BatchName";
            this.BatchName.Width = 155;
            // 
            // Description
            // 
            this.Description.DataPropertyName = "BatchDescription";
            this.Description.HeaderText = "Description";
            this.Description.Name = "Description";
            this.Description.Width = 148;
            // 
            // txtBatchName
            // 
            this.txtBatchName.Font = new System.Drawing.Font("Palatino Linotype", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBatchName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtBatchName.Location = new System.Drawing.Point(645, 117);
            this.txtBatchName.Margin = new System.Windows.Forms.Padding(2);
            this.txtBatchName.Name = "txtBatchName";
            this.txtBatchName.Size = new System.Drawing.Size(227, 47);
            this.txtBatchName.TabIndex = 1;
            this.txtBatchName.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtBatchName_KeyUp);
            // 
            // lblBatchName
            // 
            lblBatchName.AutoSize = true;
            lblBatchName.Font = new System.Drawing.Font("Palatino Linotype", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblBatchName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            lblBatchName.Location = new System.Drawing.Point(445, 183);
            lblBatchName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            lblBatchName.Name = "lblBatchName";
            lblBatchName.Size = new System.Drawing.Size(190, 39);
            lblBatchName.TabIndex = 17;
            lblBatchName.Text = "Batch Name   :";
            // 
            // txtBatchNo
            // 
            this.txtBatchNo.Font = new System.Drawing.Font("Palatino Linotype", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBatchNo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtBatchNo.Location = new System.Drawing.Point(645, 180);
            this.txtBatchNo.Margin = new System.Windows.Forms.Padding(2);
            this.txtBatchNo.Name = "txtBatchNo";
            this.txtBatchNo.Size = new System.Drawing.Size(227, 47);
            this.txtBatchNo.TabIndex = 2;
            this.txtBatchNo.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtBatchNo_KeyUp);
            // 
            // txtBatchDescription
            // 
            this.txtBatchDescription.Font = new System.Drawing.Font("Palatino Linotype", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBatchDescription.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtBatchDescription.Location = new System.Drawing.Point(645, 251);
            this.txtBatchDescription.Margin = new System.Windows.Forms.Padding(2);
            this.txtBatchDescription.Multiline = true;
            this.txtBatchDescription.Name = "txtBatchDescription";
            this.txtBatchDescription.Size = new System.Drawing.Size(227, 72);
            this.txtBatchDescription.TabIndex = 3;
            this.txtBatchDescription.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtBatchDescription_KeyUp);
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
            // BatchEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1433, 831);
            this.Controls.Add(this.lblMessageBox);
            this.Controls.Add(grBox);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "BatchEntry";
            this.Text = "BatchEntry";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            grBox.ResumeLayout(false);
            grBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grvBatchEntry)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtBatchNo;
        private System.Windows.Forms.TextBox txtBatchDescription;
        private System.Windows.Forms.Label lblMessageBox;
        private System.Windows.Forms.TextBox txtBatchName;
        private System.Windows.Forms.DataGridView grvBatchEntry;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sln;
        private System.Windows.Forms.DataGridViewTextBoxColumn BatchNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn BatchName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.Button btnBack;
    }
}