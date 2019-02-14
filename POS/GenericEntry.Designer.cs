namespace POS
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
            this.Sln = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GenericName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnBack = new System.Windows.Forms.Button();
            this.grBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grvGeneric)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGene_Reset
            // 
            this.btnGene_Reset.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGene_Reset.Location = new System.Drawing.Point(80, 180);
            this.btnGene_Reset.Margin = new System.Windows.Forms.Padding(2);
            this.btnGene_Reset.Name = "btnGene_Reset";
            this.btnGene_Reset.Size = new System.Drawing.Size(160, 50);
            this.btnGene_Reset.TabIndex = 14;
            this.btnGene_Reset.Text = "Reset";
            this.btnGene_Reset.UseVisualStyleBackColor = true;
            this.btnGene_Reset.Click += new System.EventHandler(this.btnGene_Reset_Click);
            // 
            // btnGene_Save
            // 
            this.btnGene_Save.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGene_Save.Location = new System.Drawing.Point(263, 180);
            this.btnGene_Save.Margin = new System.Windows.Forms.Padding(2);
            this.btnGene_Save.Name = "btnGene_Save";
            this.btnGene_Save.Size = new System.Drawing.Size(160, 50);
            this.btnGene_Save.TabIndex = 13;
            this.btnGene_Save.Text = "Save";
            this.btnGene_Save.UseVisualStyleBackColor = true;
            this.btnGene_Save.Click += new System.EventHandler(this.btnGene_Save_Click);
            // 
            // lblGenericNameEntry
            // 
            this.lblGenericNameEntry.AutoSize = true;
            this.lblGenericNameEntry.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGenericNameEntry.ForeColor = System.Drawing.Color.Black;
            this.lblGenericNameEntry.Location = new System.Drawing.Point(80, 85);
            this.lblGenericNameEntry.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblGenericNameEntry.Name = "lblGenericNameEntry";
            this.lblGenericNameEntry.Size = new System.Drawing.Size(162, 22);
            this.lblGenericNameEntry.TabIndex = 12;
            this.lblGenericNameEntry.Text = "Generic Name Entry";
            // 
            // txtGenericDescription
            // 
            this.txtGenericDescription.Location = new System.Drawing.Point(272, 195);
            this.txtGenericDescription.Margin = new System.Windows.Forms.Padding(2);
            this.txtGenericDescription.Multiline = true;
            this.txtGenericDescription.Name = "txtGenericDescription";
            this.txtGenericDescription.Size = new System.Drawing.Size(235, 64);
            this.txtGenericDescription.TabIndex = 11;
            // 
            // lblGenericDescription
            // 
            this.lblGenericDescription.AutoSize = true;
            this.lblGenericDescription.CausesValidation = false;
            this.lblGenericDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGenericDescription.Location = new System.Drawing.Point(134, 198);
            this.lblGenericDescription.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblGenericDescription.Name = "lblGenericDescription";
            this.lblGenericDescription.Size = new System.Drawing.Size(79, 13);
            this.lblGenericDescription.TabIndex = 10;
            this.lblGenericDescription.Text = "Description :";
            // 
            // txtGenericName
            // 
            this.txtGenericName.Location = new System.Drawing.Point(272, 148);
            this.txtGenericName.Margin = new System.Windows.Forms.Padding(2);
            this.txtGenericName.Name = "txtGenericName";
            this.txtGenericName.Size = new System.Drawing.Size(235, 20);
            this.txtGenericName.TabIndex = 9;
            // 
            // lblGenericName
            // 
            this.lblGenericName.AutoSize = true;
            this.lblGenericName.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGenericName.Location = new System.Drawing.Point(134, 151);
            this.lblGenericName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblGenericName.Name = "lblGenericName";
            this.lblGenericName.Size = new System.Drawing.Size(95, 13);
            this.lblGenericName.TabIndex = 8;
            this.lblGenericName.Text = "Generic Name :";
            // 
            // grBox
            // 
            this.grBox.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.grBox.Controls.Add(this.lblMessageBox);
            this.grBox.Controls.Add(this.grvGeneric);
            this.grBox.Controls.Add(this.btnGene_Save);
            this.grBox.Controls.Add(this.btnGene_Reset);
            this.grBox.Location = new System.Drawing.Point(84, 109);
            this.grBox.Margin = new System.Windows.Forms.Padding(2);
            this.grBox.Name = "grBox";
            this.grBox.Padding = new System.Windows.Forms.Padding(2);
            this.grBox.Size = new System.Drawing.Size(492, 490);
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
            // 
            // grvGeneric
            // 
            this.grvGeneric.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grvGeneric.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Sln,
            this.GenericName,
            this.Description});
            this.grvGeneric.Location = new System.Drawing.Point(53, 308);
            this.grvGeneric.Name = "grvGeneric";
            this.grvGeneric.Size = new System.Drawing.Size(350, 150);
            this.grvGeneric.TabIndex = 15;
            // 
            // Sln
            // 
            this.Sln.DataPropertyName = "Sln";
            this.Sln.HeaderText = "Sln";
            this.Sln.Name = "Sln";
            // 
            // GenericName
            // 
            this.GenericName.DataPropertyName = "GenericName";
            this.GenericName.HeaderText = "Generic Name";
            this.GenericName.Name = "GenericName";
            // 
            // Description
            // 
            this.Description.DataPropertyName = "GenericDescription";
            this.Description.HeaderText = "Description";
            this.Description.Name = "Description";
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Monotype Corsiva", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(12, 12);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(98, 54);
            this.btnBack.TabIndex = 16;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // GenericEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(676, 739);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lblGenericNameEntry);
            this.Controls.Add(this.txtGenericDescription);
            this.Controls.Add(this.lblGenericDescription);
            this.Controls.Add(this.txtGenericName);
            this.Controls.Add(this.lblGenericName);
            this.Controls.Add(this.grBox);
            this.Name = "GenericEntry";
            this.Text = "GenericEntry";
            this.grBox.ResumeLayout(false);
            this.grBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grvGeneric)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.DataGridViewTextBoxColumn Sln;
        private System.Windows.Forms.DataGridViewTextBoxColumn GenericName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.Button btnBack;
    }
}