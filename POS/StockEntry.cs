using POS.IDAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace POS
{
    public partial class StockEntry : Form
    {
        #region
        private int IProduct _IProduct = null;
        private int IProductPackSize _IProductPackSize = null;
        #endregion
        public StockEntry()
        {
            InitializeComponent();
            _IProduct = new BLL.BProduct();
            _IProductPackSize = new BLL.BProductPackSize();
        }

     
    }
}
