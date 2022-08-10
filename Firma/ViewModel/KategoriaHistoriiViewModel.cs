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
    class KategoriaHistoriiViewModel : WszystkieViewModel<KategoriaHistoriiForView>
    {
       
        #region Constructor
        public KategoriaHistoriiViewModel()
             : base ("Kategoria")
        {

        }
        #endregion

        #region

        public override void load()
        {
            List = new ObservableCollection<KategoriaHistoriiForView>
                (
                    from kategoria_historii in mVVMFirmaEntities.KategoriaHistorii
                    where kategoria_historii.CzyAktywny == true
                    select new KategoriaHistoriiForView
                    {
                        IdKategorii = kategoria_historii.IdKategorii,
                        NazwaKategorii = kategoria_historii.NazwaKategorii
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
