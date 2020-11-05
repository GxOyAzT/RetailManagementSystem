using System;
using System.Collections.Generic;

namespace SMProcessor
{
    public interface ILoadAvaliableDeliveryDateList
    {
        List<DateTime> Load(Guid truckId);
    }
}