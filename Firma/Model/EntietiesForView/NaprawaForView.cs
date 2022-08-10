using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Firma.Model.EntietiesForView
{
    class NaprawaForView
    {
        public int IdNaprawy { get; set; }
        public string Nazwa { get; set; }
        public DateTime? DataPrzyjecia { get; set; }
        public DateTime? DataOddania { get; set; }
        public decimal? KosztBrutto { get; set; }
        public string StatusRealizacji { get; set; }
        public string Uwagi { get; set; }
        public string Opiekun { get; set; }
    }
}
