using Models;

namespace DatabaseModule
{
    public interface IInsertTaxChanges
    {
        void Insert(TaxChangesModel model);
    }
}