using Models;

namespace ORProcessor
{
    public interface IGetInformationByToken
    {
        ShopWebAccountTokensModel Get(string token);
    }
}