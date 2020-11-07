using Models;
using System;

namespace DatabaseModule
{
    public interface IGetSupplyWhereId
    {
        SupplyModel Get(Guid supplyId);
    }
}