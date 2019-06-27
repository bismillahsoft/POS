using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using POS.IDAL;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS
{
    public partial class StockReport : Form
    {
        #region Global Declaration
        private IStockReport _iStockReport = null;
        #endregion
        public StockReport()
        {
            _iStockReport = new BLL.BStockReport();
            InitializeComponent();
        }

        private void grvStockReport_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            GetStock();
        }
        private void GetStock()
        {
            List<BO.DMS_AreaStock> dms_AreaStock = new List<BO.DMS_AreaStock>();
            dms_AreaStock = _iStockReport.GetProductWiseStock().ToList();
            grvStockReport.AutoGenerateColumns = false;
            grvStockReport.DataSource = dms_AreaStock;
        }
    }
}
