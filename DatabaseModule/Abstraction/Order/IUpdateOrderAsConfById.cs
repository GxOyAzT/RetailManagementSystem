using System;

namespace DatabaseModule
{
    public interface IUpdateOrderAsConfById
    {
        bool Update(Guid orderId);
    }
}