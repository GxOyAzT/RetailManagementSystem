namespace ValidationModule
{
    public interface IValidatePriceData
    {
        bool ValidatePrice(string price);
        bool ValidateTax(string price);
    }
}