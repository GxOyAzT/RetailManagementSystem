using System;
using System.Collections.Generic;

namespace Models
{
    public class EachShopModel
    {
        public Guid ProductId { get; set; }
        public Guid ShopId { get; set; }
        public int ActualQuantity { get; set; }

        public virtual ProductBasicsModel ProductBasicsModel { get; set; }
        public virtual ShopModel ShopModel { get; set; }
    }
}
