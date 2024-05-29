using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Web_BLL.Abstract;
using Web_DAL.Abstract;
using Web_Entity.Models;

namespace Web_BLL.Concreate
{
    public class PlayerValuesManager : IPlayerValues_Service
    {
        private readonly IPlayerValues_DAL _DAL;
        public PlayerValuesManager(IPlayerValues_DAL DAL) 
        { _DAL = DAL; }
        public Task<Player_Values> AddAsync(Player_Values entity)
        {
            return _DAL.AddAsync(entity);
        }

        public Task DeleteAsync(Player_Values entity)
        {
            return _DAL.DeleteAsync(entity);
        }

        public int Deleted(Player_Values delete)
        {
            return _DAL.Deleted(delete);
        }

        public Player_Values Find(Expression<Func<Player_Values, bool>> fınd)
        {
            return _DAL.Find(fınd);
        }

        public Task<Player_Values> FindAsync(Expression<Func<Player_Values, bool>> findasync)
        {
            return _DAL.FindAsync(findasync);
        }

        public Player_Values Fınd(int fınd)
        {
            return _DAL.Fınd(fınd);
        }

        public List<Player_Values> getAll()
        {
            return _DAL.getAll();
        }

        public List<Player_Values> GetAll(Expression<Func<Player_Values, bool>> get)
        {
            return _DAL.GetAll(get);
        }

        public Player_Values getbyID(int get)
        {
            return _DAL.getbyID(get);
        }

        public Task<Player_Values> GetByIdAsync(int id)
        {
            return _DAL.GetByIdAsync(id);
        }

        public int Insert(Player_Values add)
        {
            return _DAL.Insert(add);
        }

        public Player_Values List(int list)
        {
            return _DAL.List(list);
        }

        public Task<List<Player_Values>> ListAsync()
        {
            return _DAL.ListAsync();
        }

        public List<Player_Values> Lıst(Expression<Func<Player_Values, bool>> list)
        {
            return _DAL.Lıst(list);
        }

        public int Update(Player_Values up)
        {
            return _DAL.Update(up);
        }

        public Task UpdateAsync(Player_Values entity)
        {
            return _DAL.UpdateAsync(entity);
        }
    }
}
