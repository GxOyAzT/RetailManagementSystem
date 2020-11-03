using Models;
using System.Collections.Generic;

namespace DatabaseModule
{
    public interface IGetAllProducts
    {
        List<ProductBasicsModel> Get();
    }
}