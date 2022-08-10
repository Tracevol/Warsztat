using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Firma.Model.Validatory
{
    class BiznesValidator : Validator
   {
        public static string SprawdzVat(decimal? vat)
        {
            try
            {
                if (vat < 0 || vat > 23)
                {
                    return "VAT powinien być w przedziale od 0 do 23";
                }
            }
            catch (Exception)
            {

                return "Niepoprawny VAT";
            }
            return null;
        }

        public static string SprawdzMarze(decimal? marza)
        {
            try
            {
                if (marza < 2 || marza > 15)
                {
                    return "Marza powinien być w przedziale od 2 do 15";
                }
            }
            catch (Exception)
            {

                return "Niepoprawny VAT";
            }
            return null;
        }

        public static string SprawdzRabat(decimal? rabat)
        {
            try
            {
                if (rabat < 0 || rabat > 50)
                {
                    return "Rabat powinien być w przedziale od 0 do 50";
                }
            }
            catch (Exception)
            {

                return "Niepoprawny VAT";
            }
            return null;
        }
    }
}
