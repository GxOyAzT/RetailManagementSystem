using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ValidationModule;

namespace GMProcessor
{
    public class FilterProductsForProductListUC : IFilterProductsForProductListUC
    {
        public List<FullProductDataModelBasicCompany> Filter(List<FullProductDataModelBasicCompany> inputModels, string productNameBarecode, string companyName, bool producerAval, bool inSale)
        {
            return inputModels.Where(e => e.Barecode == productNameBarecode || e.Name == productNameBarecode || e.CompanyName == companyName).Where(e => e.AvailabilityAtProducer == producerAval && e.IsInSale == inSale).ToList();
        }
    }
}
