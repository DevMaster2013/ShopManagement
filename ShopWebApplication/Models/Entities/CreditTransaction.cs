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
    
    public partial class CreditTransaction
    {
        public long ID { get; set; }
        public long CreditID { get; set; }
        public System.DateTime PaymentDate { get; set; }
        public decimal PayedAmount { get; set; }
    
        public virtual Credit Credit { get; set; }
    }
}
