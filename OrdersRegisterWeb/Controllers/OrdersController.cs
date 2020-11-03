using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Autofac;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using ORProcessor;

namespace OrdersRegisterWeb.Controllers
{
    [Authorize]
    public class OrdersController : Controller
    {
        private readonly UserManager<IdentityUser> _userManager;
        private readonly SignInManager<IdentityUser> _signInManager;

        public OrdersController(UserManager<IdentityUser> userManager, SignInManager<IdentityUser> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;

        }

        public IActionResult AllOrders()
        {
            var result = _userManager.GetUserName(HttpContext.User);

            IGetAllOrdersProcess getAllOrdersProcess;

            using (var scope = ContainerConfig.Configure().BeginLifetimeScope())
            {
                getAllOrdersProcess = scope.Resolve<IGetAllOrdersProcess>();
            }

            return View(getAllOrdersProcess.Get(Guid.Parse(result)));
        }

        public IActionResult OrderDetails(string orderId)
        {
            return View();
        }
    }
}
