using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    public class TaxChangesModel
    {
        public Guid ProductId { get; set; }
        public DateTime DateTimeOfChange { get; set; }
        public int NewTax { get; set; }
    }
}
