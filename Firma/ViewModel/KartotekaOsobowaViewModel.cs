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
    public class KartotekaOsobowaViewModel : WszystkieViewModel<KartotekaOsobowaForView>
    {
        #region Constructor
      
        public KartotekaOsobowaViewModel()
           : base("Kartoteka")
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
                       from kartoteka_osobowa in mVVMFirmaEntities.Kartoteka_Osobowa
                       select new KeyAndValue
                       {
                           Key = kartoteka_osobowa.IdPracownika,
                           Value = kartoteka_osobowa.Imie + " " + kartoteka_osobowa.Nazwisko + "-" + kartoteka_osobowa.Stanowisko + " " + kartoteka_osobowa.DniUrlopu
                       }
                    ).ToList().AsQueryable();


            }
        }

        #endregion

        #region Helpers
        public override void load()
        {
            List = new ObservableCollection<KartotekaOsobowaForView>
                (
                    from kartoteka_osobowa in mVVMFirmaEntities.Kartoteka_Osobowa
                    where kartoteka_osobowa.CzyAktywny == true
                    select new KartotekaOsobowaForView
                    {
                        IdPracownika = kartoteka_osobowa.IdPracownika,
                        Imie = kartoteka_osobowa.Imie,
                        Nazwisko = kartoteka_osobowa.Nazwisko,
                        Pesel = kartoteka_osobowa.Pesel,
                        ZatrudnionyOd = kartoteka_osobowa.ZatrudnionyOd,
                        ZatrudnionyDo = kartoteka_osobowa.ZatrudnionyDo,
                        DataRozwiazania = kartoteka_osobowa.DataRozwiazania,
                        WaznoscUbezpieczenia = kartoteka_osobowa.WaznoscUbezpieczenia,
                        WaznoscBadania = kartoteka_osobowa.WaznoscBadania,
                        Stanowisko = kartoteka_osobowa.Stanowisko,
                        //IdOddzialu = kartoteka_osobowa.Oddzialy.IdOddzialu,
                        Plec =  kartoteka_osobowa.Plec,
                        DniUrlopu = (int?)kartoteka_osobowa.DniUrlopu,
                        Stawka = kartoteka_osobowa. Stawka

                    }
                );
           
        }

        #endregion

        #region Sortowanie i filtrowanie
        public override void Sort()
        {
            if (SortField == "Imie")
                List = new ObservableCollection<KartotekaOsobowaForView>(List.OrderBy(person => person.Imie));
            if (SortField == "Pesel")
                List = new ObservableCollection<KartotekaOsobowaForView>(List.OrderBy(person => person.Pesel));
            if (SortField == "ZatrudnionyOd")
                List = new ObservableCollection<KartotekaOsobowaForView>(List.OrderBy(person => person.ZatrudnionyOd));
            if (SortField == "Stawka")
                List = new ObservableCollection<KartotekaOsobowaForView>(List.OrderBy(person => person.Stawka));
        }

        public override List<string> GetComboboxSortList()
        {
            return new List<string> { "Imie", "ZatrudnionyOd", "Pesel", "Stawka"};
        }


        public override void Find()
        {
            load();
            if (FindTypeField == "Zawiera")
            {
                if (FindField == "Stanowisko")
                    List = new ObservableCollection<KartotekaOsobowaForView>(List.Where(person => person.Stanowisko != null && person.Stanowisko.Contains(FindTextBox)));
                if (FindField == "Płec")
                    List = new ObservableCollection<KartotekaOsobowaForView>(List.Where(person => person.Plec != null && person.Plec.Contains(FindTextBox)));
            }
            else
            {
                if (FindField == "Stanowisko")
                    List = new ObservableCollection<KartotekaOsobowaForView>(List.Where(person => person.Stanowisko != null && person.Stanowisko.StartsWith(FindTextBox)));
                if (FindField == "Płeć")
                    List = new ObservableCollection<KartotekaOsobowaForView>(List.Where(person => person.Plec != null && person.Plec.StartsWith(FindTextBox)));
            }

        }     
        public override List<string> GetComboboxFindList()
        {
            return new List<string> {"Stanowisko", "Płec", };
        }
        public override List<string> GetComboboxFindTypeList()
        {
            return new List<string> { "Zaczyna się od", "Zawiera" };
        }

        #endregion
    }
}
