using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IReservationService : IGenericService<Reservation>
    {
        int GetHouseInfo(int id);
        int GetCustomerInfo(int id);
        

        List<Reservation> GetReservationByDetail();
    }
}
