using Models;

namespace DatabaseModule
{
    public class InsertNewProducerEF : IInsertNewProducer
    {
        public void Insert(ProducerModel model)
        {
            using (var db = new ShopContext())
            {
                db.Producers.Add(model);
                db.SaveChanges();
            }
        }
    }
}
