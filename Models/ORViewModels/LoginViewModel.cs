using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrdersRegisterWeb
{
    public class LoginViewModel
    {
        public ShopModel ShopModel { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public bool IsPasswordCorrect { get; set; }
    }
}
