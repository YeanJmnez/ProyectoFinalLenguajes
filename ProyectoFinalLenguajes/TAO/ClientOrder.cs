//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TAO
{
    using System;
    using System.Collections.Generic;
    
    public partial class ClientOrder
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ClientOrder()
        {
            this.OrderDetails = new HashSet<OrderDetail>();
        }
    
        public int OrderCode { get; set; }
        public string OrderState { get; set; }
        public decimal TotalPrice { get; set; }
        public System.DateTime DateHourIn { get; set; }
        public Nullable<System.DateTime> DateHourOut { get; set; }
        public string ClientEmail { get; set; }
    
        public virtual Client Client { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
    }
}