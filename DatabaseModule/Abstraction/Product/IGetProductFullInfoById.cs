using Models;
using System;

namespace DatabaseModule
{
    public interface IGetProductFullInfoById
    {
        FullProductDataEachModels GetFullProductDataEachModels(Guid productId);
    }
}