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
    public class ContactManager : IContect_Service
    {
        private readonly IContact_DAL _contact;
        public ContactManager(IContact_DAL contact)
        {
            _contact = contact;
        }
        public Task<Contact> AddAsync(Contact entity)
        {
            return _contact.AddAsync(entity);
        }

        public Task DeleteAsync(Contact entity)
        {
            return _contact.DeleteAsync(entity);
        }

        public int Deleted(Contact delete)
        {
            return _contact.Deleted(delete);
        }

        public Contact Find(Expression<Func<Contact, bool>> fınd)
        {
            return _contact.Find(fınd);
        }

        public Task<Contact> FindAsync(Expression<Func<Contact, bool>> findasync)
        {
            return _contact.FindAsync(findasync);
        }

        public Contact Fınd(int fınd)
        {
            return _contact.Fınd(fınd);
        }

        public List<Contact> getAll()
        {
            return _contact.getAll();
        }

        public List<Contact> GetAll(Expression<Func<Contact, bool>> get)
        {
            return _contact.GetAll(get);
        }

        public Contact getbyID(int get)
        {
            return _contact.getbyID(get);
        }

        public Task<Contact> GetByIdAsync(int id)
        {
            return _contact.GetByIdAsync(id);
        }

        public int Insert(Contact add)
        {
            return _contact.Insert(add);
        }

        public Contact List(int list)
        {
            return _contact.List(list);
        }

        public Task<List<Contact>> ListAsync()
        {
            return _contact.ListAsync();
        }

        public List<Contact> Lıst(Expression<Func<Contact, bool>> list)
        {
            return _contact.Lıst(list);
        }

        public int Update(Contact up)
        {
            return _contact.Update(up);
        }

        public Task UpdateAsync(Contact entity)
        {
            return _contact.UpdateAsync(entity);    
        }
    }
}
