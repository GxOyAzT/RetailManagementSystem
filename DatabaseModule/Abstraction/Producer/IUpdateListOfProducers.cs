using Models;
using System.Collections.Generic;

namespace DatabaseModule
{
    public interface IUpdateListOfProducers
    {
        void Update(List<ProducerModel> models);
    }
}