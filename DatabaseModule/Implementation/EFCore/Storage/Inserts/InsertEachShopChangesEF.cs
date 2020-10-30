using Models;

namespace DatabaseModule
{
    public class InsertEachShopChangesEF : IInsertEachShopChanges
    {
        public void Insert(EachShopChangesModel model)
        {
            using (var db = new ShopContext())
            {
                db.EachShopChangesModels.Add(model);
                db.SaveChanges();
            }
        }
    }
}
