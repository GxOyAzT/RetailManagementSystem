using Models;
using System.Collections.Generic;

namespace DatabaseModule
{
    public interface IGetAllOrders
    {
        List<OrderModel> Get();
    }
}