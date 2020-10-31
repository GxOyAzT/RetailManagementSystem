using DatabaseModule;
using Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace ORProcessor
{
    public class LoadOrdersProc : ILoadOrdersProc
    {
        private readonly IGetAllOrders getAllOrders;

        public LoadOrdersProc(IGetAllOrders getAllOrders)
        {
            this.getAllOrders = getAllOrders;
        }

        public List<OrderModel> Load()
        {
            return getAllOrders.Get();
        }
    }
}
