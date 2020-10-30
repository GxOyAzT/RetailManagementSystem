using Models;
using System.Collections.Generic;

namespace DatabaseModule
{
    public class UpdateProducersListEF : IUpdateListOfProducers
    {
        public void Update(List<ProducerModel> models)
        {
            using (var db = new ShopContext())
            {
                db.UpdateRange(models);
                db.SaveChanges();
            }
        }
    }
}
