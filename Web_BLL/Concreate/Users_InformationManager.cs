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
    public class Users_InformationManager : IUsers_InformationService
    {
        private readonly IUsers_Information_DAL _users_Information_DAL;

        public Users_InformationManager(IUsers_Information_DAL users_Information_DAL)
        {
            _users_Information_DAL = users_Information_DAL;
        }
        public Task<Users_İnformation> AddAsync(Users_İnformation entity)
        {
            return _users_Information_DAL.AddAsync(entity);
        }

        public Task DeleteAsync(Users_İnformation entity)
        {
            return _users_Information_DAL.DeleteAsync(entity);
        }

        public int Deleted(Users_İnformation delete)
        {
            return _users_Information_DAL.Deleted(delete);
        }

        public Users_İnformation Find(Expression<Func<Users_İnformation, bool>> fınd)
        {
            return _users_Information_DAL.Find(fınd);
        }

        public Task<Users_İnformation> FindAsync(Expression<Func<Users_İnformation, bool>> findasync)
        {
            return _users_Information_DAL.FindAsync(findasync);
        }

        public Users_İnformation Fınd(int fınd)
        {
            return _users_Information_DAL.Fınd(fınd);
        }

       

        public List<Users_İnformation> getAll()
        {
            return _users_Information_DAL.getAll();
        }

        public List<Users_İnformation> GetAll(Expression<Func<Users_İnformation, bool>> get)
        {
            return _users_Information_DAL.GetAll(get);
        }

        public Users_İnformation getbyID(int get)
        {
            return _users_Information_DAL.getbyID(get);
        }

        public Task<Users_İnformation> GetByIdAsync(int id)
        {
            return _users_Information_DAL.GetByIdAsync(id);
        }

        public int Insert(Users_İnformation add)
        {
            return _users_Information_DAL.Insert(add);
        }

        public Users_İnformation List(int list)
        {
            return _users_Information_DAL.List(list);
        }

        public Task<List<Users_İnformation>> ListAsync()
        {
            return _users_Information_DAL.ListAsync();
        }

        public List<Users_İnformation> Lıst(Expression<Func<Users_İnformation, bool>> list)
        {
            return _users_Information_DAL.Lıst(list);
        }

        public int Update(Users_İnformation up)
        {
            return _users_Information_DAL.Update(up);
        }

        public Task UpdateAsync(Users_İnformation entity)
        {
            return _users_Information_DAL.UpdateAsync(entity);
        }
    }
}
