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
        public static void ShowMessage(string content, string description)
        {
            MsgBox messageBox = new MsgBox();
            messageBox.ShowDialog();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

}
