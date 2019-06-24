using AutofacDemo.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace AutofacDemo.IDAL
{
    public interface IBaseService<T> : IDisposable where T:BaseEntity,new()
    {
        Task CreateAsync(T model, bool isSaved=true);
        Task DeleteAsync(T model, bool isSaved = true);
        Task EditAsync(T model, bool isSaved = true);

        Task Saves();

        IQueryable<T> GetAll();

        IQueryable<T> GetAllByTitle(Expression<Func<T,bool>> whereLambda);

        Task<T> GetEntity(Guid id);

    }
}
