using Models;
using System.Collections.Generic;

namespace GMProcessor
{
    public interface IUpdateTruckListProcessor
    {
        void Update(List<TruckModel> trucks);
    }
}