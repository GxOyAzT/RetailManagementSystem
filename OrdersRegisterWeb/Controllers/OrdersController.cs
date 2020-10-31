using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Autofac;
using Microsoft.AspNetCore.Mvc;
using ORProcessor;

namespace OrdersRegisterWeb.Controllers
{
    public class OrdersController : Controller
    {
        public IActionResult Index()
        {
            ILoadOrdersProc loadOrdersProc;

            using (var scope = ContainerConfig.Configure().BeginLifetimeScope())
            {
                loadOrdersProc = scope.Resolve<ILoadOrdersProc>();
            }

            return View(loadOrdersProc.Load());
        }
    }
}
