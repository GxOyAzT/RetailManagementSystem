using Models;
using System;

namespace ORProcessor
{
    public interface IGetShopWhereId
    {
        ShopModel Get(Guid shopId);
    }
}