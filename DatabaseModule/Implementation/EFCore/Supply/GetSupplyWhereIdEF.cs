using Microsoft.EntityFrameworkCore;
using Models;
using System;
using System.Linq;

namespace DatabaseModule
{
    public class GetSupplyWhereIdEF : IGetSupplyWhereId
    {
        public SupplyModel Get(Guid supplyId)
        {
            using (var db = new ShopContext())
            {
                return db.SupplyModels
                    .Include(e => e.OrderModel)
                    .FirstOrDefault(e => e.Id == supplyId);
            }
        }
    }
}
