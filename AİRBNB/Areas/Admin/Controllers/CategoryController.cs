using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace AİRBNB.Areas.Admin.Controllers
{
    //[AllowAnonymous]
    [Area("Admin")]
    public class CategoryController : Controller
    {
        CategoryManager cm = new CategoryManager(new EfCategoryDal());
        public IActionResult Index()
        {
            var values = cm.TGetList();

            return View(values);
        }
        [HttpGet]
        public IActionResult AddCategory()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddCategory(Category c)
        {
            CategoryValidator categoryValidator = new CategoryValidator();

            ValidationResult results = categoryValidator.Validate(c);

            if (results.IsValid)
            {
                c.CategoryStatus = true;
                cm.TAdd(c);
                return RedirectToAction("Index","Category");


            }
            else
            {
                foreach (var item in results.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }
            return View();
        }

        public IActionResult DeleteCategory(int id)
        {


            var value = cm.TGetById(id);

            cm.TDelete(value);

            return RedirectToAction("Index");

        }

        [HttpGet]
        public IActionResult UpdateCategory(int id)
        {
            var value = cm.TGetById(id);

            return View(value);
            


        }

        [HttpPost]
        public IActionResult UpdateCategory(Category c)
        {

            cm.TUpdate(c);

            return RedirectToAction("Index");

        }










    }
}
