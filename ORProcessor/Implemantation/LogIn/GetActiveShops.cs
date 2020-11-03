using DatabaseModule;
using Models;
using System.Collections.Generic;
using System.Linq;

namespace ORProcessor
{
    public class GetActiveShops : IGetActiveShops
    {
        private readonly IGetAllShops getAllShops;

        public GetActiveShops(IGetAllShops getAllShops)
        {
            this.getAllShops = getAllShops;
        }

        public List<ShopModel> Get()
        {
            return getAllShops.Get().Where(e => e.IsWebAccActive).ToList();
        }
    }
}
