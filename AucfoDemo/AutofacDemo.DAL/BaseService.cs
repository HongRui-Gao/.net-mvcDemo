using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using AutofacDemo.IDAL;
using AutofacDemo.Model;

namespace AutofacDemo.DAL
{
    public class BaseService<T> : IBaseService<T> where T : BaseEntity, new()
    {
        private readonly BooksDb _db;

        public BaseService(BooksDb db)
        {
            _db = db;
        }
        public void Dispose()
        {
            _db.Dispose();
        }

        public async Task CreateAsync(T model, bool isSaved = true)
        {
            _db.Set<T>().Add(model);
            if (isSaved)
            {
                await _db.SaveChangesAsync();
            }
        }

        public async Task DeleteAsync(T model, bool isSaved = true)
        {
            _db.Configuration.ValidateOnSaveEnabled = false;
            _db.Entry(model).State = EntityState.Deleted;
            if (isSaved)
            {
                await _db.SaveChangesAsync();
                _db.Configuration.ValidateOnSaveEnabled = true;
            }
        }

        public async Task EditAsync(T model, bool isSaved = true)
        {
            _db.Configuration.ValidateOnSaveEnabled = false;
            _db.Entry(model).State = EntityState.Modified;
            if (isSaved)
            {
                await _db.SaveChangesAsync();
                _db.Configuration.ValidateOnSaveEnabled = true;
            }
        }

        public async Task Saves()
        {
            await _db.SaveChangesAsync();
            _db.Configuration.ValidateOnSaveEnabled = true;
        }

        public IQueryable<T> GetAll()
        {
            return _db.Set<T>();
        }

        public IQueryable<T> GetAllByTitle(Expression<Func<T, bool>> whereLambda)
        {
            return GetAll().Where(whereLambda);
        }

        public async Task<T> GetEntity(Guid id)
        {
            return await GetAll().FirstAsync(m => m.Id == id);
        }
    }
}
