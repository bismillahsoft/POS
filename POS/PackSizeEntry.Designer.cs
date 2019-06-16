namespace POS
{
    partial class PackSizeEntry
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblMessageBox = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.grvPackSize = new System.Windows.Forms.DataGridView();
            this.PackSizeID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sln = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PackSize = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Strip = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PcsPerStrip = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Edit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.lblPack = new System.Windows.Forms.Label();
            this.lblPackSize = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.txtPackSize = new System.Windows.Forms.TextBox();
            this.lblStrip = new System.Windows.Forms.Label();
            this.txtStrip = new System.Windows.Forms.TextBox();
            this.txtPcsPerStrip = new System.Windows.Forms.TextBox();
            this.lblStripperpcs = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grvPackSize)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMessageBox
            // 
            this.lblMessageBox.AutoSize = true;
            this.lblMessageBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMessageBox.Location = new System.Drawing.Point(529, 58);
            this.lblMessageBox.Name = "lblMessageBox";
            this.lblMessageBox.Size = new System.Drawing.Size(0, 13);
            this.lblMessageBox.TabIndex = 17;
            this.lblMessageBox.Visible = false;
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Palatino Linotype", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(12, 12);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(112, 59);
            this.btnBack.TabIndex = 7;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // grvPackSize
            // 
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grvPackSize.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.grvPackSize.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.grvPackSize.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.grvPackSize.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.grvPackSize.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grvPackSize.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.grvPackSize.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grvPackSize.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PackSizeID,
            this.Sln,
            this.PackSize,
            this.Strip,
            this.PcsPerStrip,
            this.Description,
            this.Edit,
            this.Delete});
            this.grvPackSize.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.grvPackSize.Location = new System.Drawing.Point(288, 365);
            this.grvPackSize.Name = "grvPackSize";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grvPackSize.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grvPackSize.RowsDefaultCellStyle = dataGridViewCellStyle7;
            this.grvPackSize.Size = new System.Drawing.Size(698, 334);
            this.grvPackSize.TabIndex = 16;
            this.grvPackSize.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grvPackSize_CellClick);
            // 
            // PackSizeID
            // 
            this.PackSizeID.DataPropertyName = "PackSizeID";
            this.PackSizeID.HeaderText = "ID";
            this.PackSizeID.Name = "PackSizeID";
            this.PackSizeID.ReadOnly = true;
            this.PackSizeID.Visible = false;
            this.PackSizeID.Width = 54;
            // 
            // Sln
            // 
            this.Sln.DataPropertyName = "Sln";
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sln.DefaultCellStyle = dataGridViewCellStyle3;
            this.Sln.HeaderText = "Sln";
            this.Sln.Name = "Sln";
            this.Sln.Width = 60;
            // 
            // PackSize
            // 
            this.PackSize.DataPropertyName = "PackSize";
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PackSize.DefaultCellStyle = dataGridViewCellStyle4;
            this.PackSize.HeaderText = "Pack Size";
            this.PackSize.Name = "PackSize";
            this.PackSize.Width = 104;
            // 
            // Strip
            // 
            this.Strip.DataPropertyName = "Strip";
            this.Strip.HeaderText = "Strip";
            this.Strip.Name = "Strip";
            this.Strip.Width = 73;
            // 
            // PcsPerStrip
            // 
            this.PcsPerStrip.DataPropertyName = "PcsPerStrip";
            this.PcsPerStrip.HeaderText = "Pcs Per Strip";
            this.PcsPerStrip.Name = "PcsPerStrip";
            this.PcsPerStrip.Width = 129;
            // 
            // Description
            // 
            this.Description.DataPropertyName = "PackSizeDescription";
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Description.DefaultCellStyle = dataGridViewCellStyle5;
            this.Description.HeaderText = "Description";
            this.Description.Name = "Description";
            this.Description.Width = 122;
            // 
            // Edit
            // 
            this.Edit.HeaderText = "Edit";
            this.Edit.Name = "Edit";
            this.Edit.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Edit.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Edit.Text = "Edit";
            this.Edit.UseColumnTextForButtonValue = true;
            this.Edit.Width = 66;
            // 
            // Delete
            // 
            this.Delete.HeaderText = "Delete";
            this.Delete.Name = "Delete";
            this.Delete.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Delete.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Delete.Text = "Delete";
            this.Delete.UseColumnTextForButtonValue = true;
            this.Delete.Width = 83;
            // 
            // lblPack
            // 
            this.lblPack.AutoSize = true;
            this.lblPack.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPack.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblPack.Location = new System.Drawing.Point(251, 77);
            this.lblPack.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPack.Name = "lblPack";
            this.lblPack.Size = new System.Drawing.Size(159, 28);
            this.lblPack.TabIndex = 18;
            this.lblPack.Text = "Pack Size Entry";
            // 
            // lblPackSize
            // 
            this.lblPackSize.AutoSize = true;
            this.lblPackSize.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPackSize.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblPackSize.Location = new System.Drawing.Point(284, 126);
            this.lblPackSize.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPackSize.Name = "lblPackSize";
            this.lblPackSize.Size = new System.Drawing.Size(103, 23);
            this.lblPackSize.TabIndex = 9;
            this.lblPackSize.Text = "Pack Size       :";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblDescription.Location = new System.Drawing.Point(612, 173);
            this.lblDescription.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(94, 23);
            this.lblDescription.TabIndex = 11;
            this.lblDescription.Text = "Description :";
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSave.Location = new System.Drawing.Point(812, 254);
            this.btnSave.Margin = new System.Windows.Forms.Padding(2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(90, 35);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            this.btnSave.KeyUp += new System.Windows.Forms.KeyEventHandler(this.btnSave_KeyUp);
            // 
            // txtDescription
            // 
            this.txtDescription.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescription.Location = new System.Drawing.Point(710, 170);
            this.txtDescription.Margin = new System.Windows.Forms.Padding(2);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(188, 47);
            this.txtDescription.TabIndex = 4;
            this.txtDescription.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtDescription_KeyUp);
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnReset.Location = new System.Drawing.Point(714, 254);
            this.btnReset.Margin = new System.Windows.Forms.Padding(2);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(90, 35);
            this.btnReset.TabIndex = 6;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            this.btnReset.KeyUp += new System.Windows.Forms.KeyEventHandler(this.btnReset_KeyUp);
            // 
            // txtPackSize
            // 
            this.txtPackSize.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPackSize.Location = new System.Drawing.Point(391, 123);
            this.txtPackSize.Margin = new System.Windows.Forms.Padding(2);
            this.txtPackSize.Name = "txtPackSize";
            this.txtPackSize.Size = new System.Drawing.Size(188, 29);
            this.txtPackSize.TabIndex = 1;
            this.txtPackSize.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtPackSize_KeyUp);
            // 
            // lblStrip
            // 
            this.lblStrip.AutoSize = true;
            this.lblStrip.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStrip.Location = new System.Drawing.Point(612, 126);
            this.lblStrip.Name = "lblStrip";
            this.lblStrip.Size = new System.Drawing.Size(94, 23);
            this.lblStrip.TabIndex = 19;
            this.lblStrip.Text = "Strips          :";
            // 
            // txtStrip
            // 
            this.txtStrip.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStrip.Location = new System.Drawing.Point(710, 123);
            this.txtStrip.Name = "txtStrip";
            this.txtStrip.Size = new System.Drawing.Size(188, 29);
            this.txtStrip.TabIndex = 2;
            this.txtStrip.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtStrip_KeyUp);
            // 
            // txtPcsPerStrip
            // 
            this.txtPcsPerStrip.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPcsPerStrip.Location = new System.Drawing.Point(391, 173);
            this.txtPcsPerStrip.Name = "txtPcsPerStrip";
            this.txtPcsPerStrip.Size = new System.Drawing.Size(188, 29);
            this.txtPcsPerStrip.TabIndex = 3;
            this.txtPcsPerStrip.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtPcsPerStrip_KeyUp);
            // 
            // lblStripperpcs
            // 
            this.lblStripperpcs.AutoSize = true;
            this.lblStripperpcs.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStripperpcs.Location = new System.Drawing.Point(284, 176);
            this.lblStripperpcs.Name = "lblStripperpcs";
            this.lblStripperpcs.Size = new System.Drawing.Size(103, 23);
            this.lblStripperpcs.TabIndex = 21;
            this.lblStripperpcs.Text = "Pcs Per Strip :";
            // 
            // PackSizeEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.txtPcsPerStrip);
            this.Controls.Add(this.lblStripperpcs);
            this.Controls.Add(this.txtStrip);
            this.Controls.Add(this.lblStrip);
            this.Controls.Add(this.lblMessageBox);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.grvPackSize);
            this.Controls.Add(this.lblPack);
            this.Controls.Add(this.lblPackSize);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.txtPackSize);
            this.Name = "PackSizeEntry";
            this.Text = "PackSizeEntry";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.grvPackSize)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMessageBox;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.DataGridView grvPackSize;
        private System.Windows.Forms.Label lblPack;
        private System.Windows.Forms.Label lblPackSize;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.TextBox txtPackSize;
        private System.Windows.Forms.DataGridViewTextBoxColumn PackSizeID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sln;
        private System.Windows.Forms.DataGridViewTextBoxColumn PackSize;
        private System.Windows.Forms.DataGridViewTextBoxColumn Strip;
        private System.Windows.Forms.DataGridViewTextBoxColumn PcsPerStrip;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewButtonColumn Edit;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
        private System.Windows.Forms.Label lblStrip;
        private System.Windows.Forms.TextBox txtStrip;
        private System.Windows.Forms.TextBox txtPcsPerStrip;
        private System.Windows.Forms.Label lblStripperpcs;
    }
}