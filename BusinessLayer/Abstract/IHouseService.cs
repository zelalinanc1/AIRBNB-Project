using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IHouseService:IGenericService<House>
    {
        string GetCityInfo(int id);
        string GetCategoryInfo(int id);

        int GetHousePrice(int id);  

        List<House> GetListByCity(int id);
        List<House> GetListByCategory(int id);

        List<House> GetHouseByDetail();
        List<House> GetHouseById(int id);
        List<House> GetHouseByCity(int id);
        List<House> GetHouseByCityAndCategory(int cityid, int categoryid);
        

    }
}
