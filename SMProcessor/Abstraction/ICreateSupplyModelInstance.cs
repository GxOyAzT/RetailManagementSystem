using Models;
using System;

namespace SMProcessor
{
    public interface ICreateSupplyModelInstance
    {
        SupplyModel Create(Guid truckId, Guid orderId, DateTime dateOfDelivery);
    }
}