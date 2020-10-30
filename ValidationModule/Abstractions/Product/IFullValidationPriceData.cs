namespace ValidationModule
{
    public interface IFullValidationPriceData
    {
        bool FullValidation(string price, string tax);
    }
}