using DatabaseModule;
using Models;
using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using System.Text;

namespace GMProcessor
{
    public class UpdateProductAvaliability : IUpdateProductAvaliability
    {
        private readonly IUpdateProductData updateProductData;

        public UpdateProductAvaliability(IUpdateProductData updateProductData)
        {
            this.updateProductData = updateProductData;
        }

        public void Update(ProductAvaliabilityModel productAvaliabilityModel, bool producerAva, bool isInSale)
        {
            productAvaliabilityModel.AvailabilityAtProducer = producerAva;
            productAvaliabilityModel.IsInSale = isInSale;

            updateProductData.UpdateAvaliability(productAvaliabilityModel);
        }
    }
}
