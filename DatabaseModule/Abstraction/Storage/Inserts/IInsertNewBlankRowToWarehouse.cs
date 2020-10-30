using Models;
using System;

namespace DatabaseModule
{
    public interface IInsertNewBlankRowToWarehouse
    {
        void Insert(WarehouseModel model);
    }
}