using System.Text.RegularExpressions;

namespace ValidationModule
{
    public class ValidateCompanyName : IValidateCompanyName
    {
        public bool IsCompanyNameCorrect(string name)
        {
            if (name == string.Empty)
            {
                return false;
            }

            if (name.Length < 2)
            {
                return false;
            }

            if (name.Length > 50)
            {
                return false;
            }

            if(!(new Regex(@"^([A-Za-z0-9ŻŹĆĄŚĘŁÓŃ][A-Z-a-z0-9żźćńółęąśŻŹĆĄŚĘŁÓŃ ]{1,49})$").IsMatch(name)))
            {
                return false;
            }

            if ((new Regex(@"  +").IsMatch(name)))
            {
                return false;
            }

            return true;
        }
    }
}
