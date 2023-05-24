using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using ASP.NET.MVC_Exprtiment.Core;
using ASP.NET.MVC_Exprtiment.Data.Abstractions;
using ASP.NET.MVC_Exprtiment.Data.Abstractions.Repositories;
using ASP.NET.MVC_Exprtiment.DataBase;
using ASP.NET.MVC_Exprtiment.DataBase.Entities;
using Microsoft.EntityFrameworkCore;

namespace ASP.NET.MVC_Exprtiment.Data.Repositories
{
    public class Repository<T> : IRepository<T> where T : class, IBaseEntity
    {
        private readonly MusicBandsContext DataBase;
        private readonly DbSet<T> DbSet;

        public Repository(MusicBandsContext dataBase)
        {
            DataBase = dataBase;
            DbSet = dataBase.Set<T>();
        }

        public virtual async Task<T?> GetByIdAsync(Guid id)
        {
            var entity = await DbSet
                .AsNoTracking()
                .FirstOrDefaultAsync(entity => entity.Id.Equals(id));

            return entity;
        }

        public virtual async Task<IEnumerable<T?>> GetAllAsync()
        {
            return await DbSet
                .AsNoTracking()
                .ToListAsync();
        }

        public virtual IQueryable<T> Get()
        {
            return DbSet.AsQueryable();
        }

        public virtual IQueryable<T> FindBy (Expression<Func<T, bool>> searchExpression,
            params Expression<Func<T, object>>[] includes)
        {
            var result = DbSet.Where(searchExpression);

            if (includes.Any())
            {
                result = includes
                    .Aggregate(result, (current, include) => current.Include(include));
            }

            return result;
        }

        public virtual async Task AddAsync(T entity)
        {
            await DbSet.AddAsync(entity);
        }

        public virtual async Task AddRangeAsync(IEnumerable<T> entities)
        {
            await DbSet.AddRangeAsync(entities);
        }

        public virtual void Update(T entity)
        {
            DbSet.Update(entity);
        }

        public virtual async Task PathAsync(Guid id, List<PatchModel> pathData)
        {
            var model = await DbSet.FirstOrDefaultAsync(entity => entity.Id.Equals(id));

            var nameValuePropertyPairs = pathData
                .ToDictionary(
                pathModel => pathModel.PropertyName,
                pathModel => pathModel.PropertyValue);

            var dbEntityEntry = DataBase.Entry(model);
            dbEntityEntry.CurrentValues.SetValues(nameValuePropertyPairs);
            dbEntityEntry.State = EntityState.Modified;
        }

        public virtual void Remove(T entity)
        {
            DbSet.Remove(entity);
        }
    }
}
