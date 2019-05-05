using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.IDAL
{
    public interface IDMS_AreaStock
    {
        int Insert(BO.DMS_AreaStock ObjAreaStock);
        int Update(BO.DMS_AreaStock ObjAreaStock);
        int Delete(BO.DMS_AreaStock ObjAreaStock);
        //IList(BO.DMS_AreaStock) GetMDS_AreaStockList();
    }
}
