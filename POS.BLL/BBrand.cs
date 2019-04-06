using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace POS.BLL
{


    public class BBrand : IDAL.IBrand
    {
        private IDAL.IBrand _iBrand = null;
        public BBrand()
        {
            _iBrand = new DAL.DBrand();

        }
        public int Insert(BO.Brand objBrand)
        {
            return _iBrand.Insert(objBrand);

        }
        public int Update(BO.Brand objBrand)
        {
            return _iBrand.Update(objBrand);

        }
        public int Delete(int SBG)
        {
            return _iBrand.Delete(SBG);

        }
        public IList<BO.Brand> GetBrand(int pageIndex, int pageSize, string orderBy, string sortindex)
        {
            return _iBrand.GetBrand(pageIndex, pageSize, orderBy, sortindex);

        }
        public IList<BO.Brand> GetBrandByObject(BO.Brand objBrand, int pageIndex, int pageSize, string orderBy, string sortindex)
        {
            return _iBrand.GetBrandByObject(objBrand, pageIndex, pageSize, orderBy, sortindex);

        }
        public IList<BO.Brand> GetBrandList()
        {
            return _iBrand.GetBrandList();

        }
        public IList<BO.Brand> GetBrandByOthersList(string columnsString)
        {
            return _iBrand.GetBrandByOthersList(columnsString);

        }
        public BO.Brand GetBrandByID(int SBG)
        {
            return _iBrand.GetBrandByID(SBG);

        }


        public IList<BO.Brand> GetBrandBySBG(int sbgID)
        {
            return _iBrand.GetBrandBySBG(sbgID);

        }


        public int GetBrandIDBrandName(string BrandName)
        {

            return BrandName.Trim() == "" ? 0 : _iBrand.GetBrandIDBrandName(BrandName);

        }


        public IList<BO.Brand> GetBrandList(int? SBID, int? SBGID, int? BrandID)
        {

            return _iBrand.GetBrandList(SBID, SBGID, BrandID);
        }

        public int InsertSBGWiseBrand(BO.Brand objBrand)
        {
            return _iBrand.InsertSBGWiseBrand(objBrand);
        }

        public int UpdateSBGWiseBrand(BO.Brand objBrand)
        {
            return _iBrand.UpdateSBGWiseBrand(objBrand);
        }


        public long GetSBGBrandIdByBrandIdSbgId(int brandID, int SBGID)
        {
            return _iBrand.GetSBGBrandIdByBrandIdSbgId(brandID, SBGID);
        }

        public void InsertSBGBrand(int SBGID, int brandID)
        {
            _iBrand.InsertSBGBrand(SBGID, brandID);
        }

        public IList<POS.BO.Brand> GetTerritoryWiseSBGAndBrand(long EmployeeID)
        {
            return _iBrand.GetTerritoryWiseSBGAndBrand(EmployeeID);
        }

        public int InsertDeleteTerritoryWiseSBGAndBrand(List<BO.Brand> objList)
        {
            return _iBrand.InsertDeleteTerritoryWiseSBGAndBrand(objList); 
        }

        public int UpdateTerritoryWiseSBGAndBrand(List<BO.Brand> objList) 
        {
            return _iBrand.UpdateTerritoryWiseSBGAndBrand(objList);
        }
        public IList<BO.Brand> GetSBGIDBrandIDByTerritoryID(long TerritoryID)
        {
            return _iBrand.GetSBGIDBrandIDByTerritoryID(TerritoryID); 
        }    

    }
}