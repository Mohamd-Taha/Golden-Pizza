using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1.Repositories
{
    public class GenericRepository<TEntity> : IGenericRepository<TEntity> where TEntity : class
    {
        public DataContext _Context { get; }
        public GenericRepository(DataContext Context)
        {
            _Context = Context;
        }
        public async Task<TEntity> Add(TEntity entity)
        {
            _Context.Set<TEntity>().Add(entity);
            await _Context.SaveChangesAsync();
            return entity;
        }

        public async Task<TEntity> Delete(int id)
        {
            TEntity entity = await GetById(id);
            _Context.Set<TEntity>().Remove(entity);
            await _Context.SaveChangesAsync();
            return entity;
        }

        public IQueryable<TEntity> GetAll()
        {
            return _Context.Set<TEntity>();
        }

        public async Task<TEntity> GetById(int id)
        {
            TEntity entity = await _Context.Set<TEntity>().FindAsync(id);
            if (entity != null)
            {
                return entity;
            }
            return null;
        }

        //public async Task<TEntity> Update(TEntity entity)
        //{
        //    _Context.Update(entity);
        //    await _Context.SaveChangesAsync();
        //    return entity;
        //}
    }
}
