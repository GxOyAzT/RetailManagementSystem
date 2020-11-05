using Models;
using System;
using System.Collections.Generic;

namespace SMProcessor
{
    public interface ILoadOrderProductsWhereOrderId
    {
        List<OrderProductsVM> Load(Guid orderId);
    }
}