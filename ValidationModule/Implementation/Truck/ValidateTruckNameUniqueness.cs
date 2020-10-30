using DatabaseModule;
using System.Linq;

namespace ValidationModule
{
    public class ValidateTruckNameUniqueness : IValidateTruckNameUniqueness
    {
        public ValidateTruckNameUniqueness(IGetAllTrucks getAllTrucks)
        {
            _getAllTrucksEF = getAllTrucks;
        }

        IGetAllTrucks _getAllTrucksEF { get; }

        public bool IsUnique(string name)
        {
            return _getAllTrucksEF.Get().Where(e => e.Name == name).Count() == 0;
        }
    }
}
