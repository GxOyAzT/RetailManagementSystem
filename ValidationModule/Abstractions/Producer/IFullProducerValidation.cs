using Models;

namespace ValidationModule
{
    public interface IFullProducerValidation
    {
        public bool AreAllPropsCorrect(ProducerModel model);
    }
}
