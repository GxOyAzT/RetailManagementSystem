using DatabaseModule;
using Microsoft.EntityFrameworkCore.Query.Internal;
using Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace GMProcessor
{
    public class LoadDataForProducerController : ILoadDataForProducerController
    {
        private readonly IGetAllProducers getAllProducers;

        public LoadDataForProducerController(IGetAllProducers getAllProducers)
        {
            this.getAllProducers = getAllProducers;
        }

        public List<ProducerViewModel> Get()
        {
            var output = new List<ProducerViewModel>();

            foreach (var item in getAllProducers.GetProducers())
                output.Add(new ProducerViewModel(item));

            return output;
        }
    }
}
