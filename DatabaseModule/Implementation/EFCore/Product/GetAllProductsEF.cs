using Microsoft.EntityFrameworkCore;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DatabaseModule
{
    public class GetAllProductsEF : IGetAllProducts
    {
        public List<ProductBasicsModel> Get()
        {
            using (var db = new ShopContext())
            {
                return db.ProductBasicsModels
                    .Include(e => e.ProductPriceModel)
                    .Include(e => e.ProductStorageModel)
                    .Include(e => e.ProductAvaliabilityModel)
                    .Include(e => e.ProducerModel)
                    .ToList();
            }
        }
    }
}
