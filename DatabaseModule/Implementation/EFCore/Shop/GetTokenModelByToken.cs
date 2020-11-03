using Models;
using System.Linq;

namespace DatabaseModule
{
    public class GetTokenModelByToken : IGetTokenModelByToken
    {
        public ShopWebAccountTokensModel Get(string token)
        {
            using (var db = new ShopContext())
            {
                return db.ShopWebAccountTokens.FirstOrDefault(e => e.Token == token);
            }
        }
    }
}
