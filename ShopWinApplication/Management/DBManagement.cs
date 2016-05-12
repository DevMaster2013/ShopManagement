using ShopWinApplication.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopWinApplication.Management
{
    public static class DBManagement
    {
        private static ShopDataEntities db = new ShopDataEntities();
        public static ShopDataEntities GetDB()
        {
            return db;
        }

        public static List<Unit> GetBaseUnitsExcept(long ID)
        {
            List<Unit> returnedList = (from u in GetDB().Units
                                       where u.ID != ID
                                       select u).ToList();
            returnedList.Insert(0, new Unit() { ID = -1, Name = "<إختر وحدة أساسية>" });
            return returnedList;
        }
    }
}
