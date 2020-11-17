using System;

namespace DatabaseModule
{
    public interface IRemoveOrder
    {
        void Remove(Guid orderId, Guid shopId);
    }
}