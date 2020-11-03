using DatabaseModule;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ORProcessor
{
    public class GetShopWhereId : IGetShopWhereId
    {
        private readonly IGetAllShops getAllShops;

        public GetShopWhereId(IGetAllShops getAllShops)
        {
            this.getAllShops = getAllShops;
        }

        public ShopModel Get(Guid shopId)
        {
            return getAllShops.Get().FirstOrDefault(e => e.Id == shopId);
        }
    }
}
