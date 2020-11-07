using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Models;

namespace DatabaseModule
{
    public class InsertBlankOrderEF : IInsertBlankOrder
    {
        public void Insert(Guid shopId, string orderUqName)
        {
            using (var db = new ShopContext())
            {
                db.OrderModels.Add(new OrderModel()
                {
                    Id = Guid.NewGuid(),
                    CreationDate = DateTime.Now.Date,
                    ShopId = shopId,
                    IsConfirmed = false,
                    IsSupplyConfirmed = false,
                    OrderUqName = orderUqName
                });

                db.SaveChanges();
            }
        }
    }
}
