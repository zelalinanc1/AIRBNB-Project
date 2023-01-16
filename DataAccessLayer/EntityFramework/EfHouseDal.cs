using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.Repository;
using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EntityFramework
{
    public class EfHouseDal : GenericRepository<House>, IHouseDal
    {
        public List<House> GetHouseByCityDetail(int id)
        {
            using (var c = new Context())
            {
                return c.Houses.Include(x => x.Category).Include(x => x.City).Where(x => x.CityId == id).ToList();
            }
        }
        public List<House> GetHouseByCityAndCategoryDetail(int cityId, int categoryId)
        {
            using (var c = new Context())
            {
                return c.Houses.Include(x => x.Category).Include(x => x.City).Where(x => x.CityId == cityId && x.CategoryId == categoryId).ToList();
            }
        }
        public List<House> GetHouseByDetail()
        {
            using (var c =new Context())
            {
                return c.Houses.Include(x => x.Category).Include(x=>x.City).ToList();
            }
        }
    }
}
