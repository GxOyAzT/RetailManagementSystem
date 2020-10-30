using Models;

namespace DatabaseModule
{
    public class UpdateWarehouseEF : IUpdateWarehouse
    {
        public void Update(WarehouseModel model)
        {
            using (var db = new ShopContext())
            {
                db.WarehouseModels.Update(model);
            }
        }
    }
}
