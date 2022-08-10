using Firma.Helpers;
using Firma.Model.Entieties;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Firma.ViewModel.Abstract
{
    public abstract class WszystkieViewModel<T> : WorkspaceViewModel
    {
        #region Fields
        protected readonly MVVMFirmaEntities mVVMFirmaEntities;
        private BaseCommand _LoadCommand;
        private ObservableCollection<T> _List;
        #endregion

        #region Properties

        public ICommand LoadCommand
        {
            get
            {
                if (_LoadCommand == null)
                {
                    _LoadCommand = new BaseCommand(() => load());
                }
                return _LoadCommand;
            }
        }

        public ObservableCollection<T> List
        {
            get
            {
                if (_List == null)
                    load();
                return _List;
            }
            set
            {
                _List = value;
                OnPropertyChanged(() => List);
            }
        }

        #endregion

        #region Sortowanie i filtrowanie

        private BaseCommand _SortCommand; // pod przycisk Sortuj
        private BaseCommand _FindCommand; // pod przycisk Szukaj

        public ICommand SortCommand
        {
            get
            {
                if (_SortCommand == null)
                {
                    _SortCommand = new BaseCommand(() => Sort());//AddCommand wywołuje metodę add()
                }
                return _SortCommand;
            }
        }
        // W klasie abstrakcyjnej WszystkieViewModel nie wiemy jak sortować, będziemy dopiero wiedzieć w klasie dziedziczącej.
        public abstract void Sort();
        // To jest properties który posłuży do wypełnienia comboboxa po czym sortować.
        public List<string> SortComboboxItems
        {
            get
            {
                return GetComboboxSortList();
            }
        }
        // W klasie abstrakcyjnej WszystkieViewModel nie wiemy po czym sortować, będziemy dopiero wiedzieć w klasie dziedziczącej.
        public abstract List<string> GetComboboxSortList();
        // D otej zmiennej zostanie zapisany wybór po czym mamy sortować 
        public string SortField { get; set; }
        //W klasie abstrakcyjnej WszystkieViewModel nie wiemy jak filtrować, będziemy dopiero wiedzieć w klasie dziedziczącej.
        public abstract void Find();
        public ICommand FindCommand
        {
            get
            {
                if (_FindCommand == null)
                {
                    _FindCommand = new BaseCommand(() => Find());//AddCommand wywołuje metodę add()
                }
                return _FindCommand;
            }
        }
        public abstract List<string> GetComboboxFindList();
        public List<string> FindComboboxItems
        {
            get
            {
                return GetComboboxFindList();
            }
        }


        public abstract List<string> GetComboboxFindTypeList();
        public List<string> FindTypeComboboxItems
        {
            get
            {
                return GetComboboxFindTypeList();
            }
        }

        public string FindField { get; set; }
        public string FindTextBox { get; set; }
        public string FindTypeField { get; set; }


        #endregion

        #region Construktor
        public WszystkieViewModel(string displayName)
        {
            base.DisplayName = displayName;
            this.mVVMFirmaEntities = new MVVMFirmaEntities();
        }
        #endregion

        #region Helpers
        public abstract void load();
        #endregion

    }
}
