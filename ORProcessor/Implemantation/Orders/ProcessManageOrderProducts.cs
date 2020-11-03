using DatabaseModule;
using Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ORProcessor
{
    public class ProcessManageOrderProducts : IProcessManageOrderProducts
    {
        private readonly IRemoveOrderProdAndInsertNew removeOrderProdAndInsertNew;

        public ProcessManageOrderProducts(IRemoveOrderProdAndInsertNew removeOrderProdAndInsertNew)
        {
            this.removeOrderProdAndInsertNew = removeOrderProdAndInsertNew;
        }

        public void Process(List<ManageOrderProdVM> input, Guid orderId)
        {
            List<OrderProductModel> orderProducts = new List<OrderProductModel>();

            foreach (var item in input)
                if (item.NewOrderedQua != 0)
                    orderProducts.Add(new OrderProductModel()
                    {
                        OrderId = item.OrderId,
                        ProductId = item.ProductBasicsModel.Id,
                        Quantity = item.NewOrderedQua
                    });

            removeOrderProdAndInsertNew.Execute(orderProducts, orderId);
        }
    }
}
