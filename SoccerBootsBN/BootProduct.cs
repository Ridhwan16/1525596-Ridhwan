//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SoccerBootsBN
{
    using System;
    using System.Collections.Generic;
    
    public partial class BootProduct
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public BootProduct()
        {
            this.BootCarts = new HashSet<BootCart>();
        }
    
        public int ID { get; set; }
        public int ShoeType { get; set; }
        public string ShoeName { get; set; }
        public Nullable<int> Price { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BootCart> BootCarts { get; set; }
        public virtual BootType BootType { get; set; }
    }
}
