using SMProcessor;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using Xunit;

namespace XTests
{
    public class TestGenerateSupplyName
    {
        [Fact]
        public void GenerateSupplyUqName_Test()
        {
            IGenerateSupplyUqName generateSupplyUqName = new GenerateSupplyUqName();

            bool ans = true;

            for (int i = 0; i <= 100; i++)
            {
                if (!(new Regex("[S][ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789]{2}[-][ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789]{4}").IsMatch(generateSupplyUqName.Generate())))
                {
                    ans = false;
                    break;
                }
            }

            Assert.True(ans);
        }
    }
}
