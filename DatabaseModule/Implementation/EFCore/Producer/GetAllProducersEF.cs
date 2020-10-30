using Models;
using System.Collections.Generic;
using System.Linq;

namespace DatabaseModule
{
    public class GetAllProducersEF : IGetAllProducers
    {
        public List<ProducerModel> GetProducers()
        {
            using (var db = new ShopContext())
            {
                return db.Producers.ToList();
            }
        }
    }
}
