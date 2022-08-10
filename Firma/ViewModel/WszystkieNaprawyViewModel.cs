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
    class WszystkieNaprawyViewModel : WszystkieViewModel<NaprawaForView>
    {
        #region Constructor

        public WszystkieNaprawyViewModel()
           : base("Naprawy")
        {

        }
        #endregion

        #region Properties
        public IQueryable<KeyAndValue> PracownicyComboBoxItems
        {
            get
            {
                return
                    (
                       from naprawy_i_wymiany in mVVMFirmaEntities.Naprawa_i_Wymiany
                       select new KeyAndValue
                       {
                           Key = naprawy_i_wymiany.IdNaprawy,
                           Value = naprawy_i_wymiany.Nazwa + " " + naprawy_i_wymiany.Opiekun +" "+ naprawy_i_wymiany.KosztBrutto
                       }
                    ).ToList().AsQueryable();


            }
        }

        #endregion

        #region Helpers
        public override void load()
        {
            List = new ObservableCollection<NaprawaForView>
                (
                    from naprawy_i_wymiany in mVVMFirmaEntities.Naprawa_i_Wymiany
                    where naprawy_i_wymiany.CzyAktywny == true
                    select new NaprawaForView
                    {
                        IdNaprawy = naprawy_i_wymiany.IdNaprawy,
                        Nazwa = naprawy_i_wymiany.Nazwa,
                        DataPrzyjecia = naprawy_i_wymiany.DataPrzyjecia,
                        DataOddania = naprawy_i_wymiany.DataOddania,
                        KosztBrutto = naprawy_i_wymiany.KosztBrutto,
                        StatusRealizacji = naprawy_i_wymiany.StatusRealizacji,
                        Uwagi = naprawy_i_wymiany.Uwagi,
                        Opiekun = naprawy_i_wymiany.Opiekun
                    }
                );

        }
        #endregion

        #region Sortowanie i filtrowanie
        public override void Sort()
        {
            if (SortField == "Nazwa")
                List = new ObservableCollection<NaprawaForView>(List.OrderBy(person => person.Nazwa));
            if (SortField == "Koszt brutto")
                List = new ObservableCollection<NaprawaForView>(List.OrderBy(person => person.KosztBrutto));
            if (SortField == "Data przyjęcia")
                List = new ObservableCollection<NaprawaForView>(List.OrderBy(person => person.DataPrzyjecia));
            if (SortField == "Data oddania")
                List = new ObservableCollection<NaprawaForView>(List.OrderBy(person => person.DataOddania));
        }

        public override List<string> GetComboboxSortList()
        {
            return new List<string> { "Nazwa", "Koszt brutto", "Data przyjęcia", "Data oddania" };
        }


        public override void Find()
        {
            load();
            if (FindTypeField == "Zawiera")
            {
                if (FindField == "Opiekun")
                    List = new ObservableCollection<NaprawaForView>(List.Where(person => person.Opiekun != null && person.Opiekun.Contains(FindTextBox)));
                if (FindField == "Status realizacji")
                    List = new ObservableCollection<NaprawaForView>(List.Where(person => person.StatusRealizacji != null && person.StatusRealizacji.Contains(FindTextBox)));
            }
            else
            {
                if (FindField == "Opiekun")
                    List = new ObservableCollection<NaprawaForView>(List.Where(person => person.Opiekun != null && person.Opiekun.StartsWith(FindTextBox)));
                if (FindField == "StatusRealizacji")
                    List = new ObservableCollection<NaprawaForView>(List.Where(person => person.StatusRealizacji != null && person.StatusRealizacji.StartsWith(FindTextBox)));
            }

        }
        public override List<string> GetComboboxFindList()
        {
            return new List<string> { "Opiekun", "Status realizacji", };
        }
        public override List<string> GetComboboxFindTypeList()
        {
            return new List<string> { "Zaczyna się od", "Zawiera" };
        }

        #endregion

    }
}
