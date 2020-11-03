using Models;
using System;
using System.Collections.Generic;

namespace ORProcessor
{
    public interface IProcessManageOrderProducts
    {
        void Process(List<ManageOrderProdVM> input, Guid orderId);
    }
}