using DatabaseModule;
using Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ORProcessor
{
    public class GetVmForSupplyDetails : IGetVmForSupplyDetails
    {
        private readonly IGetSupplyWhereId getSupplyWhereId;
        private readonly IGetAllSupplyProductsWhereSupId getAllSupplyProductsWhereSupId;

        public GetVmForSupplyDetails(IGetSupplyWhereId getSupplyWhereId, IGetAllSupplyProductsWhereSupId getAllSupplyProductsWhereSupId)
        {
            this.getSupplyWhereId = getSupplyWhereId;
            this.getAllSupplyProductsWhereSupId = getAllSupplyProductsWhereSupId;
        }

        public SupplyDetailsVM Get(string supplyId)
        {
            Guid supplyIdGuid;

            if (!Guid.TryParse(supplyId, out supplyIdGuid))
                return null;

            return new SupplyDetailsVM()
            {
                SupplyModel = getSupplyWhereId.Get(supplyIdGuid),
                SupplyProductModels = getAllSupplyProductsWhereSupId.Get(supplyIdGuid)
            };
        }
    }
}
