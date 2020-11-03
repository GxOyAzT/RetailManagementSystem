using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GMProcessor
{
    public class GenerateToken : IGenerateToken
    {
        public string Generate()
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, 50)
              .Select(s => s[(new Random()).Next(s.Length)]).ToArray());
        }
    }
}
