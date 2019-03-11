using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace POS.IDAL
{


    public interface IBrand
    {
        int Insert(BO.Brand objBrand);

        int Update(BO.Brand objBrand);

        int Delete(int SBG);

        IList<BO.Brand> GetBrand(int pageIndex, int pageSize, string orderBy, string sortindex);

        IList<BO.Brand> GetBrandByObject(BO.Brand objBrand, int pageIndex, int pageSize, string orderBy, string sortindex);

        IList<BO.Brand> GetBrandList();
        IList<POS.BO.Brand> GetBrandList(int? BrandID, int? SBID, int? SBGID);
        BO.Brand GetBrandByID(int SBG);
        IList<BO.Brand> GetBrandByOthersList(string columnsString);

        int GetBrandIDBrandName(string BrandName);
        IList<BO.Brand> GetBrandBySBG(int sbgID);

        int InsertSBGWiseBrand(BO.Brand objBrand);
 
         
        int UpdateSBGWiseBrand(BO.Brand objBrand);

        long GetSBGBrandIdByBrandIdSbgId(int brandID, int SBGID);

        void InsertSBGBrand(int SBGID, int brandID);

        IList<BO.Brand> GetTerritoryWiseSBGAndBrand(long EmployeeID);

        int InsertDeleteTerritoryWiseSBGAndBrand(List<BO.Brand> objList); 

        int UpdateTerritoryWiseSBGAndBrand(List<BO.Brand> objList);

        IList<BO.Brand> GetSBGIDBrandIDByTerritoryID(long TerritoryID);
    }
}