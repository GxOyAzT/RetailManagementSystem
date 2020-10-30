using Models;
using System.Collections.Generic;
using System.Linq;

namespace DatabaseModule
{
    public class GetAllShopsEF : IGetAllShops
    {
        public List<ShopModel> Get()
        {
            using (var db = new ShopContext())
            {
                return db.ShopModels.ToList();
            }
        }
    }
}
