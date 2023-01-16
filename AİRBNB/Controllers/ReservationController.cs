using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace AİRBNB.Controllers
{
    [AllowAnonymous]
    public class ReservationController : Controller
    {
        ReservationManager rm = new ReservationManager(new EfReservationDal());

       CustomerManager cm = new CustomerManager(new EfCustomerDal());
       HouseManager hm = new HouseManager(new EfHouseDal());


        public IActionResult Index()
        {
            return View();
        }

        

        [HttpGet]
        public IActionResult AddReservations(int id)
        {
            ViewBag.deger1 = id;

            var usermail = User.Identity.Name;

            ViewBag.v = usermail;

            var customerId = cm.GetCustomerInfo(usermail);

            ViewBag.deger2 = customerId;


            return View();

        }

        [HttpPost]
        public IActionResult AddReservations(Reservation reservation)
        {

            reservation.Status = "True";


            rm.TAdd(reservation);

            return View();

        }







    }
}
