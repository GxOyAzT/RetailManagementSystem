using DatabaseModule;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ORProcessor
{
    public class GetAllConfirmedOrdersProcess : IGetAllConfirmedOrdersProcess
    {
        private readonly IGetAllOrders getAllOrders;

        public GetAllConfirmedOrdersProcess(IGetAllOrders getAllOrders)
        {
            this.getAllOrders = getAllOrders;
        }

        public List<OrderModel> Get(Guid shopId)
        {
            return getAllOrders.Get().Where(e => e.ShopId == shopId && e.IsConfirmed == true).ToList();
        }
    }
}
