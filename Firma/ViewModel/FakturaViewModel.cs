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
    class FakturaViewModel : WszystkieViewModel<FakturaForView>
    {
        #region Constructor

        public FakturaViewModel()
           : base("Faktura")
        {

        }
        #endregion


        #region Helpers
        public override void load()
        {
            List = new ObservableCollection<FakturaForView>
                (
                    from faktura in mVVMFirmaEntities.Faktura
                    where faktura.CzyAktywny == true
                    select new FakturaForView
                    {
                        IdFaktury = faktura.IdFaktury,
                        NrFaktury = faktura.NrFaktury,
                        DataWystawienia = faktura.DataWystawienia,
                        TerminPlatnosci = faktura.TerminPlatnosci,
                        NazwaProduktu = faktura.NazwaProduktu,
                        Ilosc = faktura.Ilosc,
                        Rabat = faktura.Rabat,
                        Cena = faktura.Cena,
                        Marza = (int)faktura.Marza
                    }
                );
        }
        #endregion

        #region Sortowanie i filtrowanie
        public override void Sort()
        {
            load();
            if (SortField == "Nr faktury")
                List = new ObservableCollection<FakturaForView>(List.OrderBy(person => person.NrFaktury));
            if (SortField == "Nazwa produktu")
                List = new ObservableCollection<FakturaForView>(List.OrderBy(person => person.NazwaProduktu));
            if (SortField == "Cena")
                List = new ObservableCollection<FakturaForView>(List.OrderBy(person => person.Cena));

        }

        public override List<string> GetComboboxSortList()
        {
            return new List<string> { "NrFaktury", "NazwaProduktu", "Ilość" };
        }


        public override void Find()
        {
            load();
            if (FindTypeField == "Zawiera")
            {
                if (FindField == "Ilość")
                    List = new ObservableCollection<FakturaForView>(List.Where(person => person.Ilosc != null && person.Ilosc.ToString().Contains(FindTextBox)));
                if (FindField == "Marża")
                    List = new ObservableCollection<FakturaForView>(List.Where(person => person.Marza != null && person.Marza.ToString().Contains(FindTextBox)));
                if (FindField == "Rabat")
                    List = new ObservableCollection<FakturaForView>(List.Where(person => person.Rabat != null && person.Rabat.ToString().Contains(FindTextBox)));
            }
            else
            {
                if (FindField == "Ilość")
                    List = new ObservableCollection<FakturaForView>(List.Where(person => person.Ilosc != null && person.Ilosc.ToString().StartsWith(FindTextBox)));
                if (FindField == "Marża")
                    List = new ObservableCollection<FakturaForView>(List.Where(person => person.Marza != null && person.Marza.ToString().StartsWith(FindTextBox)));
                if (FindField == "Rabat")
                    List = new ObservableCollection<FakturaForView>(List.Where(person => person.Rabat != null && person.Rabat.ToString().StartsWith(FindTextBox)));
            }
        }

        public override List<string> GetComboboxFindList()
        {
            return new List<string> {"Marża", "Cena", "Rabat"};
        }

        public override List<string> GetComboboxFindTypeList()
        {
            return new List<string> { "Zawiera", "Zaczyna się od" };
        }

        #endregion

    }
}
