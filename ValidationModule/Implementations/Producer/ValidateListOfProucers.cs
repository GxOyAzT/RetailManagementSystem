using Models;
using System.Collections.Generic;

namespace ValidationModule
{
    public class ValidateListOfProucers : IValidateListOfProucers
    {
        public ValidateListOfProucers(IFullProducerValidation fullProducerValidation)
        {
            _fullProducerValidation = fullProducerValidation;
        }

        public IFullProducerValidation _fullProducerValidation { get; }

        public bool AreAllProducersCorrect(List<ProducerModel> models)
        {
            foreach (var producer in models)
            {
                if (!_fullProducerValidation.AreAllPropsCorrect(producer))
                {
                    return false;
                }
            }
            return true;
        }
    }
}
