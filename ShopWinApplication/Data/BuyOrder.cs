//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ShopWinApplication.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class BuyOrder
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public BuyOrder()
        {
            this.BuyOrderItems = new HashSet<BuyOrderItem>();
            this.Debits = new HashSet<Debit>();
        }
    
        public long ID { get; set; }
        public System.DateTime OrderDate { get; set; }
        public long SupplierID { get; set; }
        public Nullable<decimal> Discount { get; set; }
        public Nullable<decimal> PayedAmount { get; set; }
    
        public virtual Supplier Supplier { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BuyOrderItem> BuyOrderItems { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Debit> Debits { get; set; }
    }
}
