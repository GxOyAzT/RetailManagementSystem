using System;
using System.Collections.Generic;
using System.Text;

namespace SMProcessor
{
    public class GenerateSupplyUqName : IGenerateSupplyUqName
    {
        public string Generate()
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";

            StringBuilder stringBuilder = new StringBuilder();

            stringBuilder.Append('S');

            stringBuilder.Append(chars[(new Random()).Next(0, chars.Length - 1)]);
            stringBuilder.Append(chars[(new Random()).Next(0, chars.Length - 1)]);

            stringBuilder.Append('-');

            stringBuilder.Append(chars[(new Random()).Next(0, chars.Length - 1)]);
            stringBuilder.Append(chars[(new Random()).Next(0, chars.Length - 1)]);
            stringBuilder.Append(chars[(new Random()).Next(0, chars.Length - 1)]);
            stringBuilder.Append(chars[(new Random()).Next(0, chars.Length - 1)]);

            return stringBuilder.ToString();
        }
    }
}
