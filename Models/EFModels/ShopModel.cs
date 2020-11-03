using System;
using System.Collections.Generic;

namespace Models
{
    public class ShopModel
    {
        public Guid Id { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public bool IsWebAccActive { get; set; } = false;

        public virtual ICollection<OrderModel> OrderModels { get; set; }
        public virtual ICollection<ShopWebAccountTokensModel> ShopWebAccountTokensModels { get; set; }
    }
}
