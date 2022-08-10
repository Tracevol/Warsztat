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
    
    public partial class Indeks_Produktow
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Indeks_Produktow()
        {
            this.Magazyn1 = new HashSet<Magazyn>();
            this.Produkty_w_Dokumentach = new HashSet<Produkty_w_Dokumentach>();
            this.Pozycja_Faktury = new HashSet<Pozycja_Faktury>();
        }
    
        public int IdProduktu { get; set; }
        public byte[] JPG { get; set; }
        public string Nazwa { get; set; }
        public string Producent { get; set; }
        public Nullable<decimal> Sztuk { get; set; }
        public Nullable<decimal> CennaNetto { get; set; }
        public Nullable<decimal> CennaBrutto { get; set; }
        public Nullable<decimal> StawkaVat { get; set; }
        public Nullable<int> IdMagazynu { get; set; }
        public Nullable<decimal> KodKreskowy { get; set; }
        public Nullable<int> NrSeryjny { get; set; }
        public string Waluta { get; set; }
        public Nullable<bool> CzyAktywny { get; set; }
    
        public virtual Magazyn Magazyn { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Magazyn> Magazyn1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Produkty_w_Dokumentach> Produkty_w_Dokumentach { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Pozycja_Faktury> Pozycja_Faktury { get; set; }
    }
}