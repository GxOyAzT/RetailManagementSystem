using Models;

namespace GMProcessor
{
    public interface IProducerInsertProcessing
    {
        string ErrorMessage { get; }
        bool ValidationStatus { get; }

        bool ProcessInsertion(ProducerModel model);
    }
}