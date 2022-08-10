using Firma.Model.EntietiesForView;
using Firma.ViewModel.Abstract;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Firma.ViewModel
{
    class HistoriaViewModel : WszystkieViewModel<HistoriaForView>
    {
        #region Constructor
        public HistoriaViewModel()
            : base ("Historia")
        {

        }
        #endregion

        #region Helpers
        public override void load()
        {
            List = new ObservableCollection<HistoriaForView>
                (
                    from historia in mVVMFirmaEntities.Historia
                    where historia.CzyAktywny == true
                    select new HistoriaForView
                    {
                        IdHistorii = historia.IdHistorii,
                        IdPracownika = (int)historia.IdPracownika,
                        Imie = historia.Kartoteka_Osobowa.Imie,
                        Nazwisko = historia.Kartoteka_Osobowa.Nazwisko,
                        KategoriaHistorii = (int)historia.KategoriaHistorii,
                        Opis = historia.Opis,
                        Dodajacy = historia.Dodajacy                   
                    }
                );
        }
        #endregion

        #region Sortowanie i filtrowanie
        public override void Sort()
        {
        }

        public override List<string> GetComboboxSortList()
        {
            return new List<string> { };
        }


        public override void Find()
        {
            load();

        }

        public override List<string> GetComboboxFindList()
        {
            return new List<string> { };
        }

        public override List<string> GetComboboxFindTypeList()
        {
            return new List<string> { "Zaczyna się od", "Zawiera" };
        }
        #endregion

    }
}
