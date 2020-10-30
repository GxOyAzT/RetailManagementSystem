using System.Text.RegularExpressions;

namespace ValidationModule
{
    public class ValidateBasicProductData : IValidateBasicProductData
    {
        public bool ValidateName(string name)
        {
            if (name.Length < 2)
            {
                return false;
            }

            if (name.Length > 50)
            {
                return false;
            }

            if (!(new Regex(@"^[A-Za-z0-9żźćńółęąśŻŹĆĄŚĘŁÓŃ][A-Za-z0-9żźćńółęąśŻŹĆĄŚĘŁÓŃ!@#$%^&*()_=+,.? ]{1,49}$")).IsMatch(name))
            {
                return false;
            }

            if ((new Regex(@"  +")).IsMatch(name))
            {
                return false;
            }

            return true;
        }

        public bool ValidateShortName(string shortName)
        {
            if (shortName.Length < 2)
            {
                return false;
            }

            if (shortName.Length > 15)
            {
                return false;
            }

            if (!(new Regex(@"^[A-Za-z0-9żźćńółęąśŻŹĆĄŚĘŁÓŃ][A-Za-z0-9żźćńółęąśŻŹĆĄŚĘŁÓŃ!@#$%^&.,*()_+=* ]{1,14}$")).IsMatch(shortName))
            {
                return false;
            }

            if ((new Regex("  +")).IsMatch(shortName))
            {
                return false;
            }

            return true;
        }

        public bool ValidateBarecode(string barecode)
        {
            if (barecode.Length != 11)
            {
                return false;
            }

            if (!(new Regex("^[0-9]{11}$")).IsMatch(barecode))
            {
                return false;
            }

            return true;
        }
    }
}
