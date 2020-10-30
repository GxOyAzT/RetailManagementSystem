using System.Text.RegularExpressions;

namespace ValidationModule
{
    public class ValidateCountry : IValidateCountry
    {
        public bool IsCountryCorrect(string country)
        {
            if (country == string.Empty)
            {
                return false;
            }

            if (country.Length < 3)
            {
                return false;
            }

            if (country.Length > 30)
            {
                return false;
            }

            if (!(new Regex(@"^[A-ZŻŹĆĄŚĘŁÓŃ][A-Za-zżźćńółęąśŻŹĆĄŚĘŁÓŃ ]{3,29}$")).IsMatch(country))
            {
                return false;
            }

            if ((new Regex(@"  +")).IsMatch(country))
            {
                return false;
            }

            return true;
        }
    }
}
