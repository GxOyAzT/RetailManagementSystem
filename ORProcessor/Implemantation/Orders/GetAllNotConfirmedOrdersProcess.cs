using DatabaseModule;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ORProcessor
{
    public class GetAllNotConfirmedOrdersProcess : IGetAllNotConfirmedOrdersProcess
    {
        private readonly IGetAllOrders getAllOrders;

        public GetAllNotConfirmedOrdersProcess(IGetAllOrders getAllOrders)
        {
            this.getAllOrders = getAllOrders;
        }

        public List<OrderModel> Get(Guid shopId)
        {
            return getAllOrders.Get().Where(e => e.ShopId == shopId && e.IsConfirmed == false).ToList();
        }
    }
}
