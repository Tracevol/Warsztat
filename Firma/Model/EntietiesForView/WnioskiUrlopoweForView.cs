using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Firma.Model.EntietiesForView
{
    class WnioskiUrlopoweForView
    {
        public int IdWniosku { get; set; }
        public int IdPracownika { get; set; }
        public string Imie { get; set; }
        public string Nazwisko { get; set; }
        public string RodzjaUrlopu { get; set; }
        public DateTime? DataOd { get; set; }
        public DateTime? DataDo { get; set; }
        public int IloscDni { get; set; }
        public string Uwagi { get; set; }
        public string Status { get; set; }

    }
}
