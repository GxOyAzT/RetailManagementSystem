using DatabaseModule;
using System;
using System.Collections.Generic;
using System.Text;

namespace ORProcessor
{
    public class SetOrderStatusAsConfirmed : ISetOrderStatusAsConfirmed
    {
        private readonly IUpdateOrderAsConfById updateOrderAsConfById;
        public string ErrorMessage { get; private set; }

        public SetOrderStatusAsConfirmed(IUpdateOrderAsConfById updateOrderAsConfById)
        {
            this.updateOrderAsConfById = updateOrderAsConfById;
        }

        public bool Update(string orderId)
        {
            Guid orderIdGuid;

            if (!Guid.TryParse(orderId, out orderIdGuid))
            {
                ErrorMessage = "Order of this id does not exists in database.";
                return false;
            }

            if (!updateOrderAsConfById.Update(orderIdGuid))
            {
                ErrorMessage = "Order id is in incorrect format or order does not have any orderd products.";
                return false;
            }

            return true;
        }
    }
}
