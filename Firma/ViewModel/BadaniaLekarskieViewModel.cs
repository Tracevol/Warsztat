using Firma.Helpers;
using Firma.Model.Entieties;
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
    class BadaniaLekarskieViewModel : WszystkieViewModel<BadaniaLekarskieForView>
    {
        #region Constructor
        public BadaniaLekarskieViewModel()
            : base("Badania")
        {

        }
        #endregion

        #region Helpers
        public override void load()
        {
            List = new ObservableCollection<BadaniaLekarskieForView>
                (
                    from badania_lekarskie in mVVMFirmaEntities.Badania_Lekarskie
                    where badania_lekarskie.CzyAktywny == true
                    select new BadaniaLekarskieForView
                    {
                        IdBadan = badania_lekarskie.IdBadan,
                        IdPracownika = badania_lekarskie.Kartoteka_Osobowa.IdPracownika,
                        Imie = badania_lekarskie.Kartoteka_Osobowa.Imie,
                        Nazwisko = badania_lekarskie.Kartoteka_Osobowa.Nazwisko,
                        RodzajBadania = badania_lekarskie.RodzajBadania,
                        DataOd = badania_lekarskie.DataOd,
                        DataDo = badania_lekarskie.DataDo,
                        Status = badania_lekarskie.Status,
                        Uwagi = badania_lekarskie.Uwagi
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
            return new List<string> {};
        }

        public override List<string> GetComboboxFindTypeList()
        {
            return new List<string> { "Zaczyna się od", "Zawiera" };
        }

        #endregion
    }
}
