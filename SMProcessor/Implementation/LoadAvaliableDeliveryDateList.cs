using DatabaseModule;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SMProcessor
{
    public class LoadAvaliableDeliveryDateList : ILoadAvaliableDeliveryDateList
    {
        private readonly IGetAllSupplyForNextThirtyDays getAllSupplyForNextThirtyDays;

        public LoadAvaliableDeliveryDateList(IGetAllSupplyForNextThirtyDays getAllSupplyForNextThirtyDays)
        {
            this.getAllSupplyForNextThirtyDays = getAllSupplyForNextThirtyDays;
        }

        public List<DateTime> Load(Guid truckId)
        {
            List<DateTime> output = new List<DateTime>();

            var supplyList = getAllSupplyForNextThirtyDays.Get().Where(e => e.TruckId == truckId);

            for (DateTime i = DateTime.Now; i <= DateTime.Now.AddDays(30); i = i.AddDays(1))
                if (supplyList.FirstOrDefault(e => e.DateOfDelivery == i) == null)
                    output.Add(i);

            return output;
        }
    }
}
