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
    public class HouseManager : IHouseService
    {
        IHouseDal _houseDal;

        public HouseManager(IHouseDal houseDal)
        {
            _houseDal= houseDal;
        }

        public string GetCategoryInfo(int id)
        {
            return _houseDal.List(x => x.CategoryId == id).Select(y => y.Category.CategoryName).FirstOrDefault();
        }

        public string GetCityInfo(int id)
        {
           
          return _houseDal.List(x => x.CityId == id).Select(y => y.City.CityName).FirstOrDefault();
            
        }

        public List<House> GetHouseByCity(int id)
        {
            return _houseDal.GetHouseByCityDetail(id);
        }

        public List<House> GetHouseByCityAndCategory(int cityid, int categoryid)
        {
            return _houseDal.GetHouseByCityAndCategoryDetail(cityid, categoryid);
        }

        public List<House> GetHouseByDetail()
        {
            return _houseDal.GetHouseByDetail();
        }

        public List<House> GetHouseById(int id)
        {
            return _houseDal.List(x => x.HouseId == id);
        }

        public int GetHousePrice(int id)
        {
            return _houseDal.List(x => x.HouseId == id).Select(y => y.HousePrice).FirstOrDefault();
        }

        public List<House> GetListByCategory(int id)
        {
            return _houseDal.List(x => x.CategoryId == id);
        }

        public List<House> GetListByCity(int id)
        {
            return _houseDal.List(x => x.CityId == id);
        }

        public void TAdd(House t)
        {
            _houseDal.Insert(t);
        }

        public void TDelete(House t)
        {
            _houseDal.Delete(t);
        }

        public House TGetById(int id)
        {
            return _houseDal.Get(x => x.HouseId == id);
        }

        public List<House> TGetList()
        {
           return  _houseDal.GetList();
        }

        public void TUpdate(House t)
        {
            _houseDal.Update(t);
        }
    }
}
