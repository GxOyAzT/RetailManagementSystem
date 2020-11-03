using Models;
using System;
using System.Collections.Generic;

namespace DatabaseModule
{
    public interface IGetOrderProductWhereOrderId
    {
        List<OrderProductModel> Get(Guid OrderId);
    }
}