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
    public class NowaFakturaViewModel:WorkspaceViewModel
    {
        #region Constructor
        public NowaFakturaViewModel()
        {
            base.DisplayName = "Faktura";
        }
        #endregion
    }
}
