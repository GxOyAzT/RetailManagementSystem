using Models;

namespace DatabaseModule
{
    public class UpdateProducerEF : IUpdateProducerData
    {
        public void Update(ProducerModel model)
        {
            using (var db = new ShopContext())
            {
                db.Producers.Update(model);
                db.SaveChanges();
            }
        }
    }
}
