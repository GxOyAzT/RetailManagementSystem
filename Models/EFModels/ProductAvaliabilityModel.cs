using Models.EFModels;
using System;

namespace Models
{
    public class ProductAvaliabilityModel : IProductAvaliabilityModel
    {
        public Guid ProductId { get; set; }
        public bool AvailabilityAtProducer { get; set; }
        public bool IsInSale { get; set; }

        public virtual ProductBasicsModel ProductBasicsModel { get; set; }
    }
}
