using Models;
using System.Collections.Generic;
using System.Linq;

namespace DatabaseModule
{
    public class GetAllOrdersEF : IGetAllOrders
    {
        public List<OrderModel> Get()
        {
            using (var db = new ShopContext())
            {
                return db.OrderModels.ToList();
            }
        }
    }
}
