using System;
using System.Collections.Generic;
using Autofac;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Models;
using ORProcessor;

namespace OrdersRegisterWeb.Controllers
{
    [Authorize]
    public class OrdersController : Controller
    {
        private readonly UserManager<IdentityUser> _userManager;

        public OrdersController(UserManager<IdentityUser> userManager)
        {
            _userManager = userManager;

        }

        public IActionResult AllOrders()
        {
            var result = _userManager.GetUserName(HttpContext.User);

            IGetAllOrdersProcess getAllOrdersProcess;

            using (var scope = ContainerConfig.Configure().BeginLifetimeScope())
            {
                getAllOrdersProcess = scope.Resolve<IGetAllOrdersProcess>();
            }

            var orders = getAllOrdersProcess.Get(Guid.Parse(result));

            return View(orders);
        }

        public IActionResult OrderDetails(string orderId)
        {
            IGetOrderedDetailsVM getOrderedDetailsVM;

            using (var scope = ContainerConfig.Configure().BeginLifetimeScope())
            {
                getOrderedDetailsVM = scope.Resolve<IGetOrderedDetailsVM>();
            }

            return View(getOrderedDetailsVM.Get(orderId));
        }

        public IActionResult ConfirmOrder(string orderId)
        {
            ISetOrderStatusAsConfirmed setOrderStatusAsConfirmed;

            using (var scope = ContainerConfig.Configure().BeginLifetimeScope())
            {
                setOrderStatusAsConfirmed = scope.Resolve<ISetOrderStatusAsConfirmed>();
            }

            if (!setOrderStatusAsConfirmed.Update(orderId))
            {
                return View(new ErrorMessage() { ErrorMess = setOrderStatusAsConfirmed.ErrorMessage });
            }

            return View(new ErrorMessage() { ErrorMess = "Order has been confirmed successfully." });
        }

        [HttpGet]
        public IActionResult ManageOrderProducts(string orderId)
        {
            ILoadDataToManageOrderProd loadDataToManageOrderProd;

            using (var scope = ContainerConfig.Configure().BeginLifetimeScope())
            {
                loadDataToManageOrderProd = scope.Resolve<ILoadDataToManageOrderProd>();
            }

            var input = loadDataToManageOrderProd.Load(orderId);

            return View(input);
        }

        [HttpPost]
        public IActionResult ManageOrderProducts(List<ManageOrderProdVM> input)
        {
            IProcessManageOrderProducts processManageOrderProducts;

            using (var scope = ContainerConfig.Configure().BeginLifetimeScope())
            {
                processManageOrderProducts = scope.Resolve<IProcessManageOrderProducts>();
            }

            processManageOrderProducts.Process(input, input[0].OrderId);

            return RedirectToAction("OrderDetails", new { orderId = input[0].OrderId.ToString() });
        }
    }
}
