using Models;

namespace DatabaseModule
{
    public class InsertDistinctProductDataEF : IInsertDistinctProductData
    {
        public void InsertProductBasic(ProductBasicsModel model)
        {
            using (var db = new ShopContext())
            {
                db.ProductBasicsModels.Add(model);
                db.SaveChanges();
            }
        }

        public void InsertProductPrice(ProductPriceModel model)
        {
            using (var db = new ShopContext())
            {
                db.ProductPriceModels.Add(model);
                db.SaveChanges();
            }
        }

        public void InsertProductStorage(ProductStorageModel model)
        {
            using (var db = new ShopContext())
            {
                db.ProductStorageModels.Add(model);
                db.SaveChanges();
            }
        }

        public void InsertProductAvaliability(ProductAvaliabilityModel model)
        {
            using (var db = new ShopContext())
            {
                db.ProductAvaliabilityModels.Add(model);
                db.SaveChanges();
            }
        }
    }
}
