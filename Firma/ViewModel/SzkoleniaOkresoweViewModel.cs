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
    class SzkoleniaOkresoweViewModel : WszystkieViewModel<SzkoleniaOkresoweForView>
    {
        #region Constructor
        public SzkoleniaOkresoweViewModel()
             : base ("Szkolenia")
        {
           
        }
        #endregion

        #region Helpers
        public override void load()
        {
            List = new ObservableCollection<SzkoleniaOkresoweForView>
                (
                    from szkolenia_okresowe in mVVMFirmaEntities.Szkolenia_Okresowe
                    where szkolenia_okresowe.CzyAktywne == true
                    select new SzkoleniaOkresoweForView
                    {
                        IdSzkolenia = szkolenia_okresowe.IdSzkolenia,
                        IdPracownika = szkolenia_okresowe.Kartoteka_Osobowa.IdPracownika,
                        Imie = szkolenia_okresowe.Kartoteka_Osobowa.Imie,
                        Nazwisko = szkolenia_okresowe.Kartoteka_Osobowa.Nazwisko,
                        RodzajSzkolenia = szkolenia_okresowe.RodzajSzkolenia,
                        DataSzkolenia = szkolenia_okresowe.DataSzkolenia,
                        DataWaznosci = szkolenia_okresowe.DataWaznosci,
                        Uwagi = szkolenia_okresowe.Uwagi
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

        #endregion

        public override List<string> GetComboboxFindTypeList()
        {
            return new List<string> { "Zaczyna się od", "Zawiera" };
        }
    }
}
