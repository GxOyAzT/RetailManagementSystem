using Models;
using System.Collections.Generic;

namespace DatabaseModule
{
    public interface IGetAllTrucks
    {
        List<TruckModel> Get();
    }
}