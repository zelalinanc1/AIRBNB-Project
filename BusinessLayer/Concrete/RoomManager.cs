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
    public class RoomManager : IRoomService
    {
        IRoomDal _roomDal;

        public RoomManager(IRoomDal roomDal)
        {
            _roomDal = roomDal; 
        }

        public void TAdd(Room t)
        {
            _roomDal.Insert(t);
        }

        public void TDelete(Room t)
        {
            _roomDal.Delete(t);
        }

        public Room TGetById(int id)
        {
            return _roomDal.Get(x => x.RoomId == id);
        }

        public List<Room> TGetList()
        {
            return _roomDal.GetList();
        }

        public void TUpdate(Room t)
        {
            _roomDal.Update(t);
        }
    }
}
