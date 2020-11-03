using DatabaseModule;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ORProcessor
{
    public class GetOrderDetailsVM : IGetOrderedDetailsVM
    {
        private readonly IGetOrderProductWhereOrderId getOrderProductWhereOrderId;
        private readonly IGetAllOrders getAllOrders;

        public string ErrorMessage { get; private set; } = string.Empty;

        public GetOrderDetailsVM(IGetOrderProductWhereOrderId getOrderProductWhereOrderId, IGetAllOrders getAllOrders)
        {
            this.getOrderProductWhereOrderId = getOrderProductWhereOrderId;
            this.getAllOrders = getAllOrders;
        }

        public OrderDetailsViewModel Get(string orderId)
        {
            Guid orderIdGuid;

            if (!Guid.TryParse(orderId, out orderIdGuid))
            {
                ErrorMessage = "Shop Id is in incorrect format.";
                return null;
            }

            return new OrderDetailsViewModel()
            {
                OrderModel = getAllOrders.Get().FirstOrDefault(e => e.Id == orderIdGuid),
                OrderProductModels = getOrderProductWhereOrderId.Get(orderIdGuid)
            };
        }
    }
}
