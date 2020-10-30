using Models;

namespace DatabaseModule
{
    public class InsertNewBlankRowToEachShopEF : IInsertNewBlankRowToEachShop
    {
        public void Insert(EachShopModel model)
        {
            using (var db = new ShopContext())
            {
                db.EachShopModels.Add(model);
                db.SaveChanges();
            }
        }
    }
}
