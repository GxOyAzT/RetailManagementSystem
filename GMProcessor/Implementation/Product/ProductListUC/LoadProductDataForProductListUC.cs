using DatabaseModule;
using Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace GMProcessor
{
    public class LoadProductDataForProductListUC : ILoadProductDataForProductListUC
    {
        private readonly IGetFullProductBasicProducerData getFullProductBasicProducerDataADO;

        public LoadProductDataForProductListUC(IGetFullProductBasicProducerData getFullProductBasicProducerDataADO)
        {
            this.getFullProductBasicProducerDataADO = getFullProductBasicProducerDataADO;
        }

        public List<FullProductDataModelBasicCompany> Load()
        {
            return getFullProductBasicProducerDataADO.GetFullProductModel();
        }
    }
}
