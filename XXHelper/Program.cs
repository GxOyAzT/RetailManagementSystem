using DatabaseModule;
using System;

namespace XXHelper
{
    class Program
    {
        static void Main(string[] args)
        {
            var items = (new GetAllOrdersEF()).Get();
        }
    }
}
