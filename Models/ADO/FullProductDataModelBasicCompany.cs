using Models;
using Models.EFModels;
using System;

namespace Models
{
    public class FullProductDataModelBasicCompany : IProductBasicsModel, IProductPriceModel, IProductStorageModel, IProductAvaliabilityModel
    {
        public Guid Id { get; set; }
        public string Barecode { get; set; }
        public string Name { get; set; }
        public string ShortName { get; set; }
        public decimal Price { get; set; }
        public int Tax { get; set; }
        public int AimInEachShop { get; set; }
        public int AimInWarehouse { get; set; }
        public int ProductWeight { get; set; }
        public int QuantityInBox { get; set; }
        public bool AvailabilityAtProducer { get; set; }
        public bool IsInSale { get; set; }
        public Guid ProducerId { get; set; }
        public string CompanyName { get; set; }
    }
}
