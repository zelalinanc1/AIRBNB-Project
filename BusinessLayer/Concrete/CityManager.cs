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
    public class CityManager : ICityService
    {
        ICityDal _cityDal;

        public CityManager(ICityDal cityDal)
        {
            _cityDal = cityDal;
        }

        public List<City> GetCityById(int id)
        {
            return _cityDal.List(x => x.CityId == id);
        }

        public void TAdd(City t)
        {
            _cityDal.Insert(t);
        }

        public void TDelete(City t)
        {
            _cityDal.Delete(t);
        }

        public City TGetById(int id)
        {
            return _cityDal.Get(x => x.CityId == id);
        }

        public List<City> TGetList()
        {
            return _cityDal.GetList();
        }

        public void TUpdate(City t)
        {
            _cityDal.Update(t);
        }
    }
}
