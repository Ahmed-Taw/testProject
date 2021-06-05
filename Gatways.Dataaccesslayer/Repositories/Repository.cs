using Gatways.Dataaccesslayer.Infrastructure.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Gatways.Dataaccesslayer.Repositories
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        private readonly GatewaysDbContext gatewaysDbContext;

        public Repository(GatewaysDbContext gatewaysDbContext)
        {
            this.gatewaysDbContext = gatewaysDbContext;
        }
        public TEntity GetById(int id)
        {
            return gatewaysDbContext.Set<TEntity>().Find(id);
        }

        public TEntity GetById(Guid id)
        {
            return gatewaysDbContext.Set<TEntity>().Find(id);
        }

        public TEntity GetById(string id)
        {
            return gatewaysDbContext.Set<TEntity>().Find(id);
        }

        public void Add(TEntity entity)
        {
            gatewaysDbContext.Set<TEntity>().Add(entity);
        }

        public void AddRange(IEnumerable<TEntity> entities)
        {
            gatewaysDbContext.Set<TEntity>().AddRange(entities);
        }

        public IEnumerable<TEntity> GetAll()
        {
            return gatewaysDbContext.Set<TEntity>().ToList();
        }
        public void Remove(TEntity entity)
        {
            gatewaysDbContext.Set<TEntity>().Remove(entity);
        }
    }
}
