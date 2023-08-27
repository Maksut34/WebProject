using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Web_DTO.RepoStory
{
    public class RepoStory<T,TContext>:IRepoStory<T> where T : class where TContext:DbContext ,new()
    {
        public int Deleted(T delete)
        {
            using (var context = new TContext())
            {
                context.Set<T>().Remove(delete);
                return context.SaveChanges();
            }
        }

        public T Fınd(int fınd)
        {
            using (var context = new TContext())
            {
                return context.Set<T>().Find(fınd);
            }
        }



        public List<T> getAll(Expression<Func<T, bool>> getall)
        {
            using (var context = new TContext())
            {
                return context.Set<T>().Where(getall).ToList();
            }
        }

        public T getbyID(int get)
        {
            using (var context = new TContext())
            {
                return context.Set<T>().Find(get);
            }
        }

        public int Insert(T add)
        {
            using (var context = new TContext())
            {
                context.Set<T>().Add(add);
                return context.SaveChanges();
            }
        }

        public T List(int list)
        {
            using (var context = new TContext())
            {
                return context.Set<T>().Find(list);
            }
        }

        public List<T> Lıst(Expression<Func<T, bool>> list)
        {
            using (var context = new TContext())
            {
                return context.Set<T>().Where(list).ToList();
            }
        }

        public int Update(T up)
        {
            using (var context = new TContext())
            {
                context.Set<T>().Update(up);
                //context.Entry(obj).State = EntityState.Modified;
                return context.SaveChanges();

            }
        }

        public T Find(Expression<Func<T, bool>> fınd)
        {
            using (var context = new TContext())
            {
                return context.Set<T>().FirstOrDefault(fınd);
            }
        }

        public async Task<T> GetByIdAsync(int id)
        {
            using (var context = new TContext())
            {
                return await context.Set<T>().FindAsync(id);
            }
        }

        public async Task<List<T>> ListAsync()
        {
            using (var context = new TContext())
            {
                return await context.Set<T>().ToListAsync();
            }
        }

        public async Task<T> AddAsync(T entity)
        {
            using (var context = new TContext())
            {
                await context.Set<T>().AddAsync(entity);
                await context.SaveChangesAsync();
                return entity;
            }
        }

        public async Task UpdateAsync(T entity)
        {
            using (var context = new TContext())
            {
                context.Set<T>().Update(entity);
                await context.SaveChangesAsync();
            }
        }

        public async Task DeleteAsync(T entity)
        {
            using (var context = new TContext())
            {
                context.Set<T>().Remove(entity);
                await context.SaveChangesAsync();
            }
        }
        private readonly TContext _context;

        public RepoStory()
        {
            _context = new TContext();
        }

        public async Task<T> FindAsync(Expression<Func<T, bool>> predicate)
        {
            return await _context.Set<T>().FirstOrDefaultAsync(predicate);
        }
        //public void Dispose()
        //{
        //    _context.Dispose();
        //}
    }
}
