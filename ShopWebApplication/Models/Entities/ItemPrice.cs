//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ShopWebApplication.Models.Entities
{
    using System;
    using System.Collections.Generic;
    
    public partial class ItemPrice
    {
        public long ID { get; set; }
        public long ItemUnitID { get; set; }
        public decimal SellPrice { get; set; }
        public decimal BuyPrice { get; set; }
    
        public virtual ItemUnit ItemUnit { get; set; }
    }
}