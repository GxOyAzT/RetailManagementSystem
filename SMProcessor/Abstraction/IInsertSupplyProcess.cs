using Models;
using System.Collections.Generic;

namespace SMProcessor
{
    public interface IInsertSupplyProcess
    {
        void Insert(SupplyModel supplyModel, List<SupplyProductModel> supplyProductModels);
    }
}