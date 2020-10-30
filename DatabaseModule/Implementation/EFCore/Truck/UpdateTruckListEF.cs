using Models;
using System.Collections.Generic;

namespace DatabaseModule
{
    public class UpdateTruckListEF : IUpdateTruckList
    {
        public UpdateTruckListEF(IUpdateTruck updateTruckEF)
        {
            _updateTruckEF = updateTruckEF;
        }

        IUpdateTruck _updateTruckEF { get; }

        public void Update(List<TruckModel> models)
        {
            foreach (var model in models)
                _updateTruckEF.Update(model);
        }
    }
}
