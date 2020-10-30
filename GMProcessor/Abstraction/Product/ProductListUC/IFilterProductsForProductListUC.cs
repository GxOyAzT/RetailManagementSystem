using Models;
using System.Collections.Generic;

namespace GMProcessor
{
    public interface IFilterProductsForProductListUC
    {
        List<FullProductDataModelBasicCompany> Filter(List<FullProductDataModelBasicCompany> inputModels, string productNameBarecode, string companyName, bool producerAval, bool inSale);
    }
}