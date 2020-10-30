using Models;
using System.Collections.Generic;
using System.Linq;

namespace GMProcessor
{
    public class FilterProducerViewModels : IFilterProducerViewModels
    {
        public List<ProducerViewModel> Filter(List<ProducerViewModel> inputProducerVM, string companyName, string country)
        {
            if (companyName == string.Empty && country == string.Empty)
                return inputProducerVM;

            return inputProducerVM = inputProducerVM.Where(e => e.CompanyName.Contains(companyName) && e.Country.Contains(country)).ToList();
        }
    }
}
