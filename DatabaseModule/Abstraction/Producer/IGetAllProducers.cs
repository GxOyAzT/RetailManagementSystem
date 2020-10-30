using Models;
using System.Collections.Generic;

namespace DatabaseModule
{
    public interface IGetAllProducers
    {
        List<ProducerModel> GetProducers();
    }
}