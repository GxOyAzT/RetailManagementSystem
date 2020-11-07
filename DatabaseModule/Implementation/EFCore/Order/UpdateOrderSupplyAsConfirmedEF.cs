using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DatabaseModule
{
    public class UpdateOrderSupplyAsConfirmedEF : IUpdateOrderSupplyAsConfirmed
    {
        public bool Update(Guid orderId)
        {
            using (var db = new ShopContext())
            {
                var order = db.OrderModels.Include(e => e.OrderProductModels).FirstOrDefault(e => e.Id == orderId);

                if (order == null)
                    return false;

                if (!order.OrderProductModels.Any())
                    return false;

                order.IsSupplyConfirmed = true;

                db.SaveChanges();

                return true;
            }
        }
    }
}
