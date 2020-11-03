using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    public class ShopWebAccountTokensModel
    {
        public Guid Id { get; set; }
        public Guid ShopId { get; set; }
        public DateTime DateTm { get; set; }
        public string Token { get; set; }

        public virtual ShopModel ShopModel { get; set; }
    }
}
