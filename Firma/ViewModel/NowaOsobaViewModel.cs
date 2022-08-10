﻿using Firma.Model.Entieties;
using Firma.ViewModel.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Firma.Helpers;
using System.ComponentModel;
using Firma.Model.Validatory;

namespace Firma.ViewModel
{
     public class NowaOsobaViewModel : AddViewModel<Kartoteka_Osobowa>, IDataErrorInfo
    {
        #region Constructor
        public NowaOsobaViewModel()
            : base("Kartoteka")

        {
            person = new Kartoteka_Osobowa();
        }
        #endregion

        #region Properties

        public string Imie
        {
            get
            {
                return person.Imie;
            }
            set
            {
                if( person.Imie != value)
                {
                    person.Imie = value;
                    base.OnPropertyChanged(() => Imie);
                }
            }
        }

        public string Nazwisko
        {
            get
            {
                return person.Nazwisko;
            }
            set
            {
                if(person.Nazwisko != value)
                {
                    person.Nazwisko = value;
                    base.OnPropertyChanged(() => Nazwisko);
                }
            }
        }

        public decimal? Pesel
        {
            get
            {
                return person.Pesel;
            }
            set
            {
                if(person.Pesel != value)
                {
                    person.Pesel = value;
                    base.OnPropertyChanged(() => Pesel);
                }
            }
        }

        public DateTime? ZatrudnionyOd
        {
            get
            {
                return person.ZatrudnionyOd;
            }
            set
            {
                if(person.ZatrudnionyOd != value)
                {
                    person.ZatrudnionyOd = value;
                    base.OnPropertyChanged(() => ZatrudnionyOd);
                }
            }
        }

        public DateTime? ZatrudnionyDo
        {
            get
            {
                return person.ZatrudnionyDo;
            }
            set
            {
                if (person.ZatrudnionyDo != value)
                {
                    person.ZatrudnionyDo = value;
                    base.OnPropertyChanged(() => ZatrudnionyDo);
                }
            }
        }


        public DateTime? DataRozwiazania
        {
            get
            {
                return person.DataRozwiazania;
            }
            set
            {
                if (person.DataRozwiazania != value)
                {
                    person.DataRozwiazania = value;
                    base.OnPropertyChanged(() => DataRozwiazania);
                }
            }
        }

        public DateTime? WaznoscUbezpieczenia
        {
            get
            {
                return person.WaznoscUbezpieczenia;
            }
            set
            {
                if (person.WaznoscUbezpieczenia != value)
                {
                    person.WaznoscUbezpieczenia = value;
                    base.OnPropertyChanged(() => WaznoscUbezpieczenia);
                }
            }
        }

        public DateTime? WaznoscBadania
        {
            get
            {
                return person.WaznoscBadania;
            }
            set
            {
                if (person.WaznoscBadania != value)
                {
                    person.WaznoscBadania = value;
                    base.OnPropertyChanged(() => WaznoscBadania);
                }
            }
        }

        public string Stanowisko
        {
            get
            {
                return person.Stanowisko;
            }
            set
            {
                if (person.Stanowisko != value)
                {
                    person.Stanowisko = value;
                    base.OnPropertyChanged(() => Stanowisko);
                }
            }
        }

        public int? IdOddzialu
        {
            get
            {
                return person.IdOddzialu;
            }
            set
            {
                if (person.IdOddzialu != value)
                {
                    person.IdOddzialu = value;
                    base.OnPropertyChanged(() => IdOddzialu);
                }
            }
        }

        public string Plec
        {
            get
            {
                return person.Plec;
            }
            set
            {
                if (person.Plec != value)
                {
                    person.Plec = value;
                    base.OnPropertyChanged(() => Plec);
                }
            }
        }

        public int? DniUrlopu
        {
            get
            {
                return person.DniUrlopu;
            }
            set
            {
                if (person.DniUrlopu != value)
                {
                    person.DniUrlopu = value;
                    base.OnPropertyChanged(() => DniUrlopu);
                }
            }
        }

        public decimal? Stawka
        {
            get
            {
                return person.Stawka;
            }
            set
            {
                if (person.Stawka != value)
                {
                    person.Stawka = value;
                    base.OnPropertyChanged(() => Stawka);
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
                if(name == "Imie")
                {
                    komunikat = StringValidator.DuzaLitera(this.Imie);
                }
                if (name == "Nazwisko")
                {
                    komunikat = StringValidator.DuzaLitera(this.Nazwisko);
                }
                if (name == "Stanowisko")
                {
                    komunikat = StringValidator.DuzaLitera(this.Stanowisko);
                }
                if (name == "Plec")
                {
                    komunikat = StringValidator.DuzaLitera(this.Plec);
                }
                return komunikat;
            }
        }

        public override bool IsValid()
        {
            if (this["Imie"] == null && this["Nazwisko"] == null && this["Stanowisko"] == null && this["Plec"] == null)
                return true;
            return false;
        }

        #endregion

        #region Helpers
        public override void Save()
        {
            person.CzyAktywny = true;
            mVVMFirmaEntities.Kartoteka_Osobowa.Add(person);
            mVVMFirmaEntities.SaveChanges();
        }
        #endregion

    }
}
