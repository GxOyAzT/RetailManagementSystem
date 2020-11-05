using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    public class SupplyModel
    {
        public Guid Id { get; set; }
        public Guid TruckId { get; set; }
        public Guid OrderId { get; set; }
        public DateTime DateOfConfirmation { get; set; }
        public DateTime DateOfDelivery { get; set; }
        public string SupplyUqName { get; set; }
        public bool IsDelivered { get; set; }

        public virtual TruckModel TruckModel { get; set; }
        public virtual OrderModel OrderModel { get; set; }
    }
}
