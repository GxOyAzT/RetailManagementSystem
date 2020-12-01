using Models;
using ORProcessor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xunit;

namespace XTests
{
    public class GetAllConfirmedOrdersProcessTest
    {
        [Fact]
        public void GetAllConfirmedOrdersProcessTest_A()
        {
            IGetAllConfirmedOrdersProcess getAllConfirmedOrdersProcess = new GetAllConfirmedOrdersProcess(new DatabaseGetAllOrders());

            var output = getAllConfirmedOrdersProcess.Get(Guid.Parse("492acaa0-77a8-4ba9-81bb-325270a723d0"));

            Assert.IsType<List<OrderModel>>(output);
            Assert.NotNull(output);
            Assert.Contains("O000-002", output.Select(e => e.OrderUqName).ToList());
            Assert.DoesNotContain("O000-001", output.Select(e => e.OrderUqName).ToList());
        }
    }
}
