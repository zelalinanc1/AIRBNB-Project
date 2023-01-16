using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace AİRBNB.Controllers
{
    public class HouseController : Controller
    {
       HouseManager hm = new HouseManager(new EfHouseDal());

        CustomerManager cm = new CustomerManager(new EfCustomerDal());
        public IActionResult HouseDetails(int id)
        {
           

           

            var usermail = User.Identity.Name;

            ViewBag.v = usermail;

            var customerId = cm.GetCustomerInfo(usermail);

            ViewBag.deger2 = customerId;


            ViewBag.deger1 = id;

            var values = hm.GetHouseById(id);

            var priceInfo = hm.GetHousePrice(id);

            ViewBag.price = priceInfo;


            return View(values);
            
        }
    }
}
