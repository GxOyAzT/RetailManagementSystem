using Models;
using System.Collections.Generic;

namespace GMProcessor
{
    public interface IConvertProducerListVmToM
    {
        List<ProducerModel> Convert(List<ProducerViewModel> inputCollection);
    }
}