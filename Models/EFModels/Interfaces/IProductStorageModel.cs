using System;

namespace Models
{
    public interface IProductStorageModel
    {
        int AimInEachShop { get; set; }
        int AimInWarehouse { get; set; }
        int ProductWeight { get; set; }
        int QuantityInBox { get; set; }
    }
}