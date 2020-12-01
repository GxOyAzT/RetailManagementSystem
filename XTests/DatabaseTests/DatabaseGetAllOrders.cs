using DatabaseModule;
using Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace XTests
{
    public class DatabaseGetAllOrders : IGetAllOrders
    {
        DatabaseModelsTest _databaseModelsTest;

        public DatabaseGetAllOrders()
        {
            _databaseModelsTest = new DatabaseModelsTest();
        }

        public List<OrderModel> Get()
        {
            return _databaseModelsTest.OrderModels;
        }
    }
}
