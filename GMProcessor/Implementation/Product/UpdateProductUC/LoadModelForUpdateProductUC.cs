using DatabaseModule;
using Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace GMProcessor
{
    public class LoadModelForUpdateProductUC : ILoadModelForUpdateProductUC
    {
        private readonly IGetProductFullInfoById getProductFullInfoById;

        public LoadModelForUpdateProductUC(IGetProductFullInfoById getProductFullInfoById)
        {
            this.getProductFullInfoById = getProductFullInfoById;
        }

        public FullProductDataEachModels Load(Guid id)
        {
            return getProductFullInfoById.GetFullProductDataEachModels(id);
        }
    }
}
