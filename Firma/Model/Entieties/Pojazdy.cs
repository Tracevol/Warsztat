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
    
    public partial class Pojazdy
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Pojazdy()
        {
            this.Naprawa_i_Wymiany = new HashSet<Naprawa_i_Wymiany>();
        }
    
        public int IdPojazdu { get; set; }
        public Nullable<int> IdKlienta { get; set; }
        public byte[] Zdjecie { get; set; }
        public string Marka { get; set; }
        public string Model { get; set; }
        public string NrRejestracyjny { get; set; }
        public Nullable<System.DateTime> UbezpieczenieDo { get; set; }
        public Nullable<System.DateTime> BadanieDo { get; set; }
        public Nullable<int> PojemnoscSilnika_cm_3_ { get; set; }
        public Nullable<int> RokProdukcji { get; set; }
        public Nullable<int> Przebieg { get; set; }
        public Nullable<bool> CzyAktywny { get; set; }
    
        public virtual Klient Klient { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Naprawa_i_Wymiany> Naprawa_i_Wymiany { get; set; }
    }
}