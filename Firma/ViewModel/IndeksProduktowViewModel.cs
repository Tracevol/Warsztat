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
    public class IndeksProduktowViewModel : WszystkieViewModel<IndeksProduktowForView>
    {
        #region Constructor

        public IndeksProduktowViewModel()
           : base("Produkty")
        {

        }
        #endregion




        #region Helpers
        public override void load()
        {
            List = new ObservableCollection<IndeksProduktowForView>
                (
                    from indeks_produktow in mVVMFirmaEntities.Indeks_Produktow
                    where indeks_produktow.CzyAktywny == true
                    select new IndeksProduktowForView
                    {
                        IdProduktu = indeks_produktow.IdProduktu,
                        Nazwa = indeks_produktow.Nazwa,
                        Producent = indeks_produktow.Producent,
                        Sztuk = indeks_produktow.Sztuk, // sprzedanych
                        CennaNetto = indeks_produktow.CennaNetto,
                        CennaBrutto = indeks_produktow.CennaBrutto,
                        StawkaVat = indeks_produktow.StawkaVat,
                        KodKreskowy = (decimal)indeks_produktow.KodKreskowy,
                        NrSeryjny = (int)indeks_produktow.NrSeryjny,
                        Waluta = indeks_produktow.Waluta,
                        //IloscSztuk = indeks_produktow.IloscSztuk // na magazynie

                    }
                );
        }
        #endregion

        #region Sortowanie i filtrowanie
            public override void Sort()
        {
            load();
            if (SortField == "Nazwa")
                List = new ObservableCollection<IndeksProduktowForView>(List.OrderBy(person => person.Nazwa));
            if (SortField == "NrSeryjny")
                List = new ObservableCollection<IndeksProduktowForView>(List.OrderBy(person => person.NrSeryjny));
            if (SortField == "Sztuk")
                List = new ObservableCollection<IndeksProduktowForView>(List.OrderBy(person => person.Sztuk));
            if (SortField == "Cenna netto")
                List = new ObservableCollection<IndeksProduktowForView>(List.OrderBy(person => person.CennaNetto));


        }

        public override List<string> GetComboboxSortList()
        {
            return new List<string> { "Nazwa", "NrSeryjny", "Sztuk", "Cenna netto" };
        }


        public override void Find()
        {
            load();
            if(FindTypeField == "Zawiera")
            {
                if (FindField == "Nazwa")
                    List = new ObservableCollection<IndeksProduktowForView>(List.Where(person => person.Nazwa != null && person.Nazwa.Contains(FindTextBox)));
                if (FindField == "Waluta")
                    List = new ObservableCollection<IndeksProduktowForView>(List.Where(person => person.Waluta != null && person.Waluta.Contains(FindTextBox)));
                if (FindField == "Producent")
                    List = new ObservableCollection<IndeksProduktowForView>(List.Where(person => person.Producent != null && person.Producent.Contains(FindTextBox)));
            }
            else
            {
                if (FindField == "Nazwa")
                    List = new ObservableCollection<IndeksProduktowForView>(List.Where(person => person.Nazwa != null && person.Nazwa.StartsWith(FindTextBox)));
                if (FindField == "Waluta")
                    List = new ObservableCollection<IndeksProduktowForView>(List.Where(person => person.Waluta != null && person.Waluta.StartsWith(FindTextBox)));
                if (FindField == "Producent")
                    List = new ObservableCollection<IndeksProduktowForView>(List.Where(person => person.Producent != null && person.Producent.StartsWith(FindTextBox)));
            }

        }

        public override List<string> GetComboboxFindList()
        {
            return new List<string> { "Nazwa", "Producent", "Waluta" };
        }

        public override List<string> GetComboboxFindTypeList()
        {
            return new List<string> { "Zaczyna się od", "Zawiera" };
        }

        #endregion


        #region Properties
        public IQueryable<KeyAndValue> ProduktyComboBoxItems
        {
            get
            {
                return
                    (
                       from indeks_produktow in mVVMFirmaEntities.Indeks_Produktow
                       select new KeyAndValue
                       {
                           Key = indeks_produktow.IdProduktu,
                           Value = indeks_produktow.Nazwa + "/" + indeks_produktow.Sztuk + "/" + indeks_produktow.Producent
                       }
                    ).ToList().AsQueryable();


            }
        }

        #endregion
    }
}
