using Models;

namespace ORProcessor
{
    public interface IGetVmForSupplyDetails
    {
        SupplyDetailsVM Get(string supplyId);
    }
}