using Models;
using System;

namespace ValidationModule
{
    public class ValidateTruckNameUqHandler : BaseHandler, IValidateTruckNameUqHandler
    {
        IValidateTruckNameUniqueness _validateTruckNameUniqueness;

        public ValidateTruckNameUqHandler(IValidateTruckNameUniqueness validateTruckNameUniqueness)
        {
            _validateTruckNameUniqueness = validateTruckNameUniqueness;
        }

        public override void Process(RequestData request)
        {
            if (request.Data is TruckModel truck)
            {
                if (!_validateTruckNameUniqueness.IsUnique(truck.Name))
                    request.MessageErrors.Add("Truck name already exists in databse.");

                if (_nextHandler != null)
                    _nextHandler.Process(request);
            }
            else
            {
                throw new Exception("RequestData.Data is incorrect type.");
            }
        }
    }
}
