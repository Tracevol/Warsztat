using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Firma.Model.EntietiesForView
{
    class SzkoleniaOkresoweForView
    {
        public int IdSzkolenia { get; set; }
        public int IdPracownika { get; set; }
        public string Imie { get; set; }
        public string Nazwisko { get; set; }
        public string RodzajSzkolenia { get; set; }
        public DateTime? DataSzkolenia { get; set; }
        public DateTime? DataWaznosci { get; set; }
        public string Uwagi { get; set; }

    }
}
