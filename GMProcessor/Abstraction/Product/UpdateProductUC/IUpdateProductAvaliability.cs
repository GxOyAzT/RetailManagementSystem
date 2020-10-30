using Models;

namespace GMProcessor
{
    public interface IUpdateProductAvaliability
    {
        void Update(ProductAvaliabilityModel productAvaliabilityModel, bool producerAva, bool isInSale);
    }
}