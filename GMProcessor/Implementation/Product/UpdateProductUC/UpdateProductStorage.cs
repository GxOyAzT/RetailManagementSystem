using DatabaseModule;
using Models;

namespace GMProcessor
{
    public class UpdateProductStorage : IUpdateProductStorage
    {
        private readonly IUpdateProductData updateProductData;

        public UpdateProductStorage(IUpdateProductData updateProductData)
        {
            this.updateProductData = updateProductData;
        }

        public void Update(ProductStorageModel productStorageModel)
        {
            updateProductData.UpdateStorage(productStorageModel);
        }
    }
}
