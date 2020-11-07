using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

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
        public bool IsSupplyConfirmed { get; set; }

        [NotMapped]
        public string ConfirmationDateString { get => ConfirmationDate == null ? "NOT CONFIRMED" : ConfirmationDate.Value.ToString("yyyy-MM-dd"); }

        public virtual ShopModel ShopModel { get; set; }
        public virtual ICollection<OrderProductModel> OrderProductModels { get; set; }
        public virtual ICollection<SupplyModel> SupplyModels { get; set; }
    }
}
