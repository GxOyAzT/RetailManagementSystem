using Models;

namespace ValidationModule
{
    public class FullValidationProductBasicData : IFullValidationProductBasicData
    {
        private readonly IValidateBasicProductData _validateBasicProductData;

        public FullValidationProductBasicData(IValidateBasicProductData validateBasicProductData)
        {
            _validateBasicProductData = validateBasicProductData;
        }

        public bool FullValidation(ProductBasicsModel model)
        {
            return _validateBasicProductData.ValidateName(model.Name) &
                _validateBasicProductData.ValidateShortName(model.ShortName) &
                _validateBasicProductData.ValidateBarecode(model.Barecode);
        }
    }
}
