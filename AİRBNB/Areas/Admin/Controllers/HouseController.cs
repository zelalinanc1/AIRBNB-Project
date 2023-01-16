using AİRBNB.Models;
using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Data.SqlClient;

namespace AİRBNB.Areas.Admin.Controllers
{
    //[AllowAnonymous]
    [Area("Admin")]
    public class HouseController : Controller
    {

        HouseManager hm = new HouseManager(new EfHouseDal());

        CategoryManager ctm = new CategoryManager(new EfCategoryDal());

        CityManager cm = new CityManager(new EfCityDal());

        PropertyManager pm = new PropertyManager(new EfPropertyDal());

       

        public IActionResult Index()
        {
            var values = hm.TGetList();

            return View(values);
        }
       
        public IActionResult Deneme()
        {
            return View();
        }

        [HttpGet]
        public IActionResult AddHouse()
        {
            List<SelectListItem> valuecategory = (from x in ctm.TGetList()
                                               select new SelectListItem
                                               {
                                                   Text = x.CategoryName,
                                                   Value = x.CategoryId.ToString()
                                               }).ToList();
            ViewBag.v = valuecategory;

            List<SelectListItem> valuecity = (from x in cm.TGetList()
                                                 select new SelectListItem
                                                 {
                                                     Text = x.CityName,
                                                     Value = x.CityId.ToString()



                                                 }).ToList();
            ViewBag.vlc = valuecity;




            return View();
        }
        [HttpPost]
        public IActionResult AddHouse(AddHouseImage p)
        {
            House h = new House();

            if(p.HouseImage1!= null && p.HouseImage2 != null && p.HouseImage3 != null && p.HouseImage4 != null)
            {
                var extension = Path.GetExtension(p.HouseImage1.FileName);
                var newimagename = Guid.NewGuid() + extension;
                var location = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/HouseImageFiles/",newimagename);
                var stream = new FileStream(location,FileMode.Create);
                p.HouseImage1.CopyTo(stream);
                h.HouseImage1 = newimagename;

                var extension1 = Path.GetExtension(p.HouseImage2.FileName);
                var newimagename1 = Guid.NewGuid() + extension1;
                var location1 = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/HouseImageFiles/", newimagename1);
                var stream1 = new FileStream(location1, FileMode.Create);
                p.HouseImage2.CopyTo(stream1);
                h.HouseImage2 = newimagename1;

                var extension2 = Path.GetExtension(p.HouseImage3.FileName);
                var newimagename2 = Guid.NewGuid() + extension2;
                var location2 = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/HouseImageFiles/", newimagename2);
                var stream2 = new FileStream(location2, FileMode.Create);
                p.HouseImage3.CopyTo(stream2);
                h.HouseImage3 = newimagename2;

                var extension3 = Path.GetExtension(p.HouseImage4.FileName);
                var newimagename3 = Guid.NewGuid() + extension3;
                var location3 = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/HouseImageFiles/", newimagename3);
                var stream3 = new FileStream(location3, FileMode.Create);
                p.HouseImage4.CopyTo(stream3);
                h.HouseImage4 = newimagename3;

            }
            h.HouseDescription = p.HouseDescription;


            h.HouseProperty = p.HouseProperty;

            h.HousePrice = p.HousePrice;

            h.HouseRoomNumbers = p.HouseRoomNumbers;

            h.CategoryId = p.CategoryId;

            h.CityId = p.CityId;

           // h.Rooms = p.Rooms;

            hm.TAdd(h);

            return RedirectToAction("Index");

        }

        [HttpPost]
        public IActionResult AddHouseProperty(Property property)
        {
            pm.TAdd(property);

            var jsonProperties = JsonConvert.SerializeObject(property);



            return Json(jsonProperties);
        }









    }
}
