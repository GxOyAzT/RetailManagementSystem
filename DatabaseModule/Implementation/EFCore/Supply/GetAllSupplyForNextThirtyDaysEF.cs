using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DatabaseModule
{
    public class GetAllSupplyForNextThirtyDaysEF : IGetAllSupplyForNextThirtyDays
    {
        public List<SupplyModel> Get()
        {
            using (var db = new ShopContext())
            {
                return db.SupplyModels
                    .Where(e => e.DateOfDelivery >= DateTime.Now.AddDays(-1) && e.DateOfDelivery <= DateTime.Now.AddDays(31))
                    .ToList();
            }
        }
    }
}
