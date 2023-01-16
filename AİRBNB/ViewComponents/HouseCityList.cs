using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace AİRBNB.ViewComponents
{

    
    public class HouseCityList : ViewComponent
    {
        HouseManager houseManager = new HouseManager(new EfHouseDal());
        [HttpPost]
        public IViewComponentResult Invoke(int id)
        {
            var houseData = houseManager.TGetList();

            //int id = 1;


            //var values = houseManager.GetHouseByDetail();
            
            var valuee = houseManager.GetHouseByCity(id);

            return View(valuee);
        }
    }
}
