using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Threading.Tasks;
using Autofac;
using DatabaseModule;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Primitives;
using ORProcessor;

namespace OrdersRegisterWeb.Controllers
{
    public class HomeController : Controller
    {
        private readonly UserManager<IdentityUser> _userManager;
        private readonly SignInManager<IdentityUser> _signInManager;

        public HomeController(UserManager<IdentityUser> userManager, SignInManager<IdentityUser> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }

        public IActionResult Index()
        {
            return RedirectToAction("LoginPointOfSalesList");
        }

        [HttpGet]
        public async Task<string> RegisterNewPointOfSaleAccount(string token)
        {
            IGetInformationByToken getInformationByToken;

            using (var scope = ContainerConfig.Configure().BeginLifetimeScope())
            {
                getInformationByToken = scope.Resolve<IGetInformationByToken>();
            }

            var tokenModel = getInformationByToken.Get(token);

            if (tokenModel == null)
            {
                return "INCORRECT_TOKEN";
            }

            var user = new IdentityUser()
            {
                UserName = tokenModel.ShopId.ToString()
            };

            var result = await _userManager.CreateAsync(user, "Aa12");

            if (result.Succeeded)
            {
                using (var db = new ShopContext())
                {
                    var shopModel = db.ShopModels.FirstOrDefault(e => e.Id == tokenModel.ShopId);
                    shopModel.IsWebAccActive = true;
                    db.SaveChanges();
                }

                return "REGISTRATION_SUCCEDD";
            }
            else
            {
                return "REGISTRATION_FAILS";
            }
        }

        public IActionResult LoginPointOfSalesList()
        {
            IGetActiveShops getActiveShops;

            using (var scope = ContainerConfig.Configure().BeginLifetimeScope())
            {
                getActiveShops = scope.Resolve<IGetActiveShops>();
            }

            var models = getActiveShops.Get();

            ViewBag.Title = "Login";

            return View(models);
        }

        [HttpGet]
        public IActionResult Login(string shopId, string isPasswordIncorrect)
        {
            if (shopId == null || isPasswordIncorrect == null)
                return RedirectToAction("LoginPointOfSalesList");

            IGetShopWhereId getShopWhereId;

            using (var scope = ContainerConfig.Configure().BeginLifetimeScope())
            {
                getShopWhereId = scope.Resolve<IGetShopWhereId>();
            }

            var model = new LoginViewModel()
            {
                ShopModel = getShopWhereId.Get(Guid.Parse(shopId)),
                UserName = shopId,
                IsPasswordCorrect = Convert.ToBoolean(isPasswordIncorrect)
            };

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginViewModel loginViewModel)
        {
            var user = await _userManager.FindByNameAsync(loginViewModel.UserName);

            if (user != null)
            {
                var signInResult = await _signInManager.PasswordSignInAsync(user, loginViewModel.Password, false, false);

                if (signInResult.Succeeded)
                {
                    return RedirectToAction("AllOrders", "Orders");
                }
            }

            return RedirectToAction("Login", new { shopId = loginViewModel.UserName.ToString(), isPasswordIncorrect = true.ToString() });
        }

        public async Task<IActionResult> Logout()
        {
            if (User.Identity.IsAuthenticated)
            {
                await _signInManager.SignOutAsync();
            }
            return RedirectToAction("LoginPointOfSalesList");
        }
    }
}
