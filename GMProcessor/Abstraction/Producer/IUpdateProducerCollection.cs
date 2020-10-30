using Models;
using System.Collections.Generic;

namespace GMProcessor
{
    public interface IUpdateProducerCollection
    {
        string ErrorMessage { get; }
        bool ValidationStatus { get; }

        bool Update(List<ProducerModel> producerModels);
    }
}