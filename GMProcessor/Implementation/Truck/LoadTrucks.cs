using DatabaseModule;
using Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace GMProcessor
{
    public class LoadTrucks : ILoadTrucks
    {
        private readonly IGetAllTrucks getAllTrucks;

        public LoadTrucks(IGetAllTrucks getAllTrucks)
        {
            this.getAllTrucks = getAllTrucks;
        }

        public List<TruckModel> Load()
        {
            return getAllTrucks.Get();
        }
    }
}
