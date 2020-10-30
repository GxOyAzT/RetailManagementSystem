using Models;

namespace GMProcessor
{
    public interface IUpdateProductBasic
    {
        string ErrorMessage { get; }

        bool Update(ProductBasicsModel productBasicsModel);
    }
}