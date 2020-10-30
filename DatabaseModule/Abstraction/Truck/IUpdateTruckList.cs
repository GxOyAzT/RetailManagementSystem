using Models;
using System.Collections.Generic;

namespace DatabaseModule
{
    public interface IUpdateTruckList
    {
        void Update(List<TruckModel> models);
    }
}