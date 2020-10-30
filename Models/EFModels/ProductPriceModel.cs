using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    public class ProductPriceModel : IProductPriceModel
    {
        public Guid ProductId { get; set; }
        public decimal Price { get; set; }
        public int Tax { get; set; }

        public ProductBasicsModel ProductBasicsModel { get; set; }
    }
}
