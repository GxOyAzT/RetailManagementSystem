using System;
using System.Collections.Generic;

namespace Models
{
    public class OrderModel
    {
        public Guid Id { get; set; }
        public string OrderUqName { get; set; }
        public DateTime CreationDate { get; set; }
        public Guid ShopId { get; set; }
        public bool IsConfirmed { get; set; }
        public DateTime? ConfirmationDate { get; set; }

        public virtual ShopModel ShopModel { get; set; }
        public virtual ICollection<OrderProductModel> OrderProductModels { get; set; }
    }
}
