using System.Linq;
using System.Text.RegularExpressions;

namespace ValidationModule
{
    public class ValidatePriceData : IValidatePriceData
    {
        public bool ValidatePrice(string price)
        {
            if (price.Length < 4)
                return false;

            if (price.Length > 7)
                return false;

            if (!(new Regex("^[0-9][0-9,]{1,6}$")).IsMatch(price))
                return false;

            if (!(new Regex("^[0-9]{1,4}[,][0-9]{2}$")).IsMatch(price))
                return false;

            if (price.Count(e => e == ',' | e == '.') != 1)
                return false;

            return true;
        }

        public bool ValidateTax(string tax)
        {
            if (tax.Length < 1)
                return false;

            if (tax.Length > 3)
                return false;

            if ((new Regex("^[0][0-9]{1,2}$")).IsMatch(tax))
                return false;

            if ((new Regex("^[1][1-9][0-9]$")).IsMatch(tax))
                return false;

            if ((new Regex("^[1][0-9][1-9]$")).IsMatch(tax))
                return false;

            if (!(new Regex("[0-9]{1,3}")).IsMatch(tax))
                return false;

            return true;
        }
    }
}
