using Models;
using System;
using System.Collections.Generic;

namespace ORProcessor
{
    public interface IGetAllConfirmedOrdersProcess
    {
        List<OrderModel> Get(Guid shopId);
    }
}