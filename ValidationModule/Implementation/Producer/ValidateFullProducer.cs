using Models;

namespace ValidationModule
{
    public class ValidateFullProducer : IFullProducerValidation
    {
        private readonly IValidateCompanyName _validateCompanyName;
        private readonly IValidateCountry _validateCountry;
        private readonly IValidateCity _validateCity;
        private readonly IValidateAddressStreet _validateAddressStreet;

        public ValidateFullProducer(IValidateCompanyName validateCompanyName, IValidateCountry validateCountry, IValidateCity validateCity, IValidateAddressStreet validateAddressStreet)
        {
            _validateCompanyName = validateCompanyName;
            _validateCountry = validateCountry;
            _validateCity = validateCity;
            _validateAddressStreet = validateAddressStreet;
        }

        public bool AreAllPropsCorrect(ProducerModel model)
        {
            if (_validateCity.IsCityNameCorrect(model.City) & _validateCountry.IsCountryCorrect(model.Country) & _validateCompanyName.IsCompanyNameCorrect(model.CompanyName) & _validateAddressStreet.IsStreetCorrect(model.Street))
            {
                return true;
            }

            return false;
        }
    }
}
