using Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SMProcessor
{
    public class CreateSupplyModelInstance : ICreateSupplyModelInstance
    {
        private readonly IReturnUqSupplyName returnUqSupplyName;

        public CreateSupplyModelInstance(IReturnUqSupplyName returnUqSupplyName)
        {
            this.returnUqSupplyName = returnUqSupplyName;
        }

        public SupplyModel Create(Guid truckId, Guid orderId, Guid shopId, DateTime dateOfDelivery)
        {
            return new SupplyModel()
            {
                Id = Guid.NewGuid(),
                TruckId = truckId,
                OrderId = orderId,
                ShopId = shopId,
                DateOfConfirmation = DateTime.Now,
                DateOfDelivery = dateOfDelivery,
                SupplyUqName = returnUqSupplyName.Return(),
                IsDelivered = false
            };
        }
    }
}
