using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.IDAL
{
    public interface IStockReport
    {
        IList<BO.DMS_AreaStock> GetProductWiseStock();
    }
}
