using Models;

namespace ORProcessor
{
    public interface IGetOrderedDetailsVM
    {
        string ErrorMessage { get; }

        OrderDetailsViewModel Get(string orderId);
    }
}