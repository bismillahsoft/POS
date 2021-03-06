﻿using POS.BO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace POS.BLL
{
    public class BDMS_AreaStock : IDAL.IDMS_AreaStock
    {
        private IDAL.IDMS_AreaStock _iDMS_AreaStock = null;

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

        public DMS_AreaStock GetCurrentStockByProductID(long ProductID)
        {
            return _iDMS_AreaStock.GetCurrentStockByProductID(ProductID);
        }
    }
}
