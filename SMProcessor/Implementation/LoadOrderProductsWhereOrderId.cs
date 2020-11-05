using DatabaseModule;
using Microsoft.Extensions.Caching.Memory;
using Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SMProcessor
{
    public class LoadOrderProductsWhereOrderId : ILoadOrderProductsWhereOrderId
    {
        private readonly IGetOrderProductWhereOrderId getOrderProductWhereOrderId;

        public LoadOrderProductsWhereOrderId(IGetOrderProductWhereOrderId getOrderProductWhereOrderId)
        {
            this.getOrderProductWhereOrderId = getOrderProductWhereOrderId;
        }

        public List<OrderProductsVM> Load(Guid orderId)
        {
            if (orderId == null)
                return null;

            var output = new List<OrderProductsVM>();

            foreach (var item in getOrderProductWhereOrderId.Get(orderId))
            {
                output.Add(new OrderProductsVM()
                {
                    ProductBasicsModel = item.ProductBasicsModel,
                    OrderModel = item.OrderModel,
                    OrderId = item.OrderId,
                    ProductId = item.ProductId,
                    Quantity = item.Quantity
                });
            }

            return output;
        }
    }
}
