namespace LiteShop.DataServices.Infrastructure
{
    public class DbFactory : Disposable, IDbFactory
    {
        private LiteShopEntities dbContext;

        public LiteShopEntities Init()
        {
            return this.dbContext ?? (this.dbContext = new LiteShopEntities());
        }

        protected override void DisposeCore()
        {
            if (this.dbContext != null)
                this.dbContext.Dispose();
        }
    }
}