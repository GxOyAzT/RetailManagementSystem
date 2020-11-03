using DatabaseModule;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ORProcessor
{
    public class LoadDataToManageOrderProd : ILoadDataToManageOrderProd
    {
        private readonly IGetAllProducts getAllProducts;
        private readonly IGetOrderProductWhereOrderId getOrderProductWhereOrderId;
        public string ErrorMessage { get; set; }

        public LoadDataToManageOrderProd(IGetAllProducts getAllProducts, IGetOrderProductWhereOrderId getOrderProductWhereOrderId)
        {
            this.getAllProducts = getAllProducts;
            this.getOrderProductWhereOrderId = getOrderProductWhereOrderId;
        }

        public List<ManageOrderProdVM> Load(string orderId)
        {
            Guid orderIdGuid;

            if (!Guid.TryParse(orderId, out orderIdGuid))
            {
                ErrorMessage = "Incorrect order id.";
                return null;
            }

            List<ManageOrderProdVM> output = new List<ManageOrderProdVM>();

            List<OrderProductModel> orderProducts = getOrderProductWhereOrderId.Get(orderIdGuid);

            foreach (var item in getAllProducts.Get())
            {
                output.Add(new ManageOrderProdVM()
                {
                    OrderId = orderIdGuid,
                    ProductBasicsModel = item,
                    NewOrderedQua = orderProducts.FirstOrDefault(e => e.ProductId == item.Id) == null ? 0 : orderProducts.FirstOrDefault(e => e.ProductId == item.Id).Quantity
                });
            }

            return output;
        }
    }
}
