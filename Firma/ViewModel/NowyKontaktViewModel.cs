using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Firma.ViewModel
{
    public class NowyKontaktViewModel :WorkspaceViewModel
    {
        #region Constructor
        public NowyKontaktViewModel()
        {
            base.DisplayName = "Kontakt"; //Tu decydujemy jak nazywa się zakładka, DisplayName jest odziedziczone z WorkspaceViewModel przez BaseViewModel
        }
        #endregion
    }
}
