using Models;

namespace DatabaseModule
{
    public class UpdateEachShopEF : IUpdateEachShop
    {
        public void Update(EachShopModel model)
        {
            using (var db = new ShopContext())
            {
                db.EachShopModels.Update(model);
                db.SaveChanges();
            }
        }
    }
}
