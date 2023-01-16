using EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;

namespace AİRBNB.Models
{
    public class AddHouseImage
    {
        public int HouseId { get; set; }
        public string HouseDescription { get; set; }

        public string? HouseProperty { get; set; }
        public IFormFile HouseImage1 { get; set; }
        public IFormFile HouseImage2 { get; set; }
        public IFormFile HouseImage3 { get; set; }
        public IFormFile HouseImage4 { get; set; }
        public int HousePrice { get; set; }
        public int HouseRoomNumbers { get; set; }

        public int CategoryId { get; set; }
        public Category Category { get; set; }

        public int CityId { get; set; }
        public City City { get; set; }

        public List<Room> Rooms { get; set; }
    }
}
