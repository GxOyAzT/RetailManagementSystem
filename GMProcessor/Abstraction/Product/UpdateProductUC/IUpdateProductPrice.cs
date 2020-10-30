using Models;

namespace GMProcessor
{
    public interface IUpdateProductPrice
    {
        string ErrorMessage { get; }

        bool Update(ProductPriceModel productPriceModel, string newPrice, string newTax);
    }
}