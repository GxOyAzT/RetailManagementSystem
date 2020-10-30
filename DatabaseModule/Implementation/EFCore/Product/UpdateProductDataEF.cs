using Models;

namespace DatabaseModule
{
    public class UpdateProductDataEF : IUpdateProductData
    {
        public void UpdateBasic(ProductBasicsModel model)
        {
            using (var db = new ShopContext())
            {
                db.ProductBasicsModels.Update(model);
                db.SaveChanges();
            }
        }

        public void UpdatePrice(ProductPriceModel model)
        {
            using (var db = new ShopContext())
            {
                db.ProductPriceModels.Update(model);
                db.SaveChanges();
            }
        }

        public void UpdateStorage(ProductStorageModel model)
        {
            using (var db = new ShopContext())
            {
                db.ProductStorageModels.Update(model);
                db.SaveChanges();
            }
        }

        public void UpdateAvaliability(ProductAvaliabilityModel model)
        {
            using (var db = new ShopContext())
            {
                db.ProductAvaliabilityModels.Update(model);
                db.SaveChanges();
            }
        }
    }
}
