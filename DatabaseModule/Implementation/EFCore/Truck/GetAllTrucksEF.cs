using Models;
using System.Collections.Generic;
using System.Linq;

namespace DatabaseModule
{
    public class GetAllTrucksEF : IGetAllTrucks
    {
        public List<TruckModel> Get()
        {
            using (var db = new ShopContext())
            {
                return db.TruckModels.ToList();
            }
        }
    }
}
