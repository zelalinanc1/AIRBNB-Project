using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class ReservationManager : IReservationService
    {
        IReservationDal _reservationDal;

        public ReservationManager(IReservationDal reservationDal)
        {
            _reservationDal = reservationDal;
        }

        public int GetCustomerInfo(int id)
        {
            return _reservationDal.List(x => x.CustomerId == id).Select(y => y.Customer.CustomerId).FirstOrDefault();
        }

      

        public int GetHouseInfo(int id)
        {
            return _reservationDal.List(x => x.HouseId == id).Select(y => y.House.HouseId).FirstOrDefault();
        }

        public List<Reservation> GetReservationByDetail()
        {
            return _reservationDal.GetReservationByDetail();
        }

        public void TAdd(Reservation t)
        {
            _reservationDal.Insert(t);
        }

        public void TDelete(Reservation t)
        {
            _reservationDal.Delete(t);
        }

        public Reservation TGetById(int id)
        {
            return _reservationDal.Get(x => x.ReservationId == id);
        }

        public List<Reservation> TGetList()
        {
            return _reservationDal.GetList();
        }

        public void TUpdate(Reservation t)
        {
            _reservationDal.Update(t);
        }
    }
}
