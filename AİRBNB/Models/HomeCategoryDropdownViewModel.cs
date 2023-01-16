using Microsoft.AspNetCore.Mvc.Rendering;
namespace AİRBNB.Models
{
    public class HomeCategoryDropdownViewModel
    {
        public int CategoryId { get; set; }
        public List<SelectListItem> CategoryList { get; set; }
    }
}
