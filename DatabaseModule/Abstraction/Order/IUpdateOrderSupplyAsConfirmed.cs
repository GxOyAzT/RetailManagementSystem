using System;

namespace DatabaseModule
{
    public interface IUpdateOrderSupplyAsConfirmed
    {
        bool Update(Guid orderId);
    }
}