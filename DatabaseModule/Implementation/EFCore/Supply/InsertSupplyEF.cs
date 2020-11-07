using Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DatabaseModule
{
    public class InsertSupplyEF : IInsertSupply
    {
        public void Insert(SupplyModel supplyModel)
        {
            using (var db = new ShopContext())
            {
                db.SupplyModels.Add(supplyModel);

                db.SaveChanges();
            }
        }
    }
}
