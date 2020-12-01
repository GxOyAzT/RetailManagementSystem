using Models;
using ORProcessor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xunit;

namespace XTests
{
    public class GetAllNotConfirmedOrdersProcessTest
    {
        [Fact]
        public void GetAllNotConfirmedOrdersProcessTest_A()
        {
            IGetAllNotConfirmedOrdersProcess getAllNotConfirmedOrdersProcess = new GetAllNotConfirmedOrdersProcess(new DatabaseGetAllOrders());

            var output = getAllNotConfirmedOrdersProcess.Get(Guid.Parse("492acaa0-77a8-4ba9-81bb-325270a723d0"));

            Assert.IsType<List<OrderModel>>(output);
            Assert.NotEmpty(output);
            Assert.Contains("O000-001", output.Select(e => e.OrderUqName).ToList());
            Assert.DoesNotContain("O000-002", output.Select(e => e.OrderUqName).ToList());
        }
    }
}
