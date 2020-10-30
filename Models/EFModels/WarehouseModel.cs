using System;

namespace Models
{
    public class WarehouseModel
    {
        public Guid ProductId { get; set; }
        public int ActualQuantity { get; set; }

        public ProductBasicsModel ProductBasicsModel { get; set; }
    }
}
