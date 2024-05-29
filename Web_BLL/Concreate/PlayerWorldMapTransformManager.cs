using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Web_BLL.Abstract;
using Web_DAL.Abstract;
using Web_DTO.Abstract;
using Web_Entity.Models;

namespace Web_BLL.Concreate
{
    public class PlayerWorldMapTransformManager : IPlayerWorldMapTransformService
    {
        private readonly IPlayerWorldMapTransform_DAL _playerWorldMapTransformdal;
        public PlayerWorldMapTransformManager(IPlayerWorldMapTransform_DAL playerWorldMapTransformdal)
        {
            _playerWorldMapTransformdal = playerWorldMapTransformdal;
        }
        public Task<PlayerWorldMapTransform> AddAsync(PlayerWorldMapTransform entity)
        {
            return _playerWorldMapTransformdal.AddAsync(entity);
        }

        public Task DeleteAsync(PlayerWorldMapTransform entity)
        {
            return _playerWorldMapTransformdal.DeleteAsync(entity);
        }

        public int Deleted(PlayerWorldMapTransform delete)
        {
            return _playerWorldMapTransformdal.Deleted(delete);
        }

        public PlayerWorldMapTransform Find(Expression<Func<PlayerWorldMapTransform, bool>> fınd)
        {
            return _playerWorldMapTransformdal.Find(fınd);
        }

        public Task<PlayerWorldMapTransform> FindAsync(Expression<Func<PlayerWorldMapTransform, bool>> findasync)
        {
            return _playerWorldMapTransformdal.FindAsync(findasync);
        }

        public PlayerWorldMapTransform Fınd(int fınd)
        {
            return _playerWorldMapTransformdal.Fınd(fınd);
        }

        public List<PlayerWorldMapTransform> getAll()
        {
            return _playerWorldMapTransformdal.getAll();
        }

        public List<PlayerWorldMapTransform> GetAll(Expression<Func<PlayerWorldMapTransform, bool>> get)
        {
            return _playerWorldMapTransformdal.GetAll(get);
        }

        public PlayerWorldMapTransform getbyID(int get)
        {
            return _playerWorldMapTransformdal.getbyID(get);
        }

        public Task<PlayerWorldMapTransform> GetByIdAsync(int id)
        {
            return _playerWorldMapTransformdal.GetByIdAsync(id);
        }

        public int Insert(PlayerWorldMapTransform add)
        {
            return _playerWorldMapTransformdal.Insert(add);
        }

        public PlayerWorldMapTransform List(int list)
        {
            return _playerWorldMapTransformdal.List(list);
        }

        public Task<List<PlayerWorldMapTransform>> ListAsync()
        {
            return _playerWorldMapTransformdal.ListAsync();
        }

        public List<PlayerWorldMapTransform> Lıst(Expression<Func<PlayerWorldMapTransform, bool>> list)
        {
            return _playerWorldMapTransformdal.Lıst(list);
        }

        public int Update(PlayerWorldMapTransform up)
        {
            return _playerWorldMapTransformdal.Update(up);
        }

        public Task UpdateAsync(PlayerWorldMapTransform entity)
        {
            return _playerWorldMapTransformdal.UpdateAsync(entity);
        }
    }
}
