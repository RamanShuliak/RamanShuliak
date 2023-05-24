using ASP.NET.MVC_Exprtiment.Core;
using ASP.NET.MVC_Exprtiment.DataBase.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ASP.NET.MVC_Exprtiment.Data.Abstractions.Repositories
{
    public interface IRepository<T> where T : class, IBaseEntity
    {
        // Read
        Task<T?> GetByIdAsync(Guid id);
        Task<IEnumerable<T>> GetAllAsync();
        IQueryable<T> Get();

        IQueryable<T> FindBy(Expression<Func<T, bool>> searchExpression,
            params Expression<Func<T, object>>[] includes);

        // Create
        Task AddAsync(T entity);
        Task AddRangeAsync(IEnumerable<T> entities);

        // Update
        void Update (T entity);
        Task PathAsync (Guid id, List<PatchModel> pathData);

        // Delete
        void Remove(T entity);
    }
}
