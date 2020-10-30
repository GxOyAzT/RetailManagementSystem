using Models;
using System.Collections.Generic;

namespace ValidationModule
{
    public interface IValidateListOfProucers
    {
        bool AreAllProducersCorrect(List<ProducerModel> models);
    }
}