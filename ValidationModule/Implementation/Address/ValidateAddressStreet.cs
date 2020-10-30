using System.Text.RegularExpressions;

namespace ValidationModule
{
    public class ValidateAddressStreet : IValidateAddressStreet
    {
        public bool IsStreetCorrect(string street)
        {
            if (street == string.Empty)
            {
                return false;
            }

            if (street.Length < 2)
            {
                return false;
            }

            if (street.Length > 50)
            {
                return false;
            }

            if (!(new Regex(@"^([A-Z][a-z][A-Z-a-z0-9/ ]{1,48})$").IsMatch(street)))
            {
                return false;
            }

            if ((new Regex(@"  +").IsMatch(street)))
            {
                return false;
            }

            return true;
        }
    }
}
