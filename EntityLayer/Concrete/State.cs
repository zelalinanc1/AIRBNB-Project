using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class State
    {
        [Key]
        public int StateId { get; set; }

        public string StateName { get; set; }

        public int CityId { get; set; }
        public City City { get; set; }
    }
}
