using Models;
using System;

namespace DatabaseModule
{
    public interface IGetTruckWhereId
    {
        TruckModel Get(Guid truckId);
    }
}