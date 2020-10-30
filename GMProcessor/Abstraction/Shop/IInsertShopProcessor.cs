using Models;

namespace GMProcessor
{
    public interface IInsertShopProcessor
    {
        string ErrorMessage { get; }

        bool Insert(ShopModel shopModel);
    }
}