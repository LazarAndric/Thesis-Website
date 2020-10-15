using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using ASP.NET_Core.APIComunication;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ASP.NET_Core.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Register(User user)
        {
            var response = APIClient.SetAPIClient<User>("User/CreateUser", user, APIClient.Token, HttpMethod.Post);
            if (response == null)
            {
                ViewData["LoginMessage"] = "Nesto ste uneli pogresno";
                return View();
            }
            return RedirectToAction("Index", controllerName: "Home");
        }

        public IActionResult Login()
        {
            return View();
        }
        
        [HttpPost]
        public IActionResult Login(LoginUserModel model)
        {
            var response=APIClient.SetAPIClient<LoginUserModel>("User/Login", model ,HttpMethod.Get);
            if (response == null)
            {
                ViewData["LoginMessage"] = "Uneli ste pogresan e-mail ili lozinku";
                return View();
            }
            APIClient.Token = response;
            var jsonString = APIClient.SetAPIClient("User/GetUserById/", APIClient.Token, APIClient.Token, HttpMethod.Get);
            HttpContext.Session.SetString("user", jsonString);
            return RedirectToAction("Index", controllerName: "Home");
        }

        public IActionResult LogOut(int number)
        {
            APIClient.Token = String.Empty;
            return RedirectToAction("Index", controllerName: "Home");
        }
        public IActionResult ForgotPassword()
        {
            return View();
        }
        public IActionResult Profile()
        {
            ViewBag.Model = HttpContext.Session.GetString("user");
            return View();
        }
        public IActionResult Edit()
        {
            return View();
        }
    }
}
