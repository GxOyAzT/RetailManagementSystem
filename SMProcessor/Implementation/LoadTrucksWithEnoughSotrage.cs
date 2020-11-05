using DatabaseModule;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SMProcessor
{
    public class LoadTrucksWithEnoughSotrage : ILoadTrucksWithEnoughSotrage
    {
        private readonly IGetAllTrucks getAllTrucks;

        public LoadTrucksWithEnoughSotrage(IGetAllTrucks getAllTrucks)
        {
            this.getAllTrucks = getAllTrucks;
        }

        public List<TruckModel> Load(int supplyWeight)
        {
            return getAllTrucks.Get().Where(e => e.MaxCapacity >= supplyWeight).ToList();
        }
    }
}
