namespace ORProcessor
{
    public interface ISetOrderStatusAsConfirmed
    {
        string ErrorMessage { get; }

        bool Update(string orderId);
    }
}