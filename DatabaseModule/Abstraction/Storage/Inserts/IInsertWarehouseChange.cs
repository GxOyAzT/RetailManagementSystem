using Models;

namespace DatabaseModule
{
    public interface IInsertWarehouseChange
    {
        void Insert(WarehouseChangesModel model);
    }
}