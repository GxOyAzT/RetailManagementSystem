using Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SMProcessor
{
    public class ConvertOrderProductListToSupplyProductList : IConvertOrderProductListToSupplyProductList
    {
        public List<SupplyProductModel> Convert(List<OrderProductsVM> input, Guid supplyId)
        {
            var output = new List<SupplyProductModel>();

            foreach (var item in input)
            {
                output.Add(new SupplyProductModel()
                {
                    SupplyId = supplyId,
                    ProductId = item.ProductId,
                    Quantity = item.AcceptedQuantity,
                    ProductBasicsModel = item.ProductBasicsModel
                });
            }

            return output;
        }
    }
}
