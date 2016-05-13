using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopWinApplication.Data.ViewModels
{
    public class ItemCategoryForSupplier
    {
        public long CategoryID { get; set; }
        public string CategoryName { get; set; }
        public bool IsSupplied { get; set; }
        public int? Rate { get; set; }
    }
}
