using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Firma.Model.Validatory
{
    class StringValidator : Validator
    {
        public static string DuzaLitera(string wartosc)
        {
            try
            {
                if (!char.IsUpper(wartosc, 0))
                {
                    return "Wyraz powinien zaczynać się od dużej litery";
                }
            }
            catch (Exception)
            {
                return "Błędny tekst";
            }
            return null;
        }
    }
}
