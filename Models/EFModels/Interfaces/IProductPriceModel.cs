using System;

namespace Models
{
    public interface IProductPriceModel
    {
        decimal Price { get; set; }
        int Tax { get; set; }
    }
}