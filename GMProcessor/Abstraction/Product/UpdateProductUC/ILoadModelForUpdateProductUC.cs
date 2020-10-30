using Models;
using System;

namespace GMProcessor
{
    public interface ILoadModelForUpdateProductUC
    {
        FullProductDataEachModels Load(Guid id);
    }
}