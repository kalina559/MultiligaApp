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
    
    public partial class wynik
    {
        public int id_wynik { get; set; }
        public int id_zawodnik { get; set; }
        public int id_wyscig { get; set; }
        public Nullable<System.TimeSpan> czas { get; set; }
    
        public virtual wyscig wyscig { get; set; }
        public virtual zawodnik zawodnik { get; set; }
    }
}
