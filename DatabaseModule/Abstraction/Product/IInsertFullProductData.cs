using Models;

namespace DatabaseModule
{
    public interface IInsertFullProductData
    {
        void Insert(ProductBasicsModel productBasicsModel, ProductPriceModel productPriceModel, ProductStorageModel productStorageModel, ProductAvaliabilityModel productAvaliabilityModel);
    }
}