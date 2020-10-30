using System;

namespace Models
{
    public class EachShopChangesModel
    {
        public Guid ProductId { get; set; }
        public Guid ShopId { get; set; }
        public int Quantity { get; set; }
        public DateTime DateTimeOfChange { get; set; }

        public virtual ProductBasicsModel ProductBasicsModel { get; set; }
        public virtual ShopModel ShopModel { get; set; }
    }
}
