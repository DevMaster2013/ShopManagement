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
    
    public partial class Debit
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Debit()
        {
            this.DebitTransactions = new HashSet<DebitTransaction>();
        }
    
        public long ID { get; set; }
        public long BuyOrderID { get; set; }
        public System.DateTime PaymentDate { get; set; }
    
        public virtual BuyOrder BuyOrder { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DebitTransaction> DebitTransactions { get; set; }
    }
}
