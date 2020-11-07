using Models;
using System;
using System.Collections.Generic;

namespace DatabaseModule
{
    public interface IGetAllSupplyWhereShopIdAndNotConf
    {
        List<SupplyModel> Get(Guid shopId);
    }
}