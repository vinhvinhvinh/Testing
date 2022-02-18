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
                //ViewBag.Email = HttpContext.Request.Cookies["AccountEmail"].ToString();
                ViewBag.Avatar = HttpContext.Request.Cookies["AccountAvatar"].ToString();
            }

            var ptype = _context.ProductType.ToList();
            ViewBag.AllType = ptype;
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
        public IActionResult Cake()
        {
            //Hiển thị thông tin đăng nhập
            if (HttpContext.Request.Cookies.ContainsKey("AccountName"))
            {
                ViewBag.Fullname = HttpContext.Request.Cookies["AccountName"].ToString();
                ViewBag.Email = HttpContext.Request.Cookies["AccountEmail"].ToString();
                ViewBag.Avatar = HttpContext.Request.Cookies["AccountAvatar"].ToString();
            }

            var Allprt = _context.Product.ToList();
            return View(Allprt);
        }
      
        [HttpPost]
        public IActionResult Login(string Username, string Password)
        {

            //----------Login with Cookie
            Account login = _context.Account.Where(a => a.Username == Username && a.Password == Password).FirstOrDefault();
           

            if (login != null)
            {
                CookieOptions cookieDate = new CookieOptions()
                {
                    Expires = DateTime.Now.AddDays(1)
                    //Expires = DateTime.UtcNow.AddMilliseconds(1500)
                };

                HttpContext.Response.Cookies.Append("AccountId", login.Id.ToString(), cookieDate);
                HttpContext.Response.Cookies.Append("AccountEmail", login.Email.ToString(), cookieDate);
                HttpContext.Response.Cookies.Append("AccountName", login.Fullname.ToString(), cookieDate);
                HttpContext.Response.Cookies.Append("AccountAvatar", login.Avatar.ToString(), cookieDate);

                //HttpContext.Session.SetInt32("AccountId", login.Id);

                if (!login.IsAdmin)
                {
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    return RedirectToAction("Dashboard", "Home");
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
            HttpContext.Response.Cookies.Append("AccountId", "", new CookieOptions { Expires = DateTime.Now.AddDays(-1) });
            HttpContext.Response.Cookies.Append("AccountName", "", new CookieOptions { Expires = DateTime.Now.AddDays(-1) });
            HttpContext.Response.Cookies.Append("AccountEmail", "", new CookieOptions { Expires = DateTime.Now.AddDays(-1) });
            HttpContext.Response.Cookies.Append("AccountAvatar", "", new CookieOptions { Expires = DateTime.Now.AddDays(-1) });
            return RedirectToAction("Index", "Home");

        }


        public IActionResult SignUp()
        {
            return View();
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
                HttpContext.Response.Cookies.Append("AccountEmail", login.Email.ToString(), cookieDate);
                HttpContext.Response.Cookies.Append("AccountAvatar", login.Avatar.ToString(), cookieDate);
                return RedirectToAction("Index", "Home");
            }
            else
            {
                ViewBag.SignUpUsernameFailMessage = "Username has already been taken.";
                return View();
            }

        }
        public IActionResult SearchResults(string keyword = "")
        {

            //Hiển thị thông tin đăng nhập
            if (HttpContext.Request.Cookies.ContainsKey("AccountName"))
            {
                ViewBag.Fullname = HttpContext.Request.Cookies["AccountName"].ToString();
                ViewBag.Email = HttpContext.Request.Cookies["AccountEmail"].ToString();
                ViewBag.Avatar = HttpContext.Request.Cookies["AccountAvatar"].ToString();
            }

            if (keyword == null)
            {
                keyword = "";
            }
            var productList = _context.Product.Where(prod => prod.Name.Contains(keyword) || prod.Description.Contains(keyword) || prod.ProductType.Name.Contains(keyword)).ToList();
            return View(productList);
        }

        public async Task<IActionResult> ProductByType(int? id)
        {

            //Hiển thị thông tin đăng nhập
            if (HttpContext.Request.Cookies.ContainsKey("AccountName"))
            {
                ViewBag.Fullname = HttpContext.Request.Cookies["AccountName"].ToString();
                ViewBag.Email = HttpContext.Request.Cookies["AccountEmail"].ToString();
                ViewBag.Avatar = HttpContext.Request.Cookies["AccountAvatar"].ToString();
            }

            //select sản phẩm theo loại
            var product =  _context.Product.Where(prod=>prod.ProductTypeId==id);
            if (product == null)
            {
                //nếu null thì cho ra thông báo
                ViewBag.NullProductType = "Blank Category, Please come back later, Thanks! ";
                return View();
            }

            ProductType productTypeName = _context.ProductType.Where(prod => prod.Id == id).First();


            ViewBag.ProdductByType_Name = productTypeName.Name.ToString();
            ViewBag.ProductByType = product;
            return View();
        }

       public IActionResult Dashboard()
        {
            if (HttpContext.Request.Cookies.ContainsKey("AccountName"))
            {
                ViewBag.Fullname = HttpContext.Request.Cookies["AccountName"].ToString();
                ViewBag.Avatar = HttpContext.Request.Cookies["AccountAvatar"].ToString();
                ViewBag.Email = HttpContext.Request.Cookies["AccountEmail"].ToString();

            }

            return View();
        }
        public IActionResult RemoveCart()
        {
            var accountId = HttpContext.Request.Cookies["AccountId"].ToString();
            List<Cart> carts = _context.Cart.Include(c => c.Account).Where(c => c.AccountId == Convert.ToInt32(accountId)).ToList();
            foreach(Cart c in carts)
            {
                _context.RemoveRange(c);
            }
            _context.SaveChanges();
            return RedirectToAction("Cart", "Home");
        }
        public IActionResult Cart()
        {
            var idaccount = HttpContext.Request.Cookies["AccountId"].ToString();
            if (_context.Cart.FirstOrDefault(c => c.AccountId == Convert.ToInt32(idaccount)) == null)
            {
                ViewBag.total =0;
            }
            else
            {
                ViewBag.total = (_context.Cart.Include(c => c.Account).Include(c => c.Product).Where(c => c.Account.Id == Convert.ToInt32(idaccount)).Sum(c
               => Convert.ToInt32(c.Quantity) * c.Product.Price));
            }    
            //HttpContext.Response.Cookies.Append("Account_ID", account.Account_ID.ToString());
            var cart = _context.Cart.Include(c => c.Account).Include(c => c.Product).Where(c => c.AccountId == Convert.ToInt32(idaccount));
            return View(cart);

        }
        public IActionResult Checkout()
        {
            var idaccount = HttpContext.Request.Cookies["AccountId"].ToString();
            ViewBag.total = (_context.Cart.Include(c => c.Account).Include(c => c.Product).Where(c => c.Account.Id == Convert.ToInt32(idaccount)).Sum(c
                 => Convert.ToInt32(c.Quantity) * c.Product.Price));
            var cart = _context.Cart.Include(c => c.Account).Include(c => c.Product).Where(c => c.AccountId == Convert.ToInt32(idaccount));
            return View(cart);
        }
        public IActionResult Pay()
        {
           
            DateTime date = DateTime.Now;
            var idaccount = HttpContext.Request.Cookies["AccountId"].ToString();
            var phoneAccount = _context.Account.FirstOrDefault(c => c.Id == Convert.ToInt32(idaccount)).Phone;
            var addAccount = _context.Account.FirstOrDefault(c => c.Id == Convert.ToInt32(idaccount)).Address;
            Invoice invoice = new Invoice();
            invoice.Code = "";
            invoice.IssuedDate = date;
            invoice.AccountId = Convert.ToInt32(idaccount);
            invoice.ShippingAddress = addAccount;
            invoice.ShippingPhone = phoneAccount;
            invoice.Total = (_context.Cart.Include(c => c.Account).Include(c => c.Product).Where(c => c.Account.Id == Convert.ToInt32(idaccount)).Sum(c 
                => Convert.ToInt32(c.Quantity) * c.Product.Price));
            _context.Add(invoice);
            _context.SaveChanges();
            //them chi tiet hoa don
            List<Cart> cart = _context.Cart.Include(c => c.Account).Include(c => c.Product).Where(c => c.Account.Id == Convert.ToInt32(idaccount)).ToList();
            foreach(Cart c in cart)
            {
                InvoiceDetail invoiceDetail = new InvoiceDetail();
                invoiceDetail.InvoiceId = invoice.Id;
                invoiceDetail.ProductId = c.ProductId;
                invoiceDetail.Quantity = c.Quantity;
                invoiceDetail.UnitPrice = _context.Product.FirstOrDefault(p => p.Id == c.ProductId).Price;
                _context.Add(invoiceDetail);
               
            }
            _context.SaveChanges();
            return RedirectToAction("RemoveCart", "Home"); 
        }
        public async Task<IActionResult> DeleteCartid(int id)
        {
            var cart = await _context.Cart.FindAsync(id);
            _context.Cart.Remove(cart);
            await _context.SaveChangesAsync();

            return RedirectToAction("Cart", "Home");
        }
    }
}
