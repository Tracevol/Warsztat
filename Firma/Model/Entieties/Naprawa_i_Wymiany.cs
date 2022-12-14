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
    
    public partial class Naprawa_i_Wymiany
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Naprawa_i_Wymiany()
        {
            this.Pozycja_Faktury = new HashSet<Pozycja_Faktury>();
        }
    
        public int IdNaprawy { get; set; }
        public Nullable<int> IdPojazdu { get; set; }
        public string Nazwa { get; set; }
        public Nullable<System.DateTime> DataPrzyjecia { get; set; }
        public Nullable<System.DateTime> DataOddania { get; set; }
        public Nullable<decimal> KosztBrutto { get; set; }
        public string StatusRealizacji { get; set; }
        public string Uwagi { get; set; }
        public string Opiekun { get; set; }
        public Nullable<bool> CzyAktywny { get; set; }
    
        public virtual Pojazdy Pojazdy { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Pozycja_Faktury> Pozycja_Faktury { get; set; }
    }
}
