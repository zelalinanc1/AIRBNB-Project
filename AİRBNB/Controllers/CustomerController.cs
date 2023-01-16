using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace AİRBNB.Controllers
{
    public class CustomerController : Controller
    {
        CustomerManager cm = new CustomerManager(new EfCustomerDal());

        [Authorize]
        public IActionResult Index()
        {
           
            return View();
        }
    }
}
