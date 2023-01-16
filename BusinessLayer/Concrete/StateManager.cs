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
    public class StateManager : IStateService
    {
        IStateDal _stateDal;

        public StateManager(IStateDal stateDal)
        {
            _stateDal = stateDal;
        }
    
        public void TAdd(State t)
        {
            _stateDal.Insert(t);
        }

        public void TDelete(State t)
        {
            _stateDal.Delete(t);
        }

        public State TGetById(int id)
        {
            return _stateDal.Get(x => x.StateId == id);
        }

        public List<State> TGetList()
        {
            return _stateDal.GetList();
        }

        public void TUpdate(State t)
        {
            _stateDal.Update(t);
        }
    }
}
