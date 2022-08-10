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
    class WnioskiUrlopoweViewModel : WszystkieViewModel<WnioskiUrlopoweForView>
    {
        #region Constructor
        public WnioskiUrlopoweViewModel()
             : base ("Wnioski urlopowe")
        {
           
        }


        #endregion

        #region Helpers
        public override void load()
        {
            List = new ObservableCollection<WnioskiUrlopoweForView>
                (
                    from wnioski_urlopowe in mVVMFirmaEntities.Wnioski_Urlopowe
                    where wnioski_urlopowe.CzyAktywne == true
                    select new WnioskiUrlopoweForView
                    {
                        IdWniosku = wnioski_urlopowe.IdWniosku,
                        IdPracownika = wnioski_urlopowe.Kartoteka_Osobowa.IdPracownika,
                        Imie = wnioski_urlopowe.Kartoteka_Osobowa.Imie,
                        Nazwisko = wnioski_urlopowe.Kartoteka_Osobowa.Nazwisko,
                        DataOd = wnioski_urlopowe.DataOd,
                        DataDo = wnioski_urlopowe.DataDo,
                        IloscDni = (int)wnioski_urlopowe.IloscDni,
                        Uwagi = wnioski_urlopowe.Uwagi,
                        Status = wnioski_urlopowe.Status
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
