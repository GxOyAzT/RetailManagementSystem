using Models;
using System;
using System.Linq;

namespace DatabaseModule
{
    public class GetOrderWhereIdEF : IGetOrderWhereId
    {
        public OrderModel Get(Guid orderId)
        {
            using (var db = new ShopContext())
            {
                return db.OrderModels.FirstOrDefault(e => e.Id == orderId);
            }
        }
    }
}
