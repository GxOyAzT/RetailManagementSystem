using System;

namespace Models.EFModels
{
    public interface IProductAvaliabilityModel
    {
        bool AvailabilityAtProducer { get; set; }
        bool IsInSale { get; set; }
    }
}