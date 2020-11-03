using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    public class ManageOrderProdVM
    {
        public Guid OrderId { get; set; }
        public ProductBasicsModel ProductBasicsModel { get; set; }
        public int NewOrderedQua { get; set; }
    }
}
