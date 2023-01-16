using AİRBNB.Models;
using AİRBNB.Models;
using AİRBNB.Models.ViewModels;
using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Newtonsoft.Json;
using System.Diagnostics;

namespace AİRBNB.Controllers
{
    //[AllowAnonymous]
    public class HomeController : Controller
    {
       
        private readonly ILogger<HomeController> _logger;

        CityManager cm = new CityManager(new EfCityDal());

        CategoryManager ctm = new CategoryManager(new EfCategoryDal());

        HouseManager hm = new HouseManager(new EfHouseDal());

        ReservationManager rm = new ReservationManager(new EfReservationDal());

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
            
        }
        //[AllowAnonymous]
        public IActionResult Index()
        {
            
            
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

      
        public IActionResult GetHouse()
        {
            var values = hm.GetHouseByDetail();

            return View(values);
        }
      

        [HttpGet]
        public IActionResult SearchIndex()
        {
            var cityData = cm.TGetList();
            
            var model = new HomeViewModel();

            model.CityList = new List<SelectListItem>();
            model.CityList.Add(new SelectListItem { Text = "Şehir Seç", Value = "" });


            foreach (var city in cityData)
            {
                model.CityList.Add(new SelectListItem { Text = city.CityName, Value = Convert.ToString(city.CityId) });
            }
            var categoryData = ctm.TGetList();


            model.CategoryList = new List<SelectListItem>();


            model.CategoryList.Add(new SelectListItem { Text = "Kategori Seç", Value = "" });


            foreach (var category in categoryData)
            {
                model.CategoryList.Add(new SelectListItem { Text = category.CategoryName, Value = Convert.ToString(category.CategoryId) });
            }
           

            return View(model);

        }

        [HttpPost]
        public IActionResult SearchIndex(HomeViewModel model)
        {

            var cityData = cm.TGetList();

            var categoryData =ctm.TGetList();
           
            model.CityList = new List<SelectListItem>();
           
            model.CategoryList = new List<SelectListItem>();
           
            model.CityList.Add(new SelectListItem { Text = "Şehir Seç", Value = "" });

            model.CategoryList.Add(new SelectListItem { Text = "Kategori Seç", Value = "" });


            foreach (var category in categoryData)
            {
                model.CategoryList.Add(new SelectListItem { Text = category.CategoryName, Value = Convert.ToString(category.CategoryId) });
            }


            ViewBag.x = model.CategoryId;



            ViewBag.y = model.CategoryList.Where(x => x.Value == model.CategoryId.ToString()).FirstOrDefault().Text;



            foreach (var city in cityData)
            {
                model.CityList.Add(new SelectListItem { Text = city.CityName, Value = Convert.ToString(city.CityId) });
            }


            ViewBag.Value = model.CityId;

            ViewBag.Text = model.CityList.Where(x => x.Value == model.CityId.ToString()).FirstOrDefault().Text;

            return View(model);

           

        }


        public IActionResult CityDetails(int Cityid,int CategoryId)
        {
            

            var evdegerleri = hm.GetHouseByCityAndCategory(Cityid, CategoryId);


            return View(evdegerleri);
        }

       


        public PartialViewResult GetCountDateNumber()
        {
            return PartialView();
        }




    }
}