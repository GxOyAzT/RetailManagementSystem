using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    public class TruckModel
    {
        public Guid Id { get; set; }
        public int MaxCapacity { get; set; }
        public string Name { get; set; }
        public bool IsAvaliable { get; set; }

        public virtual ICollection<SupplyModel> SupplyModels { get; set; }
    }
}
