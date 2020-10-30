using System;
using System.Collections.Generic;
using System.Text;

namespace DatabaseModule
{
    public static class ConnectionStringADO
    {
        public static string Conn => "Server=.;Trusted_Connection=true;Database=ShopTests;MultipleActiveResultSets=true";
    }
}
