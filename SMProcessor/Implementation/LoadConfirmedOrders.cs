using DatabaseModule;
using Models;
using System.Collections.Generic;
using System.Linq;

namespace SMProcessor
{
    public class LoadConfirmedOrders : ILoadConfirmedOrders
    {
        private readonly IGetAllOrders getAllOrders;

        public LoadConfirmedOrders(IGetAllOrders getAllOrders)
        {
            this.getAllOrders = getAllOrders;
        }

        public List<OrderModel> Load()
        {
            return getAllOrders.Get().Where(e => e.IsConfirmed).OrderBy(e => e.ConfirmationDate).ToList();
        }
    }
}
