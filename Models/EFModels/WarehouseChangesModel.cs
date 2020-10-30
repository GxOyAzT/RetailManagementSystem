using System;

namespace Models
{
    public class WarehouseChangesModel
    {
        public Guid ProductId { get; set; }
        public int Quantity { get; set; }
        public DateTime DateTimeOfChange { get; set; }

        public virtual ProductBasicsModel ProductBasicsModel { get; set; }
    }
}
