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
            this.lblPack = new System.Windows.Forms.Label();
            this.grBox = new System.Windows.Forms.GroupBox();
            this.grvPackSize = new System.Windows.Forms.DataGridView();
            this.Sln = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PackSize = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblPackSize = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.bntSave = new System.Windows.Forms.Button();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.txtPackSize = new System.Windows.Forms.TextBox();
            this.lblMessageBox = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.grBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grvPackSize)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPack
            // 
            this.lblPack.AutoSize = true;
            this.lblPack.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPack.Location = new System.Drawing.Point(132, 88);
            this.lblPack.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPack.Name = "lblPack";
            this.lblPack.Size = new System.Drawing.Size(125, 22);
            this.lblPack.TabIndex = 8;
            this.lblPack.Text = "Pack Size Entry";
            // 
            // grBox
            // 
            this.grBox.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.grBox.Controls.Add(this.grvPackSize);
            this.grBox.Controls.Add(this.lblPackSize);
            this.grBox.Controls.Add(this.lblDescription);
            this.grBox.Controls.Add(this.bntSave);
            this.grBox.Controls.Add(this.txtDescription);
            this.grBox.Controls.Add(this.btnReset);
            this.grBox.Controls.Add(this.txtPackSize);
            this.grBox.Location = new System.Drawing.Point(135, 112);
            this.grBox.Margin = new System.Windows.Forms.Padding(2);
            this.grBox.Name = "grBox";
            this.grBox.Padding = new System.Windows.Forms.Padding(2);
            this.grBox.Size = new System.Drawing.Size(496, 499);
            this.grBox.TabIndex = 9;
            this.grBox.TabStop = false;
            // 
            // grvPackSize
            // 
            this.grvPackSize.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grvPackSize.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Sln,
            this.PackSize,
            this.Description});
            this.grvPackSize.Location = new System.Drawing.Point(75, 294);
            this.grvPackSize.Name = "grvPackSize";
            this.grvPackSize.Size = new System.Drawing.Size(343, 150);
            this.grvPackSize.TabIndex = 7;
            // 
            // Sln
            // 
            this.Sln.DataPropertyName = "Sln";
            this.Sln.HeaderText = "Sln";
            this.Sln.Name = "Sln";
            // 
            // PackSize
            // 
            this.PackSize.DataPropertyName = "PackSize";
            this.PackSize.HeaderText = "Pack Size";
            this.PackSize.Name = "PackSize";
            // 
            // Description
            // 
            this.Description.DataPropertyName = "PackSizeDescription";
            this.Description.HeaderText = "Description";
            this.Description.Name = "Description";
            // 
            // lblPackSize
            // 
            this.lblPackSize.AutoSize = true;
            this.lblPackSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPackSize.Location = new System.Drawing.Point(74, 41);
            this.lblPackSize.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPackSize.Name = "lblPackSize";
            this.lblPackSize.Size = new System.Drawing.Size(72, 13);
            this.lblPackSize.TabIndex = 1;
            this.lblPackSize.Text = "Pack Size :";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.Location = new System.Drawing.Point(74, 84);
            this.lblDescription.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(79, 13);
            this.lblDescription.TabIndex = 2;
            this.lblDescription.Text = "Description :";
            // 
            // bntSave
            // 
            this.bntSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntSave.Location = new System.Drawing.Point(260, 171);
            this.bntSave.Margin = new System.Windows.Forms.Padding(2);
            this.bntSave.Name = "bntSave";
            this.bntSave.Size = new System.Drawing.Size(160, 50);
            this.bntSave.TabIndex = 3;
            this.bntSave.Text = "Save";
            this.bntSave.UseVisualStyleBackColor = true;
            this.bntSave.Click += new System.EventHandler(this.bntSave_Click);
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(198, 81);
            this.txtDescription.Margin = new System.Windows.Forms.Padding(2);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(219, 56);
            this.txtDescription.TabIndex = 6;
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(76, 171);
            this.btnReset.Margin = new System.Windows.Forms.Padding(2);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(160, 50);
            this.btnReset.TabIndex = 4;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // txtPackSize
            // 
            this.txtPackSize.Location = new System.Drawing.Point(198, 37);
            this.txtPackSize.Margin = new System.Windows.Forms.Padding(2);
            this.txtPackSize.Name = "txtPackSize";
            this.txtPackSize.Size = new System.Drawing.Size(219, 20);
            this.txtPackSize.TabIndex = 5;
            // 
            // lblMessageBox
            // 
            this.lblMessageBox.AutoSize = true;
            this.lblMessageBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMessageBox.Location = new System.Drawing.Point(227, 389);
            this.lblMessageBox.Name = "lblMessageBox";
            this.lblMessageBox.Size = new System.Drawing.Size(0, 13);
            this.lblMessageBox.TabIndex = 17;
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Monotype Corsiva", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(12, 12);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(98, 54);
            this.btnBack.TabIndex = 18;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // PackSizeEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 740);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lblMessageBox);
            this.Controls.Add(this.lblPack);
            this.Controls.Add(this.grBox);
            this.Name = "PackSizeEntry";
            this.Text = "PackSizeEntry";
            this.grBox.ResumeLayout(false);
            this.grBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grvPackSize)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPack;
        private System.Windows.Forms.GroupBox grBox;
        private System.Windows.Forms.Label lblPackSize;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Button bntSave;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.TextBox txtPackSize;
        private System.Windows.Forms.Label lblMessageBox;
        private System.Windows.Forms.DataGridView grvPackSize;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sln;
        private System.Windows.Forms.DataGridViewTextBoxColumn PackSize;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.Button btnBack;
    }
}