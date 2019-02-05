using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace POS.COMMON
{
    public class Utility
    {
        public static List<Years> YearList(int startYear)
        {
            try
            {
                List<Years> returnList = new List<Years>();
                while (startYear <= DateTime.Now.Year)
                {
                    returnList.Add(new Years { YearNo = startYear });
                    startYear++;
                }

                return returnList.OrderByDescending(m => m.YearNo).ToList();
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }
        public static List<Months> MonthList(int currentYear)
        {
            try
            {
                List<Months> returnList = new List<Months>();
                if (currentYear == DateTime.Now.Year)
                {
                    for (int index = 0; index < DateTime.Now.Month; index++)
                    {
                        returnList.Add(new Months { MonthNo = index + 1, MonthName = new System.Globalization.DateTimeFormatInfo().GetMonthName(index + 1) });
                    }
                }
                else
                {
                    for (int index = 0; index < 12; index++)
                    {
                        returnList.Add(new Months { MonthNo = index + 1, MonthName = new System.Globalization.DateTimeFormatInfo().GetMonthName(index + 1) });
                    }
                }

                return returnList.OrderByDescending(m => m.MonthNo).ToList();
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        public string GetMonthName(int month)
        {
            return
                  month == 1 ? MonthName.Jan.ToString()
                : month == 2 ? MonthName.Feb.ToString()
                : month == 3 ? MonthName.Mar.ToString()
                : month == 4 ? MonthName.Apr.ToString()
                : month == 5 ? MonthName.May.ToString()
                : month == 6 ? MonthName.Jun.ToString()
                : month == 7 ? MonthName.Jul.ToString()
                : month == 8 ? MonthName.Aug.ToString()
                : month == 9 ? MonthName.Sep.ToString()
                : month == 10 ? MonthName.Oct.ToString()
                : month == 11 ? MonthName.Nob.ToString()
                : MonthName.Dec.ToString();

        }

    }

    public class Months
    {
        private int _MonthNo;
        private String _MonthName;

        public String MonthName
        {
            get { return _MonthName; }
            set { _MonthName = value; }
        }

        public int MonthNo
        {
            get { return _MonthNo; }
            set { _MonthNo = value; }
        }
    }
    public class Years
    {
        private int _yearNo;

        public int YearNo
        {
            get { return _yearNo; }
            set { _yearNo = value; }
        }
    }

   

    public enum MonthName
    {
        Jan, Feb, Mar, Apr, May, Jun, Jul, Aug, Sep, Oct, Nob, Dec
    }
}
