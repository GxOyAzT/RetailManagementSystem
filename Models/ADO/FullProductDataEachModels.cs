using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    public class FullProductDataEachModels
    {
        public ProductBasicsModel ProductBasicsModel { get; set; }
        public ProductPriceModel ProductPriceModel { get; set; }
        public ProductStorageModel ProductStorageModel { get; set; }
        public ProductAvaliabilityModel ProductAvaliabilityModel { get; set; }
        public ProducerModel ProducerModel { get; set; }
    }
}
