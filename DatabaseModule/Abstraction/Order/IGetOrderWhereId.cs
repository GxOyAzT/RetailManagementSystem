using Models;
using System;

namespace DatabaseModule
{
    public interface IGetOrderWhereId
    {
        OrderModel Get(Guid orderId);
    }
}