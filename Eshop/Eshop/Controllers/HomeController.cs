using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Eshop.Models;
using Eshop.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Http;

namespace Eshop.Controllers
{
    public class HomeController : Controller
    {
        
        private readonly EshopContext _context;

        public HomeController(EshopContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {

            if (HttpContext.Request.Cookies.ContainsKey("AccountName"))
            {
                ViewBag.Fullname = HttpContext.Request.Cookies["AccountName"].ToString();
                ViewBag.Avatar = HttpContext.Request.Cookies["AccountAvatar"].ToString();
            }
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public IActionResult Login()
        {
            return View();
        }
        public async Task<IActionResult> Cake()
        {
            var Allprt = _context.Product.ToList();
            return View(Allprt);
        }
        public IActionResult SignUp()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Login(string Username, string Password)
        {

            //----------Login with Cookie
            Account login = _context.Account.Where(a => a.Username == Username && a.Password == Password).FirstOrDefault();

            if (login != null)
            {
                CookieOptions cookieDate = new CookieOptions()
                {
                    Expires = DateTime.Now.AddDays(30)
                    //Expires = DateTime.UtcNow.AddMilliseconds(1500)
                };

                HttpContext.Response.Cookies.Append("AccountId", login.Id.ToString(), cookieDate);
                HttpContext.Response.Cookies.Append("AccountName", login.Fullname.ToString(), cookieDate);
                HttpContext.Response.Cookies.Append("AccountAvatar", login.Avatar.ToString(), cookieDate);

                //HttpContext.Session.SetInt32("AccountId", login.Id);

                if (!login.IsAdmin)
                {
                        return RedirectToAction("Index", "Home");
                }
                else
                {
                    return RedirectToAction("Login", "Home");
                }

            }
            else
            {
                ViewBag.LoginFailMessage = "Login Fail. Incorrect Username or Password";
                return View();
            }

        }
        public IActionResult Logout()
        {
            HttpContext.Response.Cookies.Append("AccountID", "", new CookieOptions { Expires = DateTime.Now.AddDays(-1) });
            HttpContext.Response.Cookies.Append("AccountName", "", new CookieOptions { Expires = DateTime.Now.AddDays(-1) });
            HttpContext.Response.Cookies.Append("AccountAvatar", "", new CookieOptions { Expires = DateTime.Now.AddDays(-1) });
            return RedirectToAction("Index", "Home");

        }
        [HttpPost]
        public async Task<IActionResult> SignUp(string username, string email, string phone, string address, string fullname, string password, string confirmpassword)
        {

            // Kiểm tra đã tồn tại username nào hay chưa ?!
            Account signUpAccount = _context.Account.Where(a => a.Username == username).FirstOrDefault();
            if (signUpAccount == null)
            {
                if (password != confirmpassword)
                {
                    ViewBag.ConfirmPasswordError = "The password confirmation does not match";
                    return View();
                }

                Account newUserSignUp = new Account();
                newUserSignUp.Username = username;
                newUserSignUp.Password = password;
                newUserSignUp.Email = email;
                newUserSignUp.Phone = phone;
                newUserSignUp.Address = address;
                newUserSignUp.Fullname = fullname;
                newUserSignUp.IsAdmin = false;
                newUserSignUp.Avatar = "";
                newUserSignUp.Status = 1;
                _context.Account.Add(newUserSignUp);
                _context.SaveChanges();

                Account login = _context.Account.Where(a => a.Username == username).FirstOrDefault();
                CookieOptions cookieDate = new CookieOptions()
                {
                    Expires = DateTime.Now.AddDays(30)
                    //Expires = DateTime.UtcNow.AddMilliseconds(1500)
                };

                HttpContext.Response.Cookies.Append("AccountId", login.Id.ToString(), cookieDate);
                HttpContext.Response.Cookies.Append("AccountName", login.Fullname.ToString(), cookieDate);
                HttpContext.Response.Cookies.Append("AccountAvatar", login.Avatar.ToString(), cookieDate);
                return RedirectToAction("Index", "Home");
            }
            else
            {
                ViewBag.SignUpUsernameFailMessage = "Username has already been taken.";
                return View();
            }

        }

    }
}
