using Models;

namespace ValidationModule
{
    public interface IFullValidationProductBasicData
    {
        bool FullValidation(ProductBasicsModel model);
    }
}