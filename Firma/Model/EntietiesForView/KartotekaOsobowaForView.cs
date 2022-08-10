using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Firma.Model.EntietiesForView
{
    public class KartotekaOsobowaForView
    {
        public  int IdPracownika { get; set; }
        public string Imie { get; set; }
        public string Nazwisko { get; set; }
        public decimal? Pesel { get; set; }
        public DateTime? ZatrudnionyOd { get; set; }
        public DateTime? ZatrudnionyDo { get; set; }
        public DateTime? DataRozwiazania { get; set; }
        public DateTime? WaznoscUbezpieczenia { get; set; }
        public DateTime? WaznoscBadania { get; set; }
        public string Stanowisko { get; set; }
        public int IdOddzialu { get; set; }
        public string Plec { get; set; }
        public int? DniUrlopu { get; set; }
        public decimal? Stawka { get; set; }

    }
}
