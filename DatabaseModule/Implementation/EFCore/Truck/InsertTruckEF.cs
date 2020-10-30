using Models;

namespace DatabaseModule
{
    public class InsertTruckEF : IInsertTruck
    {
        public void Insert(TruckModel model)
        {
            using (var db = new ShopContext())
            {
                db.TruckModels.Add(model);
                db.SaveChanges();
            }
        }
    }
}
