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
    public class CustomerManager : ICustomerService
    {
        ICustomerDal _customerDal;

        public CustomerManager(ICustomerDal customerDal)
        {
            _customerDal = customerDal;
        }

        
        public Customer GetCustomer(string email, string password)
        {
            return _customerDal.Get(x => x.CustomerEmail == email && x.CustomerPassword == password);
        }

        public int GetCustomerInfo(string email)
        {
            return _customerDal.List(x => x.CustomerEmail == email).Select(y => y.CustomerId).FirstOrDefault();
        }

        public void TAdd(Customer t)
        {
            _customerDal.Insert(t); 
        }

        public void TDelete(Customer t)
        {
            _customerDal.Delete(t);
        }

        public Customer TGetById(int id)
        {
            return _customerDal.Get(x => x.CustomerId == id);
        }

        public List<Customer> TGetList()
        {
            return _customerDal.GetList();  
        }

        public void TUpdate(Customer t)
        {
            _customerDal.Update(t);
        }
    }
}
