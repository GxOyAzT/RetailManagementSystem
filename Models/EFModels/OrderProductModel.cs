using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    public class OrderProductModel
    {
        public Guid OrderId { get; set; }
        public Guid ProductId { get; set; }
        public int Quantity { get; set; }

        public virtual ProductBasicsModel ProductBasicsModel { get; set; }
        public virtual OrderModel OrderModel { get; set; }
    }
}
