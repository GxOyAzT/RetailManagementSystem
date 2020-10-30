using System.Collections.Generic;
using Models;

namespace DatabaseModule
{
    public interface IGetFullProductBasicProducerDataADO
    {
        public List<FullProductDataModelBasicCompany> GetFullProductModel();
    }
}
