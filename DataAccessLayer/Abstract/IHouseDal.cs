using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface IHouseDal : IGenericDal<House>
    {
        List<House> GetHouseByDetail();
        List<House> GetHouseByCityDetail(int id);
        List<House> GetHouseByCityAndCategoryDetail(int cityid,int categoryid);
    }
}
