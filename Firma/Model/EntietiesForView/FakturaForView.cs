using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Firma.Model.EntietiesForView
{
    class FakturaForView
    {
        public int IdFaktury { get; set; }
        public string NrFaktury { get; set; }
        public DateTime? DataWystawienia { get; set; }
        public DateTime? TerminPlatnosci { get; set; }
        public string NazwaProduktu { get; set; }
        public int? Ilosc { get; set; }
        public int? Rabat { get; set; }
        public decimal? Cena { get; set; }
        public int? Marza { get; set; }
    }
}
