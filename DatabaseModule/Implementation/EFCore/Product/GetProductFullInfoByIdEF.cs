using Models;
using System;

namespace DatabaseModule
{
    public class GetProductFullInfoByIdEF : IGetProductFullInfoById
    {
        public FullProductDataEachModels GetFullProductDataEachModels(Guid productId)
        {
            FullProductDataEachModels output = new FullProductDataEachModels();

            using (var db = new ShopContext())
            {
                output.ProductBasicsModel = db.ProductBasicsModels.Find(productId);
                output.ProductPriceModel = db.ProductPriceModels.Find(productId);
                output.ProductStorageModel = db.ProductStorageModels.Find(productId);
                output.ProductAvaliabilityModel = db.ProductAvaliabilityModels.Find(productId);
                output.ProducerModel = db.Producers.Find(output.ProductBasicsModel.ProducerId);
            }

            return output;
        }
    }
}
