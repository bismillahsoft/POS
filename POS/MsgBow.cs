using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS
{
    public partial class MsgBox : Form
    {
        public MsgBox()
        {
            InitializeComponent();
        }
        public string ShowMessage(string content)
        {
            lblMessageNew.Text = content;
            lblMessageNew.ForeColor = System.Drawing.Color.Green;
            return lblMessageNew.Text;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

}
