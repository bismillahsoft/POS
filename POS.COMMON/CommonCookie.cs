using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace POS.COMMON
{
    public static class CommonCookie
    {
        public enum cookName { userCook = 0 }
        public enum CookValue { userID = 0, userName = 1, password = 2 }
    }
    public enum MySession
    {
        SB,
        SBG,
        DepotId,
        RegionId,
        AreaID,
        TerritoryID,

        SessionId,
        ManagerId,
        UserId,
        UserName,
        Post,
        EmployeeId,
        Pages,
        TeamId
    }

}
