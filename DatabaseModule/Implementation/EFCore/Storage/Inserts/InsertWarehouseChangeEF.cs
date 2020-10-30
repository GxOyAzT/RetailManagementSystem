using Models;

namespace DatabaseModule
{
    public class InsertWarehouseChangeEF : IInsertWarehouseChange
    {
        public void Insert(WarehouseChangesModel model)
        {
            using (var db = new ShopContext())
            {
                db.WarehouseChangesModels.Add(model);
                db.SaveChanges();
            }
        }
    }
}
