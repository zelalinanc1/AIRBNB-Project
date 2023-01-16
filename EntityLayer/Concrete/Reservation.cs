using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Reservation
    {
        [Key]
        public int ReservationId { get; set; }

        public int CustomerId { get; set; }

        public Customer Customer { get; set; }

        public int HouseId { get; set; }

        public House House { get; set; }

        public DateTime ReservationDate { get; set; }

        public DateTime ReservationEndDate { get; set; }

        public string Status { get; set; }
        public string PersonCount { get; set; }


    }
}
