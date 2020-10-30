using System;
using System.Collections.Generic;
using System.Linq;

namespace DatabaseModule
{
    public class GetAllShopsIdsEF : IGetAllShopsIds
    {
        public List<Guid> Get()
        {
            using (var db = new ShopContext())
            {
                return db.ShopModels.Select(e => e.Id).ToList();
            }
        }
    }
}
