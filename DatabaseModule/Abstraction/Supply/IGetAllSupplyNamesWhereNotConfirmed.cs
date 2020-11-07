using System.Collections.Generic;

namespace DatabaseModule
{
    public interface IGetAllSupplyNamesWhereNotConfirmed
    {
        List<string> Get();
    }
}