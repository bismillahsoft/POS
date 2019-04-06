namespace POS
{
    partial class MsgBox
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MsgBox));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblMessageNew = new System.Windows.Forms.Label();
            this.btnOk = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel1.Controls.Add(this.lblMessageNew);
            this.panel1.Controls.Add(this.btnOk);
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Name = "panel1";
            // 
            // lblMessageNew
            // 
            resources.ApplyResources(this.lblMessageNew, "lblMessageNew");
            this.lblMessageNew.ForeColor = System.Drawing.Color.Blue;
            this.lblMessageNew.Name = "lblMessageNew";
            // 
            // btnOk
            // 
            this.btnOk.BackColor = System.Drawing.Color.White;
            resources.ApplyResources(this.btnOk, "btnOk");
            this.btnOk.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnOk.Name = "btnOk";
            this.btnOk.UseVisualStyleBackColor = false;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            this.btnOk.KeyUp += new System.Windows.Forms.KeyEventHandler(this.btnOk_KeyUp);
            // 
            // MsgBox
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(153)))), ((int)(((byte)(102)))));
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MsgBox";
            this.ShowIcon = false;
            this.TopMost = true;
            this.TransparencyKey = System.Drawing.Color.Gray;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Label lblMessageNew;
    }
}