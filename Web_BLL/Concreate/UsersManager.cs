﻿using System;
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
    public class UsersManager : IUsersService
    {
        private IUsers_DAL _users;
        public UsersManager(IUsers_DAL users)
        {
            _users = users;
        }
        public Task<Users> AddAsync(Users entity)
        {
            return _users.AddAsync(entity);
        }

        public Task DeleteAsync(Users entity)
        {
            return _users.DeleteAsync(entity);
        }

        public int Deleted(Users delete)
        {
            return _users.Deleted(delete);
        }

        public Users Find(Expression<Func<Users, bool>> fınd)
        {
            return _users.Find(fınd);
        }

        public Task<Users> FindAsync(Expression<Func<Users, bool>> findasync)
        {
            return _users.FindAsync(findasync);
        }

        public Users Fınd(int fınd)
        {
            return _users.Fınd(fınd);
        }

        public List<Users> getAll(Expression<Func<Users, bool>> getall)
        {
            return _users.getAll(getall);
        }

        public Users getbyID(int get)
        {
            return _users.getbyID(get);
        }

        public Task<Users> GetByIdAsync(int id)
        {
            return _users.GetByIdAsync(id);
        }

        public int Insert(Users add)
        {
            return _users.Insert(add);
        }

        public Users List(int list)
        {
            return _users.List(list);
        }

        public Task<List<Users>> ListAsync()
        {
            return _users.ListAsync();
        }

        public List<Users> Lıst(Expression<Func<Users, bool>> list)
        {
            return _users.Lıst(list);
        }

        public int Update(Users up)
        {
            return _users.Update(up);
        }

        public Task UpdateAsync(Users entity)
        {
            return _users.UpdateAsync(entity);
        }
    }
}
