using DatabaseModule;
using Models;
using System;
using System.Collections.Generic;
using System.Text;
using ValidationModule;

namespace GMProcessor
{
    public class UpdateProductBasic : IUpdateProductBasic
    {
        private readonly IValidateBasicProductData validateBasicProductData;
        private readonly IUpdateProductData updateProductData;

        public string ErrorMessage { get; private set; }

        public UpdateProductBasic(IValidateBasicProductData validateBasicProductData, IUpdateProductData updateProductData)
        {
            this.validateBasicProductData = validateBasicProductData;
            this.updateProductData = updateProductData;
        }

        public bool Update(ProductBasicsModel productBasicsModel)
        {
            if (!validateBasicProductData.ValidateShortName(productBasicsModel.ShortName) || !validateBasicProductData.ValidateName(productBasicsModel.Name))
            {
                ErrorMessage = "Data is in incorrect format.";
                return false;
            }

            updateProductData.UpdateBasic(productBasicsModel);

            return true;
        }
    }
}
