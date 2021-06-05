using System;
using System.Collections.Generic;
using System.Text;

namespace Gatways.Dataaccesslayer.Infrastructure.IRepositories
{
    public interface IRepository<TEntity> where TEntity : class
    {
        TEntity GetById(int id);
        TEntity GetById(Guid id);
        TEntity GetById(string id);
        IEnumerable<TEntity> GetAll();
        void Add(TEntity entity);
        void AddRange(IEnumerable<TEntity> entities);
        void Remove(TEntity entity);

    }
}
