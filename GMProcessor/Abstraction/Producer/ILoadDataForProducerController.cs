using Models;
using System.Collections.Generic;

namespace GMProcessor
{
    public interface ILoadDataForProducerController
    {
        List<ProducerViewModel> Get();
    }
}