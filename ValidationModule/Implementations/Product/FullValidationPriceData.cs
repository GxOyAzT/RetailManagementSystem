namespace ValidationModule
{
    public class FullValidationPriceData : IFullValidationPriceData
    {
        private readonly IValidatePriceData _validatePriceData;

        public FullValidationPriceData(IValidatePriceData validatePriceData)
        {
            _validatePriceData = validatePriceData;
        }

        public bool FullValidation(string price, string tax)
        {
            return _validatePriceData.ValidatePrice(price) & _validatePriceData.ValidateTax(tax);
        }
    }
}
