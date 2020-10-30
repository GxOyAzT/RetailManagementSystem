using DatabaseModule;
using Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace GMProcessor
{
    public class LoadProducersForComboBox : ILoadProducersForComboBox
    {
        private readonly IGetAllProducers getAllProducers;

        public LoadProducersForComboBox(IGetAllProducers getAllProducers)
        {
            this.getAllProducers = getAllProducers;
        }

        public List<ProducerModel> Load()
        {
            return getAllProducers.GetProducers();
        }
    }
}
