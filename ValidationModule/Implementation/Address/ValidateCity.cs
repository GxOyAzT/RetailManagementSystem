using System.Text.RegularExpressions;

namespace ValidationModule
{
    public class ValidateCity : IValidateCity
    {
        public bool IsCityNameCorrect(string city)
        {
            if (city == string.Empty)
            {
                return false;
            }

            if (city.Length < 3)
            {
                return false;
            }

            if (city.Length > 30)
            {
                return false;
            }

            if (!(new Regex(@"^[A-ZŻŹĆĄŚĘŁÓŃ][A-ZżźćńółęąśŻŹĆĄŚĘŁÓŃa-z ]{3,29}$")).IsMatch(city))
            {
                return false;
            }

            if ((new Regex(@"  +")).IsMatch(city))
            {
                return false;
            }

            return true;
        }
    }
}
