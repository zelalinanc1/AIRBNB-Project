using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class House
    {
        [Key]
        public int HouseId { get; set; }    
        public string HouseDescription { get; set; }    
        public string HouseImage1 { get; set; }    
        public string HouseImage2 { get; set; }    
        public string HouseImage3 { get; set; }    
        public string HouseImage4 { get; set; }    
       
       
        public string? HouseProperty { get; set; }    
        public int HousePrice { get; set; }    
        public int HouseRoomNumbers { get; set; }

        public bool Status { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }

        public int CityId { get; set; }
        public City City { get; set; }

        public List<Room> Rooms { get; set; }

        //public List<Property> Properties { get; set; }
    }
}
