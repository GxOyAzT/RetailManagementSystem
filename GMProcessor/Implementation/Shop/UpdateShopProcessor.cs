using DatabaseModule;
using Models;
using System;
using System.Collections.Generic;
using System.Text;
using ValidationModule;

namespace GMProcessor
{
    public class UpdateShopProcessor : IUpdateShopProcessor
    {
        private readonly IUpdateShop updateShop;
        private readonly IValidateCity validateCity;
        private readonly IValidateAddressStreet validateAddressStreet;
        public string ErrorMessage { get; private set; }

        public UpdateShopProcessor(IUpdateShop updateShop, IValidateAddressStreet validateAddressStreet, IValidateCity validateCity)
        {
            this.updateShop = updateShop;
            this.validateCity = validateCity;
            this.validateAddressStreet = validateAddressStreet;
        }

        public bool Update(ShopModel shopModel)
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

            updateShop.Update(shopModel);

            return true;
        }
    }
}
