using DatabaseModule;
using Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace GMProcessor
{
    public class LoadShopModels : ILoadShopModels
    {
        private readonly IGetAllShops getAllShops;

        public LoadShopModels(IGetAllShops getAllShops)
        {
            this.getAllShops = getAllShops;
        }

        public List<ShopModel> Load()
        {
            return getAllShops.Get();
        }
    }
}
