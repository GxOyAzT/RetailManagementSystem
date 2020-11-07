using Models;
using System;

namespace SMProcessor
{
    public interface ICreateSupplyModelInstance
    {
        SupplyModel Create(Guid truckId, Guid orderId, Guid shopId, DateTime dateOfDelivery);
    }
}