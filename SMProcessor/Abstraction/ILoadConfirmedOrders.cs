﻿using Models;
using System.Collections.Generic;

namespace SMProcessor
{
    public interface ILoadConfirmedOrders
    {
        List<OrderModel> Load();
    }
}