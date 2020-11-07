using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Models
{
    public class SupplyDetailsVM
    {
        public SupplyModel SupplyModel { get; set; }
        public List<SupplyProductModel> SupplyProductModels { get; set; }

        public decimal TotalPrice 
        { 
            get => Math.Round(SupplyProductModels.Sum(e => e.Quantity * e.ProductBasicsModel.ProductStorageModel.QuantityInBox * e.ProductBasicsModel.ProductPriceModel.Price), 2); 
        }
    }
}
