using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace AİRBNB.Controllers
{
    [AllowAnonymous]
    public class LoginController : Controller
    {
        CustomerManager cm = new CustomerManager(new EfCustomerDal());


        [HttpGet]
        public IActionResult SignUp()
        {
            return View();
        }

        [HttpPost]
        public IActionResult SignUp(Customer p)
        {
           

            cm.TAdd(p);

            return RedirectToAction("SignIn","Login");
        }




        [HttpGet]
        public IActionResult SignIn()
        {
            return View();
        }

        [HttpPost]
        public async Task< IActionResult> SignIn(Customer customer)
        {
            var result = cm.GetCustomer(customer.CustomerEmail, customer.CustomerPassword);

            if(result != null)
            {
                var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.Name,customer.CustomerEmail)
                };

                var useridentity = new ClaimsIdentity(claims, "a");

                ClaimsPrincipal principal= new ClaimsPrincipal(useridentity);

                await HttpContext.SignInAsync(principal);


                return RedirectToAction("Index", "Home");
            }
            else
            {
                return View();
            }


            //var result = cm.GetCustomer(customer.CustomerEmail, customer.CustomerPassword);

            //if (result != null)
            //{
            //    HttpContext.Session.SetString("CustomerFirstName", customer.CustomerEmail);

            //    return RedirectToAction("Index", "Home");
            //}
            //else
            //{
            //    return View();
            //}



        }

    }
}
