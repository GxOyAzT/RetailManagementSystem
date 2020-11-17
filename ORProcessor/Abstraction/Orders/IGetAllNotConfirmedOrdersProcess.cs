using Models;
using System;
using System.Collections.Generic;

namespace ORProcessor
{
    public interface IGetAllNotConfirmedOrdersProcess
    {
        List<OrderModel> Get(Guid shopId);
    }
}