using DatabaseModule;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ValidationModule;

namespace GMProcessor
{
    class InsertTruckProcessorv2 : IInsertTruckProcessor
    {
        public string ErrorMessage { get; private set; }
        IInsertTruck _insertTruck;
        IValidateTruckNameHandler _truckNameHandler;
        IValidateTruckNameUqHandler _truckNameUqHandler;


        public InsertTruckProcessorv2(IInsertTruck insertTruck, IValidateTruckNameUqHandler truckNameUqHandler, IValidateTruckNameHandler truckNameHandler)
        {
            _insertTruck = insertTruck;
            _truckNameHandler = truckNameHandler;
            _truckNameUqHandler = truckNameUqHandler;
        }

        public bool Insert(TruckModel truckModel)
        {
            RequestData requestData = new RequestData(truckModel);

            _truckNameHandler.Process(requestData);

            if (requestData.MessageErrors.Count == 0)
            {
                _insertTruck.Insert(truckModel);
                return true;
            }
            else
            {
                ErrorMessage = requestData.MessageErrors.Aggregate("Errors: ", (a, b) => a += b + " ", e => e.Substring(0, e.Length - 2));
                return false;
            }
        }
    }
}
