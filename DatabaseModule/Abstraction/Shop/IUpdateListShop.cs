using Models;
using System.Collections.Generic;

namespace DatabaseModule
{
    public interface IUpdateListShop
    {
        void Update(List<ShopModel> models);
    }
}