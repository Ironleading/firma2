//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace firma2.Models.Entity
{
    using System;
    using System.Collections.Generic;
    
    public partial class CAGRIFIRMA
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CAGRIFIRMA()
        {
            this.CAGRIDETAY = new HashSet<CAGRIDETAY>();
        }
    
        public int ID { get; set; }
        public Nullable<int> CAGRIFIRMA1 { get; set; }
        public string KONU { get; set; }
        public string ACIKLAMA { get; set; }
        public Nullable<bool> Durum { get; set; }
        public Nullable<System.DateTime> TARİH { get; set; }
    
        public virtual COMPANIES COMPANIES { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CAGRIDETAY> CAGRIDETAY { get; set; }
    }
}