using System;
using System.Collections.Generic;

namespace Models
{
    public class ShopModel
    {
        public Guid Id { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public int StorageCapacity { get; set; }

        public virtual ICollection<EachShopModel> EachShopModels { get; set; }
        public virtual ICollection<EachShopChangesModel> EachShopChangesModels { get; set; }
    }
}
