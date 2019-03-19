using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace POS.IDAL
{


    public interface IProductGeneric
    {
        Int32 Insert(BO.ProductGeneric objProductGeneric);

        Int32 Update(BO.ProductGeneric objProductGeneric, Int32 PGenericID);
        Int32 Update(BO.ProductGeneric objProductGeneric);


        Int32 Delete(Int32 PGenericID);

        IList<BO.ProductGeneric> GetProductGeneric(Int32 pageIndex, Int32 pageSize, String orderBy, String sortindex);

        IList<BO.ProductGeneric> GetProductGenericByObject(BO.ProductGeneric objProductGeneric, Int32 pageIndex, Int32 pageSize, String orderBy, String sortindex);

        IList<BO.ProductGeneric> GetProductGenericList();
        BO.ProductGeneric GetProductGenericByID(Int32 PGenericID);
        IList<BO.ProductGeneric> GetProductGenericByOthersList(String columnsString);


        int GetGenericIDByName(string genericName);
    }
}