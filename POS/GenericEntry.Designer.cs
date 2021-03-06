﻿namespace POS
{
    partial class GenericEntry
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnGene_Reset = new System.Windows.Forms.Button();
            this.btnGene_Save = new System.Windows.Forms.Button();
            this.lblGenericNameEntry = new System.Windows.Forms.Label();
            this.txtGenericDescription = new System.Windows.Forms.TextBox();
            this.lblGenericDescription = new System.Windows.Forms.Label();
            this.txtGenericName = new System.Windows.Forms.TextBox();
            this.lblGenericName = new System.Windows.Forms.Label();
            this.grBox = new System.Windows.Forms.GroupBox();
            this.lblMessageBox = new System.Windows.Forms.Label();
            this.grvGeneric = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sln = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GenericName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Edit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnBack = new System.Windows.Forms.Button();
            this.grBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grvGeneric)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGene_Reset
            // 
            this.btnGene_Reset.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGene_Reset.Location = new System.Drawing.Point(644, 271);
            this.btnGene_Reset.Margin = new System.Windows.Forms.Padding(2);
            this.btnGene_Reset.Name = "btnGene_Reset";
            this.btnGene_Reset.Size = new System.Drawing.Size(90, 35);
            this.btnGene_Reset.TabIndex = 4;
            this.btnGene_Reset.Text = "Reset";
            this.btnGene_Reset.UseVisualStyleBackColor = true;
            this.btnGene_Reset.Click += new System.EventHandler(this.btnGene_Reset_Click);
            this.btnGene_Reset.KeyUp += new System.Windows.Forms.KeyEventHandler(this.btnGene_Reset_KeyUp);
            // 
            // btnGene_Save
            // 
            this.btnGene_Save.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGene_Save.Location = new System.Drawing.Point(744, 271);
            this.btnGene_Save.Margin = new System.Windows.Forms.Padding(2);
            this.btnGene_Save.Name = "btnGene_Save";
            this.btnGene_Save.Size = new System.Drawing.Size(90, 35);
            this.btnGene_Save.TabIndex = 3;
            this.btnGene_Save.Text = "Save";
            this.btnGene_Save.UseVisualStyleBackColor = true;
            this.btnGene_Save.Click += new System.EventHandler(this.btnGene_Save_Click);
            this.btnGene_Save.KeyUp += new System.Windows.Forms.KeyEventHandler(this.btnGene_Save_KeyUp);
            // 
            // lblGenericNameEntry
            // 
            this.lblGenericNameEntry.AutoSize = true;
            this.lblGenericNameEntry.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGenericNameEntry.ForeColor = System.Drawing.Color.Black;
            this.lblGenericNameEntry.Location = new System.Drawing.Point(418, 99);
            this.lblGenericNameEntry.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblGenericNameEntry.Name = "lblGenericNameEntry";
            this.lblGenericNameEntry.Size = new System.Drawing.Size(214, 28);
            this.lblGenericNameEntry.TabIndex = 12;
            this.lblGenericNameEntry.Text = "Generic Name Entry";
            // 
            // txtGenericDescription
            // 
            this.txtGenericDescription.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGenericDescription.Location = new System.Drawing.Point(648, 200);
            this.txtGenericDescription.Margin = new System.Windows.Forms.Padding(2);
            this.txtGenericDescription.Multiline = true;
            this.txtGenericDescription.Name = "txtGenericDescription";
            this.txtGenericDescription.Size = new System.Drawing.Size(188, 47);
            this.txtGenericDescription.TabIndex = 2;
            this.txtGenericDescription.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtGenericDescription_KeyUp);
            // 
            // lblGenericDescription
            // 
            this.lblGenericDescription.AutoSize = true;
            this.lblGenericDescription.CausesValidation = false;
            this.lblGenericDescription.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGenericDescription.Location = new System.Drawing.Point(538, 203);
            this.lblGenericDescription.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblGenericDescription.Name = "lblGenericDescription";
            this.lblGenericDescription.Size = new System.Drawing.Size(110, 23);
            this.lblGenericDescription.TabIndex = 10;
            this.lblGenericDescription.Text = "Description     :";
            // 
            // txtGenericName
            // 
            this.txtGenericName.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGenericName.Location = new System.Drawing.Point(648, 157);
            this.txtGenericName.Margin = new System.Windows.Forms.Padding(2);
            this.txtGenericName.Name = "txtGenericName";
            this.txtGenericName.Size = new System.Drawing.Size(188, 29);
            this.txtGenericName.TabIndex = 1;
            this.txtGenericName.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtGenericName_KeyUp);
            // 
            // lblGenericName
            // 
            this.lblGenericName.AutoSize = true;
            this.lblGenericName.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGenericName.Location = new System.Drawing.Point(538, 160);
            this.lblGenericName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblGenericName.Name = "lblGenericName";
            this.lblGenericName.Size = new System.Drawing.Size(109, 23);
            this.lblGenericName.TabIndex = 8;
            this.lblGenericName.Text = "Generic Name :";
            // 
            // grBox
            // 
            this.grBox.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.grBox.Controls.Add(this.lblGenericDescription);
            this.grBox.Controls.Add(this.txtGenericDescription);
            this.grBox.Controls.Add(this.lblGenericName);
            this.grBox.Controls.Add(this.lblGenericNameEntry);
            this.grBox.Controls.Add(this.btnBack);
            this.grBox.Controls.Add(this.txtGenericName);
            this.grBox.Controls.Add(this.lblMessageBox);
            this.grBox.Controls.Add(this.grvGeneric);
            this.grBox.Controls.Add(this.btnGene_Save);
            this.grBox.Controls.Add(this.btnGene_Reset);
            this.grBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.grBox.Location = new System.Drawing.Point(-1, -7);
            this.grBox.Margin = new System.Windows.Forms.Padding(2);
            this.grBox.Name = "grBox";
            this.grBox.Padding = new System.Windows.Forms.Padding(2);
            this.grBox.Size = new System.Drawing.Size(1431, 839);
            this.grBox.TabIndex = 15;
            this.grBox.TabStop = false;
            // 
            // lblMessageBox
            // 
            this.lblMessageBox.AutoSize = true;
            this.lblMessageBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMessageBox.Location = new System.Drawing.Point(183, 15);
            this.lblMessageBox.Name = "lblMessageBox";
            this.lblMessageBox.Size = new System.Drawing.Size(0, 13);
            this.lblMessageBox.TabIndex = 16;
            this.lblMessageBox.Visible = false;
            // 
            // grvGeneric
            // 
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grvGeneric.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.grvGeneric.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.grvGeneric.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.grvGeneric.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.grvGeneric.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grvGeneric.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.grvGeneric.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grvGeneric.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Sln,
            this.GenericName,
            this.Description,
            this.Edit,
            this.Delete});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grvGeneric.DefaultCellStyle = dataGridViewCellStyle3;
            this.grvGeneric.Location = new System.Drawing.Point(460, 367);
            this.grvGeneric.Name = "grvGeneric";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grvGeneric.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grvGeneric.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.grvGeneric.Size = new System.Drawing.Size(541, 294);
            this.grvGeneric.TabIndex = 5;
            this.grvGeneric.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grvGeneric_CellClick);
            // 
            // ID
            // 
            this.ID.DataPropertyName = "PGenericID";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.Visible = false;
            this.ID.Width = 54;
            // 
            // Sln
            // 
            this.Sln.DataPropertyName = "Sln";
            this.Sln.HeaderText = "Sln";
            this.Sln.Name = "Sln";
            this.Sln.Width = 60;
            // 
            // GenericName
            // 
            this.GenericName.DataPropertyName = "GenericName";
            this.GenericName.HeaderText = "Generic Name";
            this.GenericName.Name = "GenericName";
            this.GenericName.Width = 141;
            // 
            // Description
            // 
            this.Description.DataPropertyName = "GenericDescription";
            this.Description.HeaderText = "Description";
            this.Description.Name = "Description";
            this.Description.Width = 122;
            // 
            // Edit
            // 
            this.Edit.DataPropertyName = "Edit";
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
            this.Delete.DataPropertyName = "Delete";
            this.Delete.HeaderText = "Delete";
            this.Delete.Name = "Delete";
            this.Delete.Text = "Delete";
            this.Delete.UseColumnTextForButtonValue = true;
            this.Delete.Width = 64;
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Monotype Corsiva", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(13, 19);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(98, 54);
            this.btnBack.TabIndex = 6;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // GenericEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.grBox);
            this.Name = "GenericEntry";
            this.Text = "GenericEntry";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.grBox.ResumeLayout(false);
            this.grBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grvGeneric)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGene_Reset;
        private System.Windows.Forms.Button btnGene_Save;
        private System.Windows.Forms.Label lblGenericNameEntry;
        private System.Windows.Forms.TextBox txtGenericDescription;
        private System.Windows.Forms.Label lblGenericDescription;
        private System.Windows.Forms.TextBox txtGenericName;
        private System.Windows.Forms.Label lblGenericName;
        private System.Windows.Forms.GroupBox grBox;
        private System.Windows.Forms.Label lblMessageBox;
        private System.Windows.Forms.DataGridView grvGeneric;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sln;
        private System.Windows.Forms.DataGridViewTextBoxColumn GenericName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewButtonColumn Edit;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
        private System.Windows.Forms.Button btnBack;
    }
}