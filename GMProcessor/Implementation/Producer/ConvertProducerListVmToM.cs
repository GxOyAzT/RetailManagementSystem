using Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace GMProcessor
{
    public class ConvertProducerListVmToM : IConvertProducerListVmToM
    {
        public List<ProducerModel> Convert(List<ProducerViewModel> inputCollection)
        {
            var output = new List<ProducerModel>();

            foreach (var model in inputCollection)
                output.Add(new ProducerModel()
                {
                    Id = model.Id,
                    CompanyName = model.CompanyName,
                    Country = model.Country,
                    City = model.City,
                    Street = model.Street
                });

            return output;
        }
    }
}
