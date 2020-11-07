using DatabaseModule;
using Models;
using System.Collections.Generic;

namespace SMProcessor
{
    public class InsertSupplyProcess : IInsertSupplyProcess
    {
        private readonly IInsertSupply insertSupply;
        private readonly IInsertSupplyProductList insertSupplyProductList;
        private readonly IUpdateOrderSupplyAsConfirmed updateOrderSupplyAsConfirmed;

        public InsertSupplyProcess(IInsertSupply insertSupply, IInsertSupplyProductList insertSupplyProductList, IUpdateOrderSupplyAsConfirmed updateOrderSupplyAsConfirmed)
        {
            this.insertSupply = insertSupply;
            this.insertSupplyProductList = insertSupplyProductList;
            this.updateOrderSupplyAsConfirmed = updateOrderSupplyAsConfirmed;
        }

        public void Insert(SupplyModel supplyModel, List<SupplyProductModel> supplyProductModels)
        {
            insertSupply.Insert(supplyModel);

            insertSupplyProductList.Insert(supplyProductModels);

            updateOrderSupplyAsConfirmed.Update(supplyModel.OrderId);
        }
    }
}
