using DatabaseModule;
using System;
using System.Collections.Generic;
using System.Text;

namespace SMProcessor
{
    public class ReturnUqSupplyName : IReturnUqSupplyName
    {
        private readonly IGetAllSupplyNamesWhereNotConfirmed getAllSupplyNamesWhereNotConfirmed;
        private readonly IGenerateSupplyUqName generateSupplyUqName;

        public ReturnUqSupplyName(IGetAllSupplyNamesWhereNotConfirmed getAllSupplyNamesWhereNotConfirmed, IGenerateSupplyUqName generateSupplyUqName)
        {
            this.getAllSupplyNamesWhereNotConfirmed = getAllSupplyNamesWhereNotConfirmed;
            this.generateSupplyUqName = generateSupplyUqName;
        }

        public string Return()
        {
            var occupiedNames = getAllSupplyNamesWhereNotConfirmed.Get();

            string generatedName;
            do
            {
                generatedName = generateSupplyUqName.Generate();
            } while (occupiedNames.Contains(generatedName));

            return generatedName;
        }
    }
}
