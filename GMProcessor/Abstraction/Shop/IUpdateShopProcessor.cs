using Models;

namespace GMProcessor
{
    public interface IUpdateShopProcessor
    {
        string ErrorMessage { get; }

        bool Update(ShopModel shopModel);
    }
}