using Models;
using System.Collections.Generic;

namespace DatabaseModule
{
    public interface IGetAllSupplyForNextThirtyDays
    {
        List<SupplyModel> Get();
    }
}