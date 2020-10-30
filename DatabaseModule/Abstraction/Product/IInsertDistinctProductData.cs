using Models;

namespace DatabaseModule
{
    public interface IInsertDistinctProductData
    {
        void InsertProductAvaliability(ProductAvaliabilityModel model);
        void InsertProductBasic(ProductBasicsModel model);
        void InsertProductPrice(ProductPriceModel model);
        void InsertProductStorage(ProductStorageModel model);
    }
}