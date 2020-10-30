using DatabaseModule;
using Models;
using System;
using System.Collections.Generic;
using System.Text;
using ValidationModule;

namespace GMProcessor
{
    public class InsertProductProcessor : IInsertProductProcessor
    {
        private readonly IValidateBasicProductData validateBasicProductData;
        private readonly IInsertFullProductData insertFullProductData;
        private readonly IValidatePriceData validatePriceData;
        public bool ValidationStatus { get; private set; }
        public string ErrorMessage { get; private set; }

        public InsertProductProcessor(IValidateBasicProductData validateBasicProductData, IValidatePriceData validatePriceData, IInsertFullProductData insertFullProductData)
        {
            this.validateBasicProductData = validateBasicProductData;
            this.insertFullProductData = insertFullProductData;
            this.validatePriceData = validatePriceData;
        }

        public bool Insert(string productName, string productShortName, string barecode, Guid producerId, string price, string tax, ProductStorageModel productStorageModel, ProductAvaliabilityModel productAvaliabilityModel)
        {
            // ProductBasicModel validation
            if (!validateBasicProductData.ValidateName(productName))
            {
                ValidationStatus = false;
                ErrorMessage = "Incorrect product name format.";
                return false;
            }

            if (!validateBasicProductData.ValidateShortName(productShortName))
            {
                ValidationStatus = false;
                ErrorMessage = "Incorrect product short name format.";
                return false;
            }

            if (!validateBasicProductData.ValidateBarecode(barecode))
            {
                ValidationStatus = false;
                ErrorMessage = "Incorrect barecode format.";
                return false;
            }

            // ProductPriceModel valiation
            if (!validatePriceData.ValidatePrice(price))
            {
                ValidationStatus = false;
                ErrorMessage = "Incorrect price format.";
                return false;
            }

            if (!validatePriceData.ValidateTax(tax))
            {
                ValidationStatus = false;
                ErrorMessage = "Incorrect tax format.";
                return false;
            }

            var productBasicsModel = new ProductBasicsModel()
            {
                Id = Guid.NewGuid(),
                Name = productName,
                ShortName = productShortName,
                Barecode = barecode,
                ProducerId = producerId
            };

            var productPriceModel = new ProductPriceModel()
            {
                ProductId = productBasicsModel.Id,
                Price = Convert.ToDecimal(price),
                Tax = Convert.ToInt32(tax)
            };

            productStorageModel.ProductId = productBasicsModel.Id;

            productAvaliabilityModel.ProductId = productBasicsModel.Id;

            insertFullProductData.Insert(productBasicsModel, productPriceModel, productStorageModel, productAvaliabilityModel);

            return true;
        }
    }
}
