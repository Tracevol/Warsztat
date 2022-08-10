using Firma.Model.Entieties;
using Firma.Model.Validatory;
using Firma.ViewModel.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Firma.ViewModel
{
    class NowaNaprawaViewModel : AddViewModel<Naprawa_i_Wymiany>
    {
        #region Constructor
        public NowaNaprawaViewModel()
            : base("Naprawa")

        {
            person = new Naprawa_i_Wymiany();
        }
        #endregion

        #region Properties
        public string Nazwa
        {
            get
            {
                return person.Nazwa;
            }
            set
            {
                if (person.Nazwa != value)
                {
                    person.Nazwa = value;
                    base.OnPropertyChanged(() => Nazwa);
                }
            }
        }
        public DateTime? DataPrzyjecia
        {
            get
            {
                return person.DataPrzyjecia;
            }
            set
            {
                if (person.DataPrzyjecia != value)
                {
                    person.DataPrzyjecia = value;
                    base.OnPropertyChanged(() => DataPrzyjecia);
                }
            }
        }
        public DateTime? DataOddania
        {
            get
            {
                return person.DataOddania;
            }
            set
            {
                if (person.DataOddania != value)
                {
                    person.DataOddania = value;
                    base.OnPropertyChanged(() => DataOddania);
                }
            }
        }

        public decimal? KosztBrutto
        {
            get
            {
                return person.KosztBrutto;
            }
            set
            {
                if (person.KosztBrutto != value)
                {
                    person.KosztBrutto = value;
                    base.OnPropertyChanged(() => KosztBrutto);
                }
            }
        }
        public string StatusRealizacji
        {
            get
            {
                return person.StatusRealizacji;
            }
            set
            {
                if (person.StatusRealizacji != value)
                {
                    person.StatusRealizacji = value;
                    base.OnPropertyChanged(() => StatusRealizacji);
                }
            }
        }
        public string Uwagi
        {
            get
            {
                return person.Uwagi;
            }
            set
            {
                if (person.Uwagi != value)
                {
                    person.Uwagi = value;
                    base.OnPropertyChanged(() => Uwagi);
                }
            }
        }
        public string Opiekun
        {
            get
            {
                return person.Opiekun;
            }
            set
            {
                if (person.Opiekun != value)
                {
                    person.Opiekun = value;
                    base.OnPropertyChanged(() => Opiekun);
                }
            }
        }
        #endregion


        #region Validatory
        public string Error
        {
            get
            {
                return null;
            }
        }

        public string this[string name]
        {
            get
            {
                string komunikat = null;
                if (name == "Nazwa")
                {
                    komunikat = StringValidator.DuzaLitera(this.Nazwa);
                }
                if (name == "StatusRealizacji")
                {
                    komunikat = StringValidator.DuzaLitera(this.StatusRealizacji);
                }
                if (name == "Uwagi")
                {
                    komunikat = StringValidator.DuzaLitera(this.Uwagi);
                }
                if (name == "Opiekun")
                {
                    komunikat = StringValidator.DuzaLitera(this.Opiekun);
                }
                return komunikat;
            }
        }

        public override bool IsValid()
        {
            if (this["Nazwa"] == null && this["StatusRealizacji"] == null && this["Uwagi"] == null && this["Opiekun"] == null)
                return true;
            return false;
        }

        #endregion


        #region Helpers
        public override void Save()
        {
            person.CzyAktywny = true;
            mVVMFirmaEntities.Naprawa_i_Wymiany.Add(person);
            mVVMFirmaEntities.SaveChanges();
        }
        #endregion
    }
}
