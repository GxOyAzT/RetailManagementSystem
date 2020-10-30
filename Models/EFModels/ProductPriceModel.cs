using System;

namespace Models
{
    public class ProductPriceModel
    {
        public Guid ProductId { get; set; }
        public decimal Price { get; set; }
        public int Tax { get; set; }

        public ProductBasicsModel ProductBasicsModel { get; set; }
    }
}
