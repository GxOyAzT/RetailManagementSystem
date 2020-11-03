using Models;
using System.Collections.Generic;

namespace ORProcessor
{
    public interface IGetActiveShops
    {
        List<ShopModel> Get();
    }
}