using Microsoft.EntityFrameworkCore;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DatabaseModule
{
    public class GetOrderProductWhereOrderIdEF : IGetOrderProductWhereOrderId
    {
        public List<OrderProductModel> Get(Guid OrderId)
        {
            using (var db = new ShopContext())
            { 
                return db.OrderProductModels
                    .Include(e => e.ProductBasicsModel).ThenInclude(d => d.ProducerModel)
                    .Include(e => e.ProductBasicsModel.ProductAvaliabilityModel)
                    .Include(e => e.ProductBasicsModel.ProductPriceModel)
                    .Include(e => e.ProductBasicsModel.ProductStorageModel)
                    .Include(e => e.ProductBasicsModel.WarehouseModel)
                    .Where(e => e.OrderId == OrderId).ToList();
            }
        }
    }
}
