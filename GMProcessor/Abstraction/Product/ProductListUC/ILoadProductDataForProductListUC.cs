using Models;
using System.Collections.Generic;

namespace GMProcessor
{
    public interface ILoadProductDataForProductListUC
    {
        List<FullProductDataModelBasicCompany> Load();
    }
}