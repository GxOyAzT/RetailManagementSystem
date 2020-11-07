using Microsoft.EntityFrameworkCore;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DatabaseModule
{
    public class GetAllSupplyProductsWhereSupIdEF : IGetAllSupplyProductsWhereSupId
    {
        public List<SupplyProductModel> Get(Guid supplyId)
        {
            using (var db = new ShopContext())
            {
                return db.SupplyProductModels
                    .Include(e => e.ProductBasicsModel).ThenInclude(e => e.ProductStorageModel)
                    .Include(e => e.ProductBasicsModel).ThenInclude(e => e.ProductPriceModel)
                    .AsSplitQuery()
                    .Where(e => e.SupplyId == supplyId)
                    .ToList();
            }
        }
    }
}
