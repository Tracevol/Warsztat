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
    class DodajFaktureViewModel : AddViewModel<Faktura>
    {
        #region Constructor
        public DodajFaktureViewModel()
            : base("Faktura")

        {
            person = new Faktura();
        }
        #endregion

        #region Properties
        public string NrFaktury
        {
            get
            {
                return person.NrFaktury;
            }
            set
            {
                if (person.NrFaktury != value)
                {
                    person.NrFaktury = value;
                    base.OnPropertyChanged(() => NrFaktury);
                }
            }
        }

        public DateTime? DataWystawienia
        {
            get
            {
                return person.DataWystawienia;
            }
            set
            {
                if (person.DataWystawienia != value)
                {
                    person.DataWystawienia = value;
                    base.OnPropertyChanged(() => DataWystawienia);
                }
            }
        }

        public DateTime? TerminPlatnosci
        {
            get
            {
                return person.TerminPlatnosci;
            }
            set
            {
                if (person.TerminPlatnosci != value)
                {
                    person.TerminPlatnosci = value;
                    base.OnPropertyChanged(() => TerminPlatnosci);
                }
            }
        }

        public string NazwaProduktu
        {
            get
            {
                return person.NazwaProduktu;
            }
            set
            {
                if (person.NazwaProduktu != value)
                {
                    person.NazwaProduktu = value;
                    base.OnPropertyChanged(() => NazwaProduktu);
                }
            }
        }

        public int? Ilosc
        {
            get
            {
                return person.Ilosc;
            }
            set
            {
                if (person.Ilosc != value)
                {
                    person.Ilosc = value;
                    base.OnPropertyChanged(() => Ilosc);
                }
            }
        }

        public int? Rabat
        {
            get
            {
                return person.Rabat;
            }
            set
            {
                if (person.Rabat != value)
                {
                    person.Rabat = value;
                    base.OnPropertyChanged(() => Rabat);
                }
            }
        }

        public int? Marza
        {
            get
            {
                return person.Marza;
            }
            set
            {
                if (person.Marza != value)
                {
                    person.Marza = value;
                    base.OnPropertyChanged(() => Marza);
                }
            }
        }

        public decimal? Cena
        {
            get
            {
                return person.Cena;
            }
            set
            {
                if (person.Cena != value)
                {
                    person.Cena = value;
                    base.OnPropertyChanged(() => Cena);
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
                if (name == "NrFaktury")
                {
                    komunikat = StringValidator.DuzaLitera(this.NrFaktury);
                }
                if (name == "NazwaProduktu")
                {
                    komunikat = StringValidator.DuzaLitera(this.NazwaProduktu);
                }
                if (name == "Marza")
                {
                    komunikat = BiznesValidator.SprawdzMarze(this.Marza);
                }
                if (name == "Rabat")
                {
                    komunikat = BiznesValidator.SprawdzRabat(this.Rabat);
                }
                return komunikat;
            }
        }



        public override bool IsValid()
        {
            if (this["NrFaktury"] == null && this["NazwaProduktu"] == null && this["Marza"] == null && this["Rabat"] == null)
                return true;
            return false;
        }

        #endregion



        #region Helpers
        public override void Save()
        {
            person.CzyAktywny = true;
            mVVMFirmaEntities.Faktura.Add(person);
            mVVMFirmaEntities.SaveChanges();
        }
        #endregion
    }
}
