//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MultiligaApp
{
    using System;
    using System.Collections.Generic;
    
    public partial class wyscig
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public wyscig()
        {
            this.wynik_wyscigu = new HashSet<wynik_wyscigu>();
            this.zawodnik = new HashSet<zawodnik>();
            this.zawody = new HashSet<zawody>();
            this.zawody1 = new HashSet<zawody>();
        }
    
        public int id_wyscig { get; set; }
        public int id_zawody { get; set; }
        public string miasto { get; set; }
        public Nullable<int> id_trasa { get; set; }
        public System.DateTime data { get; set; }
    
        public virtual trasa trasa { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<wynik_wyscigu> wynik_wyscigu { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<zawodnik> zawodnik { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<zawody> zawody { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<zawody> zawody1 { get; set; }
    }
}
