using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DatabaseModule
{
    public class RemoveOrderProdAndInsertNewEF : IRemoveOrderProdAndInsertNew
    {
        public void Execute(List<OrderProductModel> input, Guid orderId)
        {
            using (var db = new ShopContext())
            {
                db.OrderProductModels.RemoveRange(db.OrderProductModels.Where(e => e.OrderId == orderId).ToList());

                db.OrderProductModels.AddRange(input);

                db.SaveChanges();
            }
        }
    }
}
