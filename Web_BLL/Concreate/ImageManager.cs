using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Web_BLL.Abstract;
using Web_DTO.Abstract;
using Web_Entity.Models;

namespace Web_BLL.Concreate
{
    public class ImageManager : IImageService
    {
        private readonly IImage_DAL _image;
        public ImageManager(IImage_DAL ımage)
        {
            _image = ımage;
        }
        public Task<Image> AddAsync(Image entity)
        {
            return _image.AddAsync(entity);
        }

        public Task DeleteAsync(Image entity)
        {
            return _image.DeleteAsync(entity);
        }

        public int Deleted(Image delete)
        {
            return _image.Deleted(delete);
        }

        public Image Find(Expression<Func<Image, bool>> fınd)
        {
            return _image.Find(fınd);
        }

        public Task<Image> FindAsync(Expression<Func<Image, bool>> findasync)
        {
            return _image.FindAsync(findasync);
        }

        public Image Fınd(int fınd)
        {
            return _image.Fınd(fınd);
        }

        

        public List<Image> getAll()
        {
            return _image.getAll();
        }

        public List<Image> GetAll(Expression<Func<Image, bool>> get)
        {
            return _image.GetAll(get);
        }

        public Image getbyID(int get)
        {
            return _image.getbyID(get);
        }

        public Task<Image> GetByIdAsync(int id)
        {
            return _image.GetByIdAsync(id);
        }

        public int Insert(Image add)
        {
            return _image.Insert(add);
        }

        public Image List(int list)
        {
            return _image.List(list);
        }

        public Task<List<Image>> ListAsync()
        {
            return _image.ListAsync();
        }

        public List<Image> Lıst(Expression<Func<Image, bool>> list)
        {
            return _image.Lıst(list);
        }

        public int Update(Image up)
        {
            return _image.Update(up);
        }

        public Task UpdateAsync(Image entity)
        {
            return _image.UpdateAsync(entity);
        }
    }
}
