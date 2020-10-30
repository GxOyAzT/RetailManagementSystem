using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    public class ProductStorageModel
    {
        public Guid ProductId { get; set; }
        public int AimInWarehouse { get; set; }
        public int ProductWeight { get; set; }
        public int QuantityInBox { get; set; }

        public virtual ProductBasicsModel ProductBasicsModel { get; set; }
    }
}
