using Autofac;
using DatabaseModule;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using ORProcessor;
using System;

namespace OrdersRegisterWeb.Controllers
{
    [Authorize]
    public class SuppliesController : Controller
    {
        private readonly UserManager<IdentityUser> _userManager;

        public SuppliesController(UserManager<IdentityUser> userManager)
        {
            _userManager = userManager;

        }

        [HttpGet]
        public IActionResult PlannedSupplies()
        {
            var result = _userManager.GetUserName(HttpContext.User);

            IGetAllSupplyWhereShopIdAndNotConf getAllSupplyWhereShopIdAndNotConf;

            using (var scope = ContainerConfig.Configure().BeginLifetimeScope())
            {
                getAllSupplyWhereShopIdAndNotConf = scope.Resolve<IGetAllSupplyWhereShopIdAndNotConf>();
            }

            return View(getAllSupplyWhereShopIdAndNotConf.Get(Guid.Parse(result)));
        }

        [HttpGet]
        public IActionResult SupplyDetails(string supplyId)
        {
            IGetVmForSupplyDetails getVmForSupplyDetails;

            using (var scope = ContainerConfig.Configure().BeginLifetimeScope())
            {
                getVmForSupplyDetails = scope.Resolve<IGetVmForSupplyDetails>();
            }

            return View(getVmForSupplyDetails.Get(supplyId));
        }
    }
}
