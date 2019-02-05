using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace POS.COMMON
{
    public class MemberShips : DCommon
    {
        public bool CheckMemberShip(string userID, string Password)
        {
            try
            {
                return IsUserValid(userID, Password);
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        public bool IsUserValidForMobile(string userID, string Password)
        {
            try
            {
                bool returnStatus = false;
                querry = @" select TOP 1    isnull(SecuredUser.SecureWord,users.Password) as Password   from dbo.Employee
                inner join users on users.EmployeeId = Employee.EmployeeId
                left join dbo.SecuredUser on SecuredUser.EmployeeId = Employee.EmployeeId
                where users.UserID   = '" + userID + "' AND POST > 3";
                DataTable dt = ExecuteQuerry(querry).Tables[0];
                if (dt.Rows.Count > 0)
                {
                    if (dt.Rows[0][0].ToString() == Password)
                    {
                        returnStatus = true;
                    }
                    else
                    {
                        returnStatus = false;
                    }
                }
                else
                {
                    returnStatus = false;
                }
                return returnStatus;
            }
            catch (System.Exception ex)
            {
                throw ex;
            }
        }




        /// <summary>
        /// used to protect online user
        /// </summary>
        /// <param name="UserId"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public bool IsUserValid(string UserId, string password)
        {
            try
            {
                bool returnStatus = false;
                querry = @" select TOP 1    set_users.Password as Password   from dbo.set_users
                inner join HRM_PIEmployement on set_users.EmployeeID = HRM_PIEmployement.PIID
                where set_users.UserID   = '" + UserId + "' AND HRM_PIEmployement.DesignationID < 5";
                DataTable dt = ExecuteQuerry(querry).Tables[0];
                if (dt.Rows.Count > 0) 
                {

                    if (dt.Rows[0][0].ToString() == password)
                    {

                        returnStatus = true;
                    }
                    else
                    {
                        returnStatus = false;

                    }
                }
                else
                {
                    returnStatus = false;

                }
                return returnStatus;
            }
            catch (System.Exception ex)
            {

                throw ex;
            }

        }
        /// <summary>
        /// used to protect online user
        /// </summary>
        /// <param name="UserId"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public bool IsDepoUserValid(string UserId, string password)
        {
            try
            {


                bool returnStatus = false;

                querry = @" select TOP 1    isnull(SecuredUser.SecureWord,users.Password) as Password   from dbo.Employee
                inner join users on users.EmployeeId = Employee.EmployeeId
                left join dbo.SecuredUser on SecuredUser.EmployeeId = Employee.EmployeeId
                where users.UserID   = '" + UserId + "' AND POST < 5";
                DataTable dt = ExecuteQuerry(querry).Tables[0];

                if (dt.Rows.Count > 0)
                {
                    if (dt.Rows[0][0].ToString() == password)
                    {
                        returnStatus = true;
                    }
                    else
                    {
                        returnStatus = false;

                    }
                }
                else
                {
                    returnStatus = false;

                }
                return returnStatus;
            }
            catch (System.Exception ex)
            {

                throw ex;
            }

        }
    }
}
