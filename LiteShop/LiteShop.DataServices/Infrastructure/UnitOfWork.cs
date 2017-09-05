namespace LiteShop.DataServices.Infrastructure
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly IDbFactory dbFactory;
        private LiteShopEntities dbContext;

        public UnitOfWork(IDbFactory dbFactory)
        {
            this.dbFactory = dbFactory;
        }

        public LiteShopEntities DbContext
        {
            get { return this.dbContext ?? (this.dbContext = this.dbFactory.Init()); }
        }

        public void Commit()
        {
            this.DbContext.SaveChanges();
        }
    }
}