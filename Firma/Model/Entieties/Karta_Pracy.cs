//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Firma.Model.Entieties
{
    using System;
    using System.Collections.Generic;
    
    public partial class Karta_Pracy
    {
        public int IdKartyPracy { get; set; }
        public Nullable<int> IdPracownika { get; set; }
        public Nullable<System.DateTime> DataOd { get; set; }
        public Nullable<System.DateTime> DataDo { get; set; }
        public Nullable<decimal> CzasPracy { get; set; }
        public string Czynnosci { get; set; }
        public string Uwagi { get; set; }
        public string StatusRozliczenia { get; set; }
        public bool CzyAktywny { get; set; }
    
        public virtual Kartoteka_Osobowa Kartoteka_Osobowa { get; set; }
    }
}
