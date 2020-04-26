using System;
using System.Collections.Generic;
using System.Text;

namespace TreinamentoLinq.Domain.Base
{
    public interface IRepositoryBase<T> where T : Entity
    {
        IEnumerable<T> GetAll();
        T Get(params object[] keyValues);
        T Save(T entity);
        T Update(T entity);
        bool Delete(T entity);
        bool Commit();
    }
}
