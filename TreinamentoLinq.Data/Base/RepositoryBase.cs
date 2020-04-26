using Microsoft.EntityFrameworkCore; 
using System.Collections.Generic;
using TreinamentoLinq.Domain.Base;

namespace TreinamentoLinq.Data.Base
{
    public class RepositoryBase<T> : IRepositoryBase<T> where T : Entity
    {
        protected readonly TreinamentoContext _context;
        private readonly DbSet<T> _dbSet;

        public RepositoryBase(TreinamentoContext context)
        {
            this._context = context;
            this._context.ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking;
            this._dbSet = this._context.Set<T>();
        }

        public IEnumerable<T> GetAll()
        {
            return this._dbSet;
        }

        public T Get(params object[] keyValues)
        {
            return this._dbSet.Find(keyValues);
        }

        public T Save(T entity)
        {
            this._dbSet.Add(entity);
            this.Commit();
            return entity;
        }

        public T Update(T entity)
        { 
            this._dbSet.Update(entity);
            this.Commit();
            return entity;
        }

        public bool Delete(T entity)
        {
            this._dbSet.Remove(entity);
            return this.Commit();
        }

        public bool Commit()
        {
            return this._context.SaveChanges() > 0;
        }
    }
}
