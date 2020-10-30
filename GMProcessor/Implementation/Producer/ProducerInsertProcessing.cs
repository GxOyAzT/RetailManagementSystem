using DatabaseModule;
using Models;
using ValidationModule;

namespace GMProcessor
{
    public class ProducerInsertProcessing : IProducerInsertProcessing
    {
        private readonly IFullProducerValidation validateFullProducer;
        private readonly IInsertNewProducer insertNewProducer;
        public bool ValidationStatus { get; private set; }
        public string ErrorMessage { get; private set; }

        public ProducerInsertProcessing(IFullProducerValidation validateFullProducer, IInsertNewProducer insertNewProducer)
        {
            this.validateFullProducer = validateFullProducer;
            this.insertNewProducer = insertNewProducer;
        }

        public bool ProcessInsertion(ProducerModel model)
        {
            if (!validateFullProducer.AreAllPropsCorrect(model))
            {
                ValidationStatus = false;
                ErrorMessage = "Data is in incorrect format.";
                return false;
            }

            ValidationStatus = true;
            ErrorMessage = string.Empty;

            insertNewProducer.Insert(model);

            return true;
        }
    }
}
