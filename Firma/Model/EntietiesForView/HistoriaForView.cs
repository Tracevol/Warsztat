using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Firma.Model.EntietiesForView
{
    class HistoriaForView
    {
        public int IdHistorii { get; set; }
        public int IdPracownika { get; set; }
        public string Imie { get; set; }
        public string Nazwisko { get; set; }
        public int KategoriaHistorii { get; set; }
        public string Opis { get; set; }
        public string Dodajacy { get; set; }

    }
}
