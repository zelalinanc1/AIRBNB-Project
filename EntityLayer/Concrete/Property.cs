using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Property
    {

        [Key]
        public int PropertyId { get; set; }
        public string? PropertyName { get; set; }

        //public int HouseId { get; set; }
        //public House House { get; set; }

    }
}
