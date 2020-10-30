using System.Collections.Generic;
using Models;

namespace DatabaseModule
{
    public interface IGetFullProductBasicProducerData
    {
        public List<FullProductDataModelBasicCompany> GetFullProductModel();
    }
}
