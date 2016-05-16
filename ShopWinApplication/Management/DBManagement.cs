using ShopWinApplication.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShopWinApplication.Data.ViewModels;

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

        public static List<Location> GetLocationsForItem()
        {
            List<Location> returnedList = (from u in GetDB().Locations
                                       select u).ToList();
            returnedList.Insert(0, new Location() { ID = -1, Name = "<إختر مكان الصنف>" });
            return returnedList;
        }

        public static Supplier GetBestItemCategorySupplier(ItemCategory itCat)
        {
            var bestSupplier = itCat.ItemCategorySuppliers.OrderBy(x => x.Rate).First();
            if (bestSupplier != null)
                return bestSupplier.Supplier;
            return null;
        }

        public static List<ItemCategoryForSupplier> GetItemCategoriesForSuppliers(long ID, bool includeAll = false)
        {
            if (ID == -1)
            {
                List<ItemCategoryForSupplier> listReturned = new List<ItemCategoryForSupplier>();
                listReturned = (from itCat in GetDB().ItemCategories
                                select new ItemCategoryForSupplier()
                                    {
                                        CategoryID = itCat.ID,
                                        CategoryName = itCat.Name,
                                        IsSupplied = false,
                                        Rate = 0
                                    }
                                ).ToList();
                return listReturned;
            }
            else
            {
                List<ItemCategoryForSupplier> listReturned = new List<ItemCategoryForSupplier>();
                listReturned = (from itCat in GetDB().ItemCategories
                                join subCat in GetDB().ItemCategorySuppliers
                                on itCat.ID equals subCat.ItemCategoryID
                                where subCat.SupplierID == ID
                                select new ItemCategoryForSupplier()
                                {
                                    CategoryID = itCat.ID,
                                    CategoryName = itCat.Name,
                                    IsSupplied = true,
                                    Rate = subCat.Rate
                                }
                                ).ToList();
                if (includeAll)
                {
                    List<ItemCategoryForSupplier> listAll = GetItemCategoriesForSuppliers(-1);
                    foreach (var it in listReturned)
                    {
                        ItemCategoryForSupplier found = listAll.Where(x => x.CategoryID == it.CategoryID).FirstOrDefault();
                        if (found != null)
                        {
                            found.IsSupplied = true;
                            found.Rate = it.Rate;
                        }
                    }
                    return listAll;
                }

                return listReturned;
            }
        }
    }
}
