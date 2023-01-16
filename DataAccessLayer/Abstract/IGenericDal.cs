using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface IGenericDal<T>
    {
        List<T> GetList();
        List<T> List(Expression<Func<T, bool>> filter);

        T Get(Expression<Func<T, bool>> filter);

        void Insert(T t);
        void Delete(T t);
        void Update(T t);
        






    }
}
