using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace AİRBNB.ViewComponents
{
    public class HouseList:ViewComponent
    {
        HouseManager hm = new HouseManager(new EfHouseDal());
        public IViewComponentResult Invoke(int id)
        {
            ViewBag.deger1 = id;

            var values = hm.GetHouseByDetail();

            return View(values);
          
        }



    }
}
