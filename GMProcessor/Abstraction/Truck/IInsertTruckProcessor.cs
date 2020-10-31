using Models;

namespace GMProcessor
{
    public interface IInsertTruckProcessor
    {
        string ErrorMessage { get; }

        bool Insert(TruckModel truckModel);
    }
}