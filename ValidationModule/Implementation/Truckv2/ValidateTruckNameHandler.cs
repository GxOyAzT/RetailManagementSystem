using Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ValidationModule
{
    public class ValidateTruckNameHandler : BaseHandler, IValidateTruckNameHandler
    {
        IValidateTruckName _validateTruckName;

        public ValidateTruckNameHandler(IValidateTruckName validateTruckName)
        {
            _validateTruckName = validateTruckName;
        }

        public override void Process(RequestData request)
        {
            if (request.Data is TruckModel truck)
            {
                if (!_validateTruckName.Validate(truck.Name))
                    request.MessageErrors.Add("Truck name is in incorrect format.");

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
