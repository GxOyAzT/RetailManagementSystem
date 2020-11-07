using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DatabaseModule
{
    public class GenerateRandomOrderName : IGenerateRandomOrderName
    {
        private readonly IGetAllOrders getAllOrders;

        public GenerateRandomOrderName(IGetAllOrders getAllOrders)
        {
            this.getAllOrders = getAllOrders;
        }

        public string Generate()
        {
            var listOfOrderNames = getAllOrders.Get()
                .Where(e => e.IsSupplyConfirmed = false)
                .Select(e => e.OrderUqName)
                .ToList();


            StringBuilder stringBuilder = new StringBuilder();

            do
            {
                stringBuilder.Clear();

                const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";

                stringBuilder.Append('O');
                stringBuilder.Append(chars[(new Random()).Next(0, chars.Length - 1)]);
                stringBuilder.Append(chars[(new Random()).Next(0, chars.Length - 1)]);
                stringBuilder.Append(chars[(new Random()).Next(0, chars.Length - 1)]);
                stringBuilder.Append('-');
                stringBuilder.Append(chars[(new Random()).Next(0, chars.Length - 1)]);
                stringBuilder.Append(chars[(new Random()).Next(0, chars.Length - 1)]);
                stringBuilder.Append(chars[(new Random()).Next(0, chars.Length - 1)]);

            } while (listOfOrderNames.Contains(stringBuilder.ToString()));

            return stringBuilder.ToString();
        }
    }
}
