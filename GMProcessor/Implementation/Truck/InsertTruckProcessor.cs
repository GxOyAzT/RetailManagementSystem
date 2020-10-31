using DatabaseModule;
using Models;
using ValidationModule;

namespace GMProcessor
{
    public class InsertTruckProcessor : IInsertTruckProcessor
    {
        private readonly IInsertTruck insertTruck;
        private readonly IValidateTruckName validateTruckName;
        private readonly IValidateTruckNameUniqueness validateTruckNameUniqueness;

        public string ErrorMessage { get; private set; }

        public InsertTruckProcessor(IInsertTruck insertTruck, IValidateTruckName validateTruckName, IValidateTruckNameUniqueness validateTruckNameUniqueness)
        {
            this.insertTruck = insertTruck;
            this.validateTruckName = validateTruckName;
            this.validateTruckNameUniqueness = validateTruckNameUniqueness;
        }

        public bool Insert(TruckModel truckModel)
        {
            if (!validateTruckName.Validate(truckModel.Name))
            {
                ErrorMessage = "Incorrect truck name format.";
                return false;
            }

            if (!validateTruckNameUniqueness.IsUnique(truckModel.Name))
            {
                ErrorMessage = "This name is alreadu used.";
                return false;
            }

            insertTruck.Insert(truckModel);

            return true;
        }
    }
}
