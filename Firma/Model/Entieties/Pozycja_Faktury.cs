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
    
    public partial class Pozycja_Faktury
    {
        public int IdPozycjaFaktury { get; set; }
        public Nullable<int> IdFaktury { get; set; }
        public Nullable<int> IdProduktu { get; set; }
        public Nullable<int> IdNaprawy { get; set; }
        public string NrFaktury { get; set; }
        public Nullable<System.DateTime> TerminPlatnosci { get; set; }
        public Nullable<int> IdPlatnosci { get; set; }
        public Nullable<bool> CzyAktwyny { get; set; }
    
        public virtual Faktura Faktura { get; set; }
        public virtual Indeks_Produktow Indeks_Produktow { get; set; }
        public virtual Naprawa_i_Wymiany Naprawa_i_Wymiany { get; set; }
        public virtual Sposob_Platnosci Sposob_Platnosci { get; set; }
    }
}
