using System.Collections.Generic;
using System.Linq;

namespace Models
{
    public class OrderDetailsViewModel
    {
        public OrderModel OrderModel { get; set; }
        public List<OrderProductModel> OrderProductModels { get; set; }

        public string TotalOrderCost { get => $"{OrderProductModels.Sum(e => e.ProductBasicsModel.ProductPriceModel.Price * e.ProductBasicsModel.ProductStorageModel.QuantityInBox * e.Quantity).ToString("C")}"; }
    }
}
