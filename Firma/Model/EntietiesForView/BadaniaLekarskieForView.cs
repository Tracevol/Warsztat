using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Firma.Model.EntietiesForView
{
    class BadaniaLekarskieForView
    {
        public int IdBadan { get; set; }
        public int IdPracownika { get; set; }
        public string Imie { get; set; }
        public string Nazwisko { get; set; }
        public string RodzajBadania { get; set; }
        public DateTime? DataOd { get; set; }
        public DateTime? DataDo { get; set; }
        public string Status { get; set; }
        public string Uwagi { get; set; }
    }
}
