using Models;
using System;
using System.Collections.Generic;

namespace DatabaseModule
{
    public interface IGetAllSupplyProductsWhereSupId
    {
        List<SupplyProductModel> Get(Guid supplyId);
    }
}