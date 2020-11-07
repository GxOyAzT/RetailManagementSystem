using Models;
using System;
using System.Collections.Generic;

namespace SMProcessor
{
    public interface IConvertOrderProductListToSupplyProductList
    {
        List<SupplyProductModel> Convert(List<OrderProductsVM> input, Guid supplyId);
    }
}