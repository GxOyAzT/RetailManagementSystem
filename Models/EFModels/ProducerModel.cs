using System;
using System.Collections.Generic;

namespace Models
{
    public class ProducerModel
    {
        public Guid Id { get; set; }
        public string CompanyName { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public string Street { get; set; }

        public virtual ICollection<ProductBasicsModel> ProductBasicsModels { get; set; }
    }
}
