using Models;
using System;
using System.Collections.Generic;

namespace ORProcessor
{
    public interface IGetAllOrdersProcess
    {
        List<OrderModel> Get(Guid shopId);
    }
}