using GMProcessor;
using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.RegularExpressions;
using Xunit;

namespace XTests
{
    public class TestGenerateToken
    {
        [Fact]
        public void GenerateToken_Generate_Test()
        {
            IGenerateToken generateToken = new GenerateToken();

            bool ans = true;

            for (int i = 0; i <= 100; i++)
            {
                if (!(new Regex("[ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789]{50}").IsMatch(generateToken.Generate())))
                {
                    ans = false;
                    break;
                }
            }

            Assert.True(ans);
        }
    }
}
