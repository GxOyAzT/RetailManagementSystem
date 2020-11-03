using Models;

namespace DatabaseModule
{
    public interface IGetTokenModelByToken
    {
        ShopWebAccountTokensModel Get(string token);
    }
}