using Microsoft.Extensions.Caching.Memory;
using Models;
using System.Collections.Generic;

namespace DatabaseModule
{
    public class InsertSupplyProductListEF : IInsertSupplyProductList
    {
        public void Insert(List<SupplyProductModel> orderProductModels)
        {
            foreach(var item in orderProductModels)
            {
                item.ProductBasicsModel = null;
                item.SupplyModel = null;
            }

            using (var db = new ShopContext())
            {
                db.SupplyProductModels.AddRange(orderProductModels);

                db.SaveChanges();
            }
        }
    }
}
