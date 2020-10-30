namespace ValidationModule
{
    public interface IValidateBasicProductData
    {
        bool ValidateBarecode(string barecode);
        bool ValidateName(string name);
        bool ValidateShortName(string shortName);
    }
}