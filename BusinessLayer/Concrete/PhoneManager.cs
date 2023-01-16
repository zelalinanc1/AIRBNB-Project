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
    public class PhoneManager : IPhoneService
    {
        IPhoneDal _phoneDal;

        public PhoneManager(IPhoneDal phoneDal)
        {
            _phoneDal = phoneDal;
        }
    
        public void TAdd(Phone t)
        {
            _phoneDal.Insert(t);
        }

        public void TDelete(Phone t)
        {
            _phoneDal.Delete(t);
        }

        public Phone TGetById(int id)
        {
            return _phoneDal.Get(x => x.PhoneId == id);
        }

        public List<Phone> TGetList()
        {
            return _phoneDal.GetList(); 
        }

        public void TUpdate(Phone t)
        {
            _phoneDal.Update(t);
        }
    }
}
