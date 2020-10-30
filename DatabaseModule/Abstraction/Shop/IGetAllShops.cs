using Models;
using System.Collections.Generic;

namespace DatabaseModule
{
    public interface IGetAllShops
    {
        List<ShopModel> Get();
    }
}