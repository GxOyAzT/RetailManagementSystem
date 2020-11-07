using Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DatabaseModule
{
    public class GetAllSupplyWhereShopIdAndNotConfEF : IGetAllSupplyWhereShopIdAndNotConf
    {
        public List<SupplyModel> Get(Guid shopId)
        {
            using (var db = new ShopContext())
            {
                return db.SupplyModels
                    .Where(e => e.IsDelivered == false && e.ShopId == shopId)
                    .ToList();
            }
        }
    }
}
