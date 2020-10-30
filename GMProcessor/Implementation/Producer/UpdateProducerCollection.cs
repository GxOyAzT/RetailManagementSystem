using DatabaseModule;
using Models;
using System;
using System.Collections.Generic;
using System.Text;
using ValidationModule;

namespace GMProcessor
{
    public class UpdateProducerCollection : IUpdateProducerCollection
    {
        private readonly IFullProducerValidation fullProducerValidation;
        private readonly IUpdateProducerData updateProducerData;
        public bool ValidationStatus { get; private set; }
        public string ErrorMessage { get; private set; }

        public UpdateProducerCollection(IFullProducerValidation fullProducerValidation, IUpdateProducerData updateProducerData)
        {
            this.fullProducerValidation = fullProducerValidation;
            this.updateProducerData = updateProducerData;
        }

        public bool Update(List<ProducerModel> producerModels)
        {
            foreach (var item in producerModels)
            {
                if (!fullProducerValidation.AreAllPropsCorrect(item))
                {
                    ValidationStatus = false;
                    ErrorMessage = $"Validation problem occured on {item.CompanyName} company.";
                    return false;
                }
            }

            foreach (var item in producerModels)
            {
                updateProducerData.Update(item);
            }

            return true;
        }
    }
}
