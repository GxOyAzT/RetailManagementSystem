using Models;

namespace DatabaseModule
{
    public interface IInsertPriceChangesModel
    {
        void Insert(PriceChangesModel model);
    }
}