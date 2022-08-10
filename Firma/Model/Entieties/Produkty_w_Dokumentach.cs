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
    
    public partial class Produkty_w_Dokumentach
    {
        public int IdPwD { get; set; }
        public Nullable<int> IdProduktu { get; set; }
        public string NrDokumentu { get; set; }
        public Nullable<System.DateTime> DataPowstania { get; set; }
        public string TypDokumentu { get; set; }
        public Nullable<decimal> IloscProduktow { get; set; }
        public Nullable<decimal> WydanychProduktow { get; set; }
        public Nullable<System.DateTime> DataWaznosci { get; set; }
        public string Seria { get; set; }
        public string Komentarz { get; set; }
        public string Skladowanie { get; set; }
        public string Uwagi { get; set; }
        public Nullable<int> IdMagazynu { get; set; }
        public Nullable<int> IdFaktury { get; set; }
        public Nullable<int> KodKreskowy { get; set; }
        public bool CzyAktywny { get; set; }
    
        public virtual Faktura Faktura { get; set; }
        public virtual Indeks_Produktow Indeks_Produktow { get; set; }
        public virtual Magazyn Magazyn { get; set; }
    }
}