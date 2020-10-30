using System;
using System.Collections.Generic;

namespace Models
{
    public class ProductBasicsModel
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string ShortName { get; set; }
        public string Barecode { get; set; }
        public Guid ProducerId { get; set; }

        public virtual ProducerModel ProducerModel { get; set; }
        public virtual ProductPriceModel ProductPriceModel { get; set; }
        public virtual ProductStorageModel ProductStorageModel { get; set; }
        public virtual ProductAvaliabilityModel ProductAvaliabilityModel { get; set; }
        public virtual WarehouseModel WarehouseModel { get; set; }
        public virtual ICollection<WarehouseChangesModel> WarehouseChangesModels { get; set; }
        public virtual ICollection<EachShopModel> EachShopModels { get; set; }
        public virtual ICollection<EachShopChangesModel> EachShopChangesModels { get; set; }
    }
}
