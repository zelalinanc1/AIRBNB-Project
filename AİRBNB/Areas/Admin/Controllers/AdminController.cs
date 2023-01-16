using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace AİRBNB.Areas.Admin.Controllers
{
    [AllowAnonymous]
    public class AdminController : Controller
    {
        //[Area("Admin")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
