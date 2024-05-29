using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Web_DTO.RepoStory
{
    public interface IRepoStory<T> where T : class
    {
        T getbyID(int get);
        T List(int list);
        T Fınd(int fınd);
        int Insert(T add);
        int Update(T up);
        int Deleted(T delete);
<<<<<<< HEAD
        List<T> getAll();
        List<T> GetAll(Expression<Func<T, bool>> get);
=======
        List<T> getAll(Expression<Func<T, bool>> getall);
>>>>>>> 1058286ea13219f1c102be35469122af732c2ddb
        List<T> Lıst(Expression<Func<T, bool>> list);
        T Find(Expression<Func<T, bool>> fınd);

        Task<T> GetByIdAsync(int id);
        Task<List<T>> ListAsync();
        Task<T> AddAsync(T entity);
        Task UpdateAsync(T entity);
        Task DeleteAsync(T entity);
        Task<T> FindAsync(Expression<Func<T, bool>> findasync);
    }
}
