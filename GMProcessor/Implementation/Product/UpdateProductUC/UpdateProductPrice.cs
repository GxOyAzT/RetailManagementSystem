using DatabaseModule;
using Models;
using System;
using System.Collections.Generic;
using System.Text;
using ValidationModule;

namespace GMProcessor
{
    public class UpdateProductPrice : IUpdateProductPrice
    {
        private readonly IUpdateProductData updateProductData;
        private readonly IValidatePriceData validatePriceData;
        public string ErrorMessage { get; private set; }

        public UpdateProductPrice(IUpdateProductData updateProductData, IValidatePriceData validatePriceData)
        {
            this.updateProductData = updateProductData;
            this.validatePriceData = validatePriceData;
        }

        public bool Update(ProductPriceModel productPriceModel, string newPrice, string newTax)
        {
            if (!validatePriceData.ValidatePrice(newPrice))
            {
                ErrorMessage = "Price is in incorrect format.";
                return false;
            }

            if (!validatePriceData.ValidateTax(newTax))
            {
                ErrorMessage = "Tax is in incorrect format.";
                return false;
            }

            productPriceModel.Price = Convert.ToDecimal(newPrice);
            productPriceModel.Tax = Convert.ToInt32(newTax);

            updateProductData.UpdatePrice(productPriceModel);

            return true;
        }
    }
}
