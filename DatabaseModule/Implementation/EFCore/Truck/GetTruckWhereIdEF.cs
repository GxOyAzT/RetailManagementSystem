using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DatabaseModule
{
    public class GetTruckWhereIdEF : IGetTruckWhereId
    {
        public TruckModel Get(Guid truckId)
        {
            using (var db = new ShopContext())
            {
                return db.TruckModels.FirstOrDefault(e => e.Id == truckId);
            }
        }
    }
}
