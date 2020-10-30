using Models;

namespace DatabaseModule
{
    public class InsertFullProductDataEF : IInsertFullProductData
    {
        public InsertFullProductDataEF(IInsertDistinctProductData insertDistinctProductData)
        {
            _insertDistinctProductData = insertDistinctProductData;
        }

        IInsertDistinctProductData _insertDistinctProductData { get; }

        public void Insert(ProductBasicsModel productBasicsModel, ProductPriceModel productPriceModel, ProductStorageModel productStorageModel, ProductAvaliabilityModel productAvaliabilityModel)
        {
            _insertDistinctProductData.InsertProductBasic(productBasicsModel);
            _insertDistinctProductData.InsertProductPrice(productPriceModel);
            _insertDistinctProductData.InsertProductStorage(productStorageModel);
            _insertDistinctProductData.InsertProductAvaliability(productAvaliabilityModel);
        }
    }
}
