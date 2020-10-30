using Models;
using System;

namespace GMProcessor
{
    public interface IInsertProductProcessor
    {
        string ErrorMessage { get; }
        bool ValidationStatus { get; }

        bool Insert(string productName, string productShortName, string barecode, Guid producerId, string price, string tax, ProductStorageModel productStorageModel, ProductAvaliabilityModel productAvaliabilityModel);
    }
}