using Models;

namespace DatabaseModule
{
    public class UpdateShopEF : IUpdateShop
    {
        public void Update(ShopModel model)
        {
            using (var db = new ShopContext())
            {
                db.ShopModels.Update(model);
                db.SaveChanges();
            }
        }
    }
}
