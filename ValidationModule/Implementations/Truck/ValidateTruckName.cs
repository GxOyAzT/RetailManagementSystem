using System.Text.RegularExpressions;

namespace ValidationModule
{
    public class ValidateTruckName : IValidateTruckName
    {
        public bool Validate(string name)
        {
            if (name.Length != 5)
                return false;

            if (!(new Regex("^[A-Z][0-9]{4}$").IsMatch(name)))
                return false;

            return true;
        }
    }
}
