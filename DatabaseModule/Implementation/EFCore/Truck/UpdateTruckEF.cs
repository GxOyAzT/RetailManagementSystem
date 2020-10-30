using Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DatabaseModule
{
    public class UpdateTruckEF : IUpdateTruck

    {
        public void Update(TruckModel model)
        {
            using (var db = new ShopContext())
            {
                db.TruckModels.Update(model);
                db.SaveChanges();
            }
        }
    }
}
