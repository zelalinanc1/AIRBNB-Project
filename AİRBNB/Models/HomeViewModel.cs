using Microsoft.AspNetCore.Mvc.Rendering;

namespace AİRBNB.Models
{
    public class HomeViewModel
    {
        
        public int CityId { get; set; }
        public List<SelectListItem> CityList { get; set; }

        public int CategoryId { get; set; }
        public List<SelectListItem> CategoryList { get; set; }
    }
}
