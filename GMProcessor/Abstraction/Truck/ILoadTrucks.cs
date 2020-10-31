using Models;
using System.Collections.Generic;

namespace GMProcessor
{
    public interface ILoadTrucks
    {
        List<TruckModel> Load();
    }
}