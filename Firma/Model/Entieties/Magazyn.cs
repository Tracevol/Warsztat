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
    
    public partial class Magazyn
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Magazyn()
        {
            this.Indeks_Produktow = new HashSet<Indeks_Produktow>();
            this.Produkty_w_Dokumentach = new HashSet<Produkty_w_Dokumentach>();
        }
    
        public int IdMagazynu { get; set; }
        public Nullable<int> IdProduktu { get; set; }
        public string NazwaMagazynu { get; set; }
        public Nullable<int> IdAdresu { get; set; }
        public Nullable<bool> CzyAktywny { get; set; }
    
        public virtual Adresy Adresy { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Indeks_Produktow> Indeks_Produktow { get; set; }
        public virtual Indeks_Produktow Indeks_Produktow1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Produkty_w_Dokumentach> Produkty_w_Dokumentach { get; set; }
    }
}
