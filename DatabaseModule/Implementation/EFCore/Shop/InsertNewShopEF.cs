using Models;

namespace DatabaseModule
{
    public class InsertNewShopEF : IInsertNewShop
    {
        public void Insert(ShopModel model)
        {
            using (var db = new ShopContext())
            {
                db.ShopModels.Add(model);
                db.SaveChanges();
            }
        }
    }
}
