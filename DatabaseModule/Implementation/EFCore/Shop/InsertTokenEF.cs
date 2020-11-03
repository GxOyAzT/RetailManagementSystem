using Models;

namespace DatabaseModule
{
    public class InsertTokenEF : IInsertToken
    {
        public void Insert(ShopWebAccountTokensModel model)
        {
            using (var db = new ShopContext())
            {
                db.ShopWebAccountTokens.Add(model);

                db.SaveChanges();
            }
        }
    }
}
