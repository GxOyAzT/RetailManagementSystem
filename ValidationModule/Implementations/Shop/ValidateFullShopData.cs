namespace ValidationModule
{
    public class ValidateFullShopData : IValidateCity, IValidateAddressStreet, IValidateFullShopData

    {
        public ValidateFullShopData(IValidateCity validateCity, IValidateAddressStreet validateAddressStreet)
        {
            _validateCity = validateCity;
            _validateAddressStreet = validateAddressStreet;
        }

        IValidateCity _validateCity { get; }
        IValidateAddressStreet _validateAddressStreet { get; }

        public bool IsCityNameCorrect(string city)
        {
            return _validateCity.IsCityNameCorrect(city);
        }

        public bool IsStreetCorrect(string street)
        {
            return _validateAddressStreet.IsStreetCorrect(street);
        }

        public bool Validate(string city, string street)
        {
            return IsCityNameCorrect(city) & IsStreetCorrect(street);
        }
    }
}
