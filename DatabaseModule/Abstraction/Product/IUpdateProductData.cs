using Models;
using Models.EFModels;

namespace DatabaseModule
{
    public interface IUpdateProductData
    {
        void UpdateAvaliability(ProductAvaliabilityModel model);
        void UpdateBasic(ProductBasicsModel model);
        void UpdatePrice(ProductPriceModel model);
        void UpdateStorage(ProductStorageModel model);
    }
}