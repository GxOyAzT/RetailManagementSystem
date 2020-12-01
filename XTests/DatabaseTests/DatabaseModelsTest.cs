using Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace XTests
{
    class DatabaseModelsTest
    {
        public List<ProducerModel> Producers { get; private set; }
        public List<ProductBasicsModel> ProductBasicsModels { get; private set; }
        public List<ProductPriceModel> ProductPriceModels { get; private set; }
        public List<ProductStorageModel> ProductStorageModels { get; private set; }
        public List<ProductAvaliabilityModel> ProductAvaliabilityModels { get; private set; }
        public List<ShopModel> ShopModels { get; private set; }
        public List<TruckModel> TruckModels { get; private set; }
        public List<OrderModel> OrderModels { get; private set; }
        public List<OrderProductModel> OrderProductModels { get; private set; }

        public DatabaseModelsTest()
        {
            InitializeProducers();
            InitializeProductBasicsModels();
            InitializeProductPriceModels();
            InitializeProductStorageModels();
            InitializeProductAvaliabilityModels();
            InitializeShopModels();
            InitializeTruckModels();
            InitializeOrderModels();
            InitializeOrderProductModels();
        }
        
        public void InitializeProducers()
        {
            Producers = new List<ProducerModel>();

            Producers.Add(new ProducerModel()
            {
                Id = Guid.Parse("5d2a9faa-16e3-425f-a7b4-f8e74722d920"),
                CompanyName = "Company_1",
                City = "City_1",
                Street = "Street_1",
                Country = "Country_1"
            });

            Producers.Add(new ProducerModel()
            {
                Id = Guid.Parse("6608c47c-1a4f-4279-9829-fda87d38ebe2"),
                CompanyName = "Company_2",
                City = "City_2",
                Street = "Street_2",
                Country = "Country_2"
            });

            Producers.Add(new ProducerModel()
            {
                Id = Guid.Parse("ee0f86d1-f1b1-4aa2-8736-dc47f64a9654"),
                CompanyName = "Company_3",
                City = "City_2",
                Street = "Street_3",
                Country = "Country_2"
            });
        }

        public void InitializeProductBasicsModels()
        {
            ProductBasicsModels = new List<ProductBasicsModel>();

            ProductBasicsModels.Add(new ProductBasicsModel()
            {
                Id = Guid.Parse("64f1540b-963c-412c-8f2c-6fb34abeff85"),
                Barecode = "00000000001",
                Name = "Product_1",
                ProducerId = Guid.Parse("5d2a9faa-16e3-425f-a7b4-f8e74722d920"),
                ShortName = "Pr1"
            });

            ProductBasicsModels.Add(new ProductBasicsModel()
            {
                Id = Guid.Parse("049391af-0863-4901-923a-b5577905809e"),
                Barecode = "00000000002",
                Name = "Product_2",
                ProducerId = Guid.Parse("6608c47c-1a4f-4279-9829-fda87d38ebe2"),
                ShortName = "Pr2"
            });

            ProductBasicsModels.Add(new ProductBasicsModel()
            {
                Id = Guid.Parse("b74907ef-2018-4c48-8fd3-8c2291e17052"),
                Barecode = "00000000003",
                Name = "Product_3",
                ProducerId = Guid.Parse("ee0f86d1-f1b1-4aa2-8736-dc47f64a9654"),
                ShortName = "Pr3"
            });

            ProductBasicsModels.Add(new ProductBasicsModel()
            {
                Id = Guid.Parse("bb894ee7-ac1f-4b22-9500-a719fb0b6d3d"),
                Barecode = "00000000004",
                Name = "Product_4",
                ProducerId = Guid.Parse("ee0f86d1-f1b1-4aa2-8736-dc47f64a9654"),
                ShortName = "Pr4"
            });
        }

        public void InitializeProductPriceModels()
        {
            ProductPriceModels = new List<ProductPriceModel>();

            ProductPriceModels.Add(new ProductPriceModel()
            {
                ProductId = Guid.Parse("64f1540b-963c-412c-8f2c-6fb34abeff85"),
                Price = 2.99M,
                Tax = 19
            });

            ProductPriceModels.Add(new ProductPriceModel()
            {
                ProductId = Guid.Parse("049391af-0863-4901-923a-b5577905809e"),
                Price = 9.79M,
                Tax = 19
            });

            ProductPriceModels.Add(new ProductPriceModel()
            {
                ProductId = Guid.Parse("ee0f86d1-f1b1-4aa2-8736-dc47f64a9654"),
                Price = 0.89M,
                Tax = 19
            });

            ProductPriceModels.Add(new ProductPriceModel()
            {
                ProductId = Guid.Parse("bb894ee7-ac1f-4b22-9500-a719fb0b6d3d"),
                Price = 79.99M,
                Tax = 19
            });
        }

        public void InitializeProductStorageModels()
        {
            ProductStorageModels = new List<ProductStorageModel>();

            ProductStorageModels.Add(new ProductStorageModel()
            {
                ProductId = Guid.Parse("64f1540b-963c-412c-8f2c-6fb34abeff85"),
                QuantityInBox = 12,
                ProductWeight = 2
            });

            ProductStorageModels.Add(new ProductStorageModel()
            {
                ProductId = Guid.Parse("049391af-0863-4901-923a-b5577905809e"),
                QuantityInBox = 6,
                ProductWeight = 15
            });

            ProductStorageModels.Add(new ProductStorageModel()
            {
                ProductId = Guid.Parse("ee0f86d1-f1b1-4aa2-8736-dc47f64a9654"),
                QuantityInBox = 20,
                ProductWeight = 4
            });

            ProductStorageModels.Add(new ProductStorageModel()
            {
                ProductId = Guid.Parse("bb894ee7-ac1f-4b22-9500-a719fb0b6d3d"),
                QuantityInBox = 2,
                ProductWeight = 50
            });
        }

        public void InitializeProductAvaliabilityModels()
        {
            ProductAvaliabilityModels = new List<ProductAvaliabilityModel>();

            ProductAvaliabilityModels.Add(new ProductAvaliabilityModel()
            {
                ProductId = Guid.Parse("64f1540b-963c-412c-8f2c-6fb34abeff85"),
                AvailabilityAtProducer = true,
                IsInSale = false
            });

            ProductAvaliabilityModels.Add(new ProductAvaliabilityModel()
            {
                ProductId = Guid.Parse("049391af-0863-4901-923a-b5577905809e"),
                AvailabilityAtProducer = true,
                IsInSale = false
            });

            ProductAvaliabilityModels.Add(new ProductAvaliabilityModel()
            {
                ProductId = Guid.Parse("ee0f86d1-f1b1-4aa2-8736-dc47f64a9654"),
                AvailabilityAtProducer = true,
                IsInSale = false
            });

            ProductAvaliabilityModels.Add(new ProductAvaliabilityModel()
            {
                ProductId = Guid.Parse("bb894ee7-ac1f-4b22-9500-a719fb0b6d3d"),
                AvailabilityAtProducer = false,
                IsInSale = false
            });
        }

        public void InitializeShopModels()
        {
            ShopModels = new List<ShopModel>();

            ShopModels.Add(new ShopModel()
            {
                Id = Guid.Parse("492acaa0-77a8-4ba9-81bb-325270a723d0"),
                City = "City_1",
                Street = "Street_1",
                IsWebAccActive = false
            });

            ShopModels.Add(new ShopModel()
            {
                Id = Guid.Parse("054b9cf4-72ad-4833-ad72-b56376b5bbf5"),
                City = "City_2",
                Street = "Street_2",
                IsWebAccActive = false
            });
        }

        public void InitializeTruckModels()
        {
            TruckModels = new List<TruckModel>();

            TruckModels.Add(new TruckModel()
            {
                Id = Guid.Parse("df0afb4f-04bb-412f-974d-6a5b6f5cca8c"),
                Name = "TR001",
                MaxCapacity = 1500,
                IsAvaliable = true
            });

            TruckModels.Add(new TruckModel()
            {
                Id = Guid.Parse("9323bf58-9312-4e38-b47e-93dffdc8435d"),
                Name = "TR002",
                MaxCapacity = 5000,
                IsAvaliable = true
            });

            TruckModels.Add(new TruckModel()
            {
                Id = Guid.Parse("e4343c92-c885-4170-8c89-47e62df56ab0"),
                Name = "TR003",
                MaxCapacity = 500,
                IsAvaliable = false
            });
        }

        public void InitializeOrderModels()
        {
            OrderModels = new List<OrderModel>();

            OrderModels.Add(new OrderModel()
            {
                Id = Guid.Parse("98e290eb-8883-4378-b16f-e9278e183a32"),
                OrderUqName = "O000-001",
                ShopId = Guid.Parse("492acaa0-77a8-4ba9-81bb-325270a723d0"),
                CreationDate = new DateTime(2020, 10, 1),
                IsConfirmed = false,
                IsSupplyConfirmed = false
            });

            OrderModels.Add(new OrderModel()
            {
                Id = Guid.Parse("38417c8e-82f3-4b87-b8c6-b786a41733a3"),
                OrderUqName = "O000-002",
                ShopId = Guid.Parse("492acaa0-77a8-4ba9-81bb-325270a723d0"),
                CreationDate = new DateTime(2020, 9, 25),
                IsConfirmed = true,
                IsSupplyConfirmed = false
            });
        }

        public void InitializeOrderProductModels()
        {
            OrderProductModels = new List<OrderProductModel>();


            // O000-001
            OrderProductModels.Add(new OrderProductModel()
            {
                OrderId = Guid.Parse("98e290eb-8883-4378-b16f-e9278e183a32"),
                ProductId = Guid.Parse("64f1540b-963c-412c-8f2c-6fb34abeff85"),
                Quantity = 5
            });

            OrderProductModels.Add(new OrderProductModel()
            {
                OrderId = Guid.Parse("98e290eb-8883-4378-b16f-e9278e183a32"),
                ProductId = Guid.Parse("049391af-0863-4901-923a-b5577905809e"),
                Quantity = 2
            });

            OrderProductModels.Add(new OrderProductModel()
            {
                OrderId = Guid.Parse("98e290eb-8883-4378-b16f-e9278e183a32"),
                ProductId = Guid.Parse("bb894ee7-ac1f-4b22-9500-a719fb0b6d3d"),
                Quantity = 10
            });

            // O000-002
            OrderProductModels.Add(new OrderProductModel()
            {
                OrderId = Guid.Parse("38417c8e-82f3-4b87-b8c6-b786a41733a3"),
                ProductId = Guid.Parse("049391af-0863-4901-923a-b5577905809e"),
                Quantity = 3
            });

            OrderProductModels.Add(new OrderProductModel()
            {
                OrderId = Guid.Parse("38417c8e-82f3-4b87-b8c6-b786a41733a3"),
                ProductId = Guid.Parse("bb894ee7-ac1f-4b22-9500-a719fb0b6d3d"),
                Quantity = 4
            });
        }
    }
}
