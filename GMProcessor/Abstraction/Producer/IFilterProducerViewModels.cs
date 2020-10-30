using Models;
using System.Collections.Generic;

namespace GMProcessor
{
    public interface IFilterProducerViewModels
    {
        List<ProducerViewModel> Filter(List<ProducerViewModel> inputProducerVM, string companyName, string country);
    }
}