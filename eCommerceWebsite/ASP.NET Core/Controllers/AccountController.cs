using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Nancy.Json;
using ASP.NET_Core.APIComunication;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ASP.NET_Core.Models;
using System.Net.Mail;

namespace ASP.NET_Core.Controllers
{
    public class AccountController : Controller
    {
        private string email = "swiftclawserver@gmail.com";
       

        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Register(User user)
        {
            if (!ModelState.IsValid) { return View(); }
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
            if (!ModelState.IsValid) { return View(); }
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
            ViewBag.Model = APIClient.SetAPIClient("User/GetUserById/", APIClient.Token, APIClient.Token, HttpMethod.Get);
            return View();
        }
        public IActionResult Edit()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Edit(User user)
        {
            APIClient.SetAPIClient("User/UpdateUser/", data: APIClient.Token, user, APIClient.Token, HttpMethod.Put);
            return View();
        }
        public IActionResult Order()
        {
            ViewBag.Token = APIClient.Token;
            if (APIClient.Token != String.Empty)
            {
                var userString = APIClient.SetAPIClient("User/GetUserById/", APIClient.Token, APIClient.Token, HttpMethod.Get);
                JavaScriptSerializer jsonSerializer = new JavaScriptSerializer();
                var user = jsonSerializer.Deserialize<User>(userString);
                OrderModel order = new OrderModel();
                order.User = user;
                return View(order);
            }
            else
            {
                return View();
            }
        }
        [HttpPost]
        public IActionResult Order(OrderModel order)
        {
            APIClient.SetAPIClient("User/UpdateUser/", data: APIClient.Token, order.User, APIClient.Token, HttpMethod.Put);
            return View(order);
        }
        public async Task<IActionResult> SendMail(OrderModel order)
        {
            var userString = APIClient.SetAPIClient("User/GetUserById/", APIClient.Token, APIClient.Token, HttpMethod.Get);
            JavaScriptSerializer jsonSerializer = new JavaScriptSerializer();
            var user = jsonSerializer.Deserialize<User>(userString);
            MailMessage mm = new MailMessage();
            mm.To.Add(user.EMail);
            mm.Subject = "Dragi "  +user.FirstName+  " - "  +user.LastName+ " ";
            mm.Body = "Uspešno ste porucili ovaj proizvod! Stići će Vam u roku od 2-3 radna dana na adresu " +user.Adress+ " " +user.AdressNumber+ " u " +user.Place+ " na poštanski broj " +user.PostalCode+ ". Hvala na kupovini našeg proizvoda. ";
            mm.IsBodyHtml = true;
            mm.From = new MailAddress(email);
            SmtpClient smtp = new SmtpClient("smtp.gmail.com");
            smtp.Port = 587;
            smtp.UseDefaultCredentials = true;
            smtp.EnableSsl = true;
            smtp.Credentials = new System.Net.NetworkCredential(email, "glavudzaodsira");
            await smtp.SendMailAsync(mm);
            return RedirectToAction(actionName:"Index", controllerName:"Home");
        }
    }
}
