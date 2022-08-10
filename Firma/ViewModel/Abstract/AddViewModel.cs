using Firma.Helpers;
using Firma.Model.Entieties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Input;

namespace Firma.ViewModel.Abstract
{
   public abstract class AddViewModel<T> : WorkspaceViewModel
    {
        #region Fields
        protected MVVMFirmaEntities mVVMFirmaEntities;
        protected T person;
        #endregion

        #region Conctructor
        public AddViewModel(String displayName)
        {
            base.DisplayName = displayName;
            mVVMFirmaEntities = new MVVMFirmaEntities();
        }
        #endregion

        #region Command
        private BaseCommand _SaveCommand;

        public ICommand SaveCommand
        {
            get
            {
                if (_SaveCommand == null)
                    _SaveCommand = new BaseCommand(() => SaveAndClose());
                return _SaveCommand;
            }
        }
        #endregion

        #region Helpers
        public virtual bool IsValid()
        {
            return true;
        }
        public abstract void Save();
        private void SaveAndClose()
        {
            if (IsValid())
            {
                Save();
                base.OnRequestClose();
            }
            else
            {
                ShowMessageBox("Formularz zawiera błędy - popraw wszystkie błędy");
            }
        }

        #endregion
    }
}
