using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace POS.COMMON
{
    public static class DDL
    {
        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="objectList"></param>
        /// <param name="dropdownlist"></param>
        /// <param name="dataValueField"></param>
        /// <param name="dataTextField"></param>
        /// <param name="selectedText"></param>
        /// <param name="SelectedValue"></param>
        public static void PopulateDropDownList<T>(this List<T> objectList, ComboBox dropdownlist, String dataValueField, String dataTextField, string selectedText = "--Select--", string SelectedValue = "-99")
        {
            try
            {
                dropdownlist.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                dropdownlist.AutoCompleteSource = AutoCompleteSource.ListItems;
                dropdownlist.ValueMember = dataValueField;
                dropdownlist.DisplayMember = dataTextField;
                dropdownlist.DataSource = objectList;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


    }
}
