using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using POS.BO;

namespace POS.BLL
{
    public class BStockReport : IDAL.IStockReport
    {
        private IDAL.IStockReport _iStockReport = null;

        public BStockReport()
        {
            _iStockReport = new DAL.DStockReport();
        }

        public IList<DMS_AreaStock> GetProductWiseStock()
        {
            return _iStockReport.GetProductWiseStock();
        }
    }
}
