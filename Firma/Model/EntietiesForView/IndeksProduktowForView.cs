using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Firma.Model.EntietiesForView
{
    public class IndeksProduktowForView
    {
        public int IdProduktu { get; set; }
        public string Nazwa { get; set; }
        public string Producent { get; set; }
        public decimal? Sztuk { get; set; }
        public decimal? CennaNetto { get; set; }
        public decimal? CennaBrutto { get; set; }
        public decimal? StawkaVat { get; set; }
        public decimal? KodKreskowy { get; set; }
        public int NrSeryjny { get; set; }
        public string Waluta { get; set; }
       // public decimal? IloscSztuk { get; set; }
    }
}
