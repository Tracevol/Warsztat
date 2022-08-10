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
    class AddProduktViewModel : AddViewModel<Indeks_Produktow>
    {
        #region Constructor
        public AddProduktViewModel()
            : base("Produkty")

        {
            person = new Indeks_Produktow();
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

        public string Producent
        {
            get
            {
                return person.Producent;
            }
            set
            {
                if (person.Producent != value)
                {
                    person.Producent = value;
                    base.OnPropertyChanged(() => Producent);
                }
            }
        }

        public decimal? Sztuk
        {
            get
            {
                return person.Sztuk;
            }
            set
            {
                if (person.Sztuk != value)
                {
                    person.Sztuk = value;
                    base.OnPropertyChanged(() => Sztuk);
                }
            }
        }

        public decimal? CennaNetto
        {
            get
            {
                return person.CennaNetto;
            }
            set
            {
                if (person.CennaNetto != value)
                {
                    person.CennaNetto = value;
                    base.OnPropertyChanged(() => CennaNetto);
                }
            }
        }

        public decimal? CennaBrutto
        {
            get
            {
                return person.CennaBrutto;
            }
            set
            {
                if (person.CennaBrutto != value)
                {
                    person.CennaBrutto = value;
                    base.OnPropertyChanged(() => CennaBrutto);
                }
            }
        }
        public decimal? StawkaVat
        {
            get
            {
                return person.StawkaVat;
            }
            set
            {
                if (person.StawkaVat != value)
                {
                    person.StawkaVat = value;
                    base.OnPropertyChanged(() => StawkaVat);
                }
            }
        }

        public decimal? KodKreskowy
        {
            get
            {
                return person.KodKreskowy;
            }
            set
            {
                if (person.KodKreskowy != value)
                {
                    person.KodKreskowy = value;
                    base.OnPropertyChanged(() => KodKreskowy);
                }
            }
        }

        public int? NrSeryjny
        {
            get
            {
                return person.NrSeryjny;
            }
            set
            {
                if (person.NrSeryjny != value)
                {
                    person.NrSeryjny = value;
                    base.OnPropertyChanged(() => NrSeryjny);
                }
            }
        }

        public string Waluta
        {
            get
            {
                return person.Waluta;
            }
            set
            {
                if (person.Waluta != value)
                {
                    person.Waluta = value;
                    base.OnPropertyChanged(() => Waluta);
                }
            }
        }

        //public decimal? IloscSztuk
        //{
        //    get
        //    {
        //        return person.IloscSztuk;
        //    }
        //    set
        //    {
        //        if (person.IloscSztuk != value)
        //        {
        //            person.IloscSztuk = value;
        //            base.OnPropertyChanged(() => IloscSztuk);
        //        }
        //    }
        //}

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
                if (name == "Producent")
                {
                    komunikat = StringValidator.DuzaLitera(this.Producent);
                }
                if (name == "Waluta")
                {
                    komunikat = StringValidator.DuzaLitera(this.Waluta);
                }
                if (name == "StawkaVat")
                {
                    komunikat = BiznesValidator.SprawdzVat(this.StawkaVat);
                }
                return komunikat;
            }
        }

        public override bool IsValid()
        {
            if (this["Nazwa"] == null && this["Producent"] == null && this["Waluta"] == null && this["StawkaVat"] == null)
                return true;
            return false;
        }

        #endregion


        #region Helpers
        public override void Save()
        {
            person.CzyAktywny = true;
            mVVMFirmaEntities.Indeks_Produktow.Add(person);
            mVVMFirmaEntities.SaveChanges();
        }
        #endregion

    }
}
