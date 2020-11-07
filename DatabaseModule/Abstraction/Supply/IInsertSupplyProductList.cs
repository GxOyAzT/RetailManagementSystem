using Models;
using System.Collections.Generic;

namespace DatabaseModule
{
    public interface IInsertSupplyProductList
    {
        void Insert(List<SupplyProductModel> orderProductModels);
    }
}