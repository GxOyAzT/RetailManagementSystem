using DatabaseModule;
using Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace GMProcessor
{
    public class UpdateTruckListProcessor : IUpdateTruckListProcessor
    {
        private readonly IUpdateTruckList updateTruckList;

        public UpdateTruckListProcessor(IUpdateTruckList updateTruckList)
        {
            this.updateTruckList = updateTruckList;
        }

        public void Update(List<TruckModel> trucks)
        {
            updateTruckList.Update(trucks);
        }
    }
}
