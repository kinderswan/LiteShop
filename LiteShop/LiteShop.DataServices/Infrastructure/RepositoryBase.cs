using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;

namespace LiteShop.DataServices.Infrastructure
{
    public abstract class RepositoryBase<T> where T : class
    {
        private LiteShopEntities dataContext;
        private readonly IDbSet<T> dbSet;

        protected IDbFactory DbFactory
        {
            get;
            private set;
        }

        protected LiteShopEntities DbContext
        {
            get { return this.dataContext ?? (this.dataContext = this.DbFactory.Init()); }
        }

        protected RepositoryBase(IDbFactory dbFactory)
        {
            this.DbFactory = dbFactory;
            this.dbSet = this.DbContext.Set<T>();
        }

        public virtual void Add(T entity)
        {
            this.dbSet.Add(entity);
        }

        public virtual void Update(T entity)
        {
            this.dbSet.Attach(entity);
            this.dataContext.Entry(entity).State = EntityState.Modified;
        }

        public virtual void Delete(int id)
        {
            T entity = this.dbSet.Find(id);
            this.dbSet.Remove(entity);
        }

        public virtual T GetById(int id)
        {
            return this.dbSet.Find(id);
        }

        public virtual IList<T> GetAll()
        {
            return this.dbSet.ToList();
        }
    }
}