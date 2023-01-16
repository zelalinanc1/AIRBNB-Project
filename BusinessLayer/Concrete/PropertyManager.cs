using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class PropertyManager:IPropertyService
    {
        IPropertyDal _propertyDal;

        public PropertyManager(IPropertyDal propertyDal)
        {
            _propertyDal = propertyDal;
        }

        public void TAdd(Property t)
        {
            _propertyDal.Insert(t);
        }

        public void TDelete(Property t)
        {
            _propertyDal.Delete(t);
        }

        public Property TGetById(int id)
        {
            return _propertyDal.Get(x => x.PropertyId == id);
        }

        public List<Property> TGetList()
        {
            return _propertyDal.GetList();
        }

        public void TUpdate(Property t)
        {
            _propertyDal.Update(t);
        }




    }
}
