using Models;

namespace DatabaseModule
{
    public class InsertFullProductDataEFv2 : IInsertFullProductData
    {
        public InsertFullProductDataEFv2(IInsertDistinctProductData insertDistinctProductData, IInsertNewBlankRowToWarehouse insertNewBlankRowToWarehouse)
        {
            _insertDistinctProductData = insertDistinctProductData;
            _insertNewBlankRowToWarehouse = insertNewBlankRowToWarehouse;
        }

        IInsertDistinctProductData _insertDistinctProductData { get; }
        IInsertNewBlankRowToWarehouse _insertNewBlankRowToWarehouse { get; }

        public void Insert(ProductBasicsModel productBasicsModel, ProductPriceModel productPriceModel, ProductStorageModel productStorageModel, ProductAvaliabilityModel productAvaliabilityModel)
        {
            _insertDistinctProductData.InsertProductBasic(productBasicsModel);
            _insertDistinctProductData.InsertProductPrice(productPriceModel);
            _insertDistinctProductData.InsertProductStorage(productStorageModel);
            _insertDistinctProductData.InsertProductAvaliability(productAvaliabilityModel);

            //_insertNewBlankRowToWarehouse.Insert(productBasicsModel);
        }
    }
}
