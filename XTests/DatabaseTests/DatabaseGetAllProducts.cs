using DatabaseModule;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace XTests
{
    class DatabaseGetAllProducts : IGetAllProducts
    {
        DatabaseModelsTest _databaseModelsTest;

        public DatabaseGetAllProducts()
        {
            _databaseModelsTest = new DatabaseModelsTest();
        }

        public List<ProductBasicsModel> Get()
        {
            List<ProductBasicsModel> output = new List<ProductBasicsModel>();

            foreach(var item in _databaseModelsTest.ProductBasicsModels)
            {
                item.ProductPriceModel = _databaseModelsTest.ProductPriceModels.FirstOrDefault(e => e.ProductId == item.Id);
                item.ProductStorageModel = _databaseModelsTest.ProductStorageModels.FirstOrDefault(e => e.ProductId == item.Id);
                item.ProductAvaliabilityModel = _databaseModelsTest.ProductAvaliabilityModels.FirstOrDefault(e => e.ProductId == item.Id);

                output.Add(item);
            }

            return output;
        }
    }
}
