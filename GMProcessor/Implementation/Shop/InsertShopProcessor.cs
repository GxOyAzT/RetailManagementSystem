using DatabaseModule;
using Models;
using ValidationModule;

namespace GMProcessor
{
    public class InsertShopProcessor : IInsertShopProcessor
    {
        private readonly IValidateCity validateCity;
        private readonly IValidateAddressStreet validateAddressStreet;
        private readonly IInsertNewShop insertNewShop;
        public string ErrorMessage { get; private set; }

        public InsertShopProcessor(IValidateCity validateCity, IValidateAddressStreet validateAddressStreet, IInsertNewShop insertNewShop)
        {
            this.validateCity = validateCity;
            this.validateAddressStreet = validateAddressStreet;
            this.insertNewShop = insertNewShop;
        }

        public bool Insert(ShopModel shopModel)
        {
            if (!validateCity.IsCityNameCorrect(shopModel.City))
            {
                ErrorMessage = "City is in incorrect format.";
                return false;
            }

            if (!validateAddressStreet.IsStreetCorrect(shopModel.Street))
            {
                ErrorMessage = "Street is in incorrect format.";
                return false;
            }

            insertNewShop.Insert(shopModel);

            return true;
        }
    }
}
