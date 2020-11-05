using Models;
using System.Collections.Generic;

namespace SMProcessor
{
    public interface ILoadTrucksWithEnoughSotrage
    {
        List<TruckModel> Load(int supplyWeight);
    }
}