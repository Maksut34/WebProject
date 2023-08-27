using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Web_BLL.Abstract;
using Web_DTO.Abstract;
using Web_DTO.Data;
using Web_DTO.RepoStory;
using Web_Entity.Models;

namespace Web_BLL.Concreate
{
    public class AddStoryManeger : IAddStoryService
    {
        private readonly IAddStory_DAL _story;
        public AddStoryManeger(IAddStory_DAL story)
        {
            _story = story;
        }
        public Task<AddStory> AddAsync(AddStory entity)
        {
            return _story.AddAsync(entity);
        }

        public Task DeleteAsync(AddStory entity)
        {
            return _story.DeleteAsync(entity);
        }

        public int Deleted(AddStory delete)
        {
            return _story.Deleted(delete);
        }

        public AddStory Find(Expression<Func<AddStory, bool>> fınd)
        {
            return _story.Find(fınd);
        }

        public Task<AddStory> FindAsync(Expression<Func<AddStory, bool>> findasync)
        {
            return _story.FindAsync(findasync);
        }

        public AddStory Fınd(int fınd)
        {
            return _story.Fınd(fınd);
        }

        public List<AddStory> getAll()
        {
            return _story.getAll();
        }

        public List<AddStory> GetAll(Expression<Func<AddStory, bool>> get)
        {
            return _story.GetAll(get);
        }

        public AddStory getbyID(int get)
        {
            return _story.getbyID(get);
        }

        public Task<AddStory> GetByIdAsync(int id)
        {
            return _story.GetByIdAsync(id);
        }

        public int Insert(AddStory add)
        {
            return _story.Insert(add);
        }

        public AddStory List(int list)
        {
            return _story.List(list);
        }

        public Task<List<AddStory>> ListAsync()
        {
            return _story.ListAsync();
        }

        public List<AddStory> Lıst(Expression<Func<AddStory, bool>> list)
        {
            return _story.Lıst(list);
        }

        public int Update(AddStory up)
        {
            return _story.Update(up);   
        }

        public Task UpdateAsync(AddStory entity)
        {
            return _story.UpdateAsync(entity);
        }
    }
}
