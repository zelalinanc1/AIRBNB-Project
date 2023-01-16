using AİRBNB.Models;
using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace AİRBNB.ViewComponents
{
    public class CityList : ViewComponent
    {
        CityManager cm = new CityManager(new EfCityDal());
        public IViewComponentResult Invoke(int id)
        {
            var cityData = cm.TGetList();

            var model = new HomeViewModel();

            model.CityList = new List<SelectListItem>();

            model.CityList.Add(new SelectListItem { Text = "Şehir Seç", Value = "" });

            foreach (var city in cityData)
            {
                model.CityList.Add(new SelectListItem { Text = city.CityName, Value = Convert.ToString(city.CityId) });
            }

            ViewBag.Value = model.CityId;

        

            return View(model);

        }

    }
}
