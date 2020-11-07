using System.Collections.Generic;
using System.Linq;

namespace DatabaseModule
{
    public class GetAllSupplyNamesWhereNotConfirmedEF : IGetAllSupplyNamesWhereNotConfirmed
    {
        public List<string> Get()
        {
            using (var db = new ShopContext())
            {
                return db.SupplyModels
                    .Where(e => !e.IsDelivered)
                    .Select(e => e.SupplyUqName)
                    .ToList();
            }
        }
    }
}
