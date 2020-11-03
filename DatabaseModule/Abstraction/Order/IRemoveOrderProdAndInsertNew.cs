using Models;
using System;
using System.Collections.Generic;

namespace DatabaseModule
{
    public interface IRemoveOrderProdAndInsertNew
    {
        void Execute(List<OrderProductModel> input, Guid orderId);
    }
}