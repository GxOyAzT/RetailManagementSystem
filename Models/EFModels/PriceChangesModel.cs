using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    public class PriceChangesModel
    {
        public Guid ProductId { get; set; }
        public DateTime DateTimeOfChange { get; set; }
        public decimal NewPrice { get; set; }
    }
}
