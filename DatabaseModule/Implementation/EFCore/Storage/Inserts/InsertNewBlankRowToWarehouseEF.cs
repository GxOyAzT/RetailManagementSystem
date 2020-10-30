using Models;

namespace DatabaseModule
{
    public class InsertNewBlankRowToWarehouseEF : IInsertNewBlankRowToWarehouse
    {
        public void Insert(WarehouseModel model)
        {
            using (var db = new ShopContext())
            {
                db.WarehouseModels.Add(model);
                db.SaveChanges();
            }
        }
    }
}
