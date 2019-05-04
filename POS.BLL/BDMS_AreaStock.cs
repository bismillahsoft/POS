using POS.BO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace POS.BLL
{
    public class BDMS_AreaStock : IDAL.IMDS_AreaStock
    {
        private IDAL.IMDS_AreaStock _iDMS_AreaStock = null;

        public BDMS_AreaStock()
        {
            _iDMS_AreaStock = new DAL.DDMS_AreaStock();
        }
      
        public int Insert(DMS_AreaStock ObjAreaStock)
        {
            return _iDMS_AreaStock.Insert(ObjAreaStock);
        }
        public int Delete(DMS_AreaStock ObjAreaStock)
        {
            return _iDMS_AreaStock.Update(ObjAreaStock);
        }

        public int Update(DMS_AreaStock ObjAreaStock)
        {
            return _iDMS_AreaStock.Delete(ObjAreaStock);
        }
    }
}
