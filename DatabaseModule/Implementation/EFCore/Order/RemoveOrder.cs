using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DatabaseModule
{
    public class RemoveOrder : IRemoveOrder
    {
        public void Remove(Guid orderId, Guid shopId)
        {
            using (var db = new ShopContext())
            {
                var orderModel = db.OrderModels.FirstOrDefault(e => e.Id == orderId && e.ShopId == shopId);

                if (orderModel == null)
                    return;

                var productList = db.OrderProductModels.Where(e => e.OrderId == orderId);

                db.OrderProductModels.RemoveRange(productList);
                db.OrderModels.Remove(orderModel);

                db.SaveChanges();
            }
        }
    }
}
