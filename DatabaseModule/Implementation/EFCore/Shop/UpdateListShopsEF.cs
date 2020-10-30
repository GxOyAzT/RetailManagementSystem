using Models;
using System.Collections.Generic;

namespace DatabaseModule
{
    public class UpdateListShopsEF : IUpdateListShop
    {
        public UpdateListShopsEF(IUpdateShop updateShopEF)
        {
            _updateShopEF = updateShopEF;
        }

        IUpdateShop _updateShopEF { get; }

        public void Update(List<ShopModel> models)
        {
            foreach (var item in models)
            {
                _updateShopEF.Update(item);
            }
        }
    }
}
