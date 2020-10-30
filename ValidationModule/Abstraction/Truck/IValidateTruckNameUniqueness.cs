namespace ValidationModule
{
    public interface IValidateTruckNameUniqueness
    {
        bool IsUnique(string name);
    }
}