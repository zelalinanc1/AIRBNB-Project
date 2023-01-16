using EntityLayer.Concrete;

namespace AİRBNB.Models.ViewModels
{
    public class HouseListModel
    {
        public House HouseDetail;

        public List<House> HouseList;

        public string CityName { get; set; }
    }
}
