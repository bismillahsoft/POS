using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.UI.WebControls;



namespace POS.COMMON
{
    public static class GRV
    {
        public static void PopulateGrid<T>(this List<T> objectList, GridView grvGrid)
        {


            //short index = 1;
            //foreach (var obj in objectList)
            //{
            //    //obj.Sln  = index++;

            //}
            grvGrid.DataSource = objectList;
            grvGrid.DataBind();
        }

    }
}
